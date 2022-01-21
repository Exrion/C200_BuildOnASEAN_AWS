# import the necessary packages
from tensorflow.keras.applications.mobilenet_v2 import preprocess_input
from tensorflow.keras.preprocessing.image import img_to_array
from tensorflow.keras.models import load_model
from imutils.video import VideoStream
from flask import Flask,render_template
import numpy as np
import imutils
import time
import cv2
import os
import dlib
import threading
import time
import schedule
import os.path
import boto3







client = boto3.client('sns','us-east-1')
# client.publish(PhoneNumber='+6597730754', Message="Test from python app") ## Add if statement to only send when no mask detected



def printit():
	print(face_count)
#timer = threading.Timer(10.0, printit)

#def screenshot():
#		img_name = "screenshot{}.png".format(img_counter)
#		cv2.imwrite(img_name,frame)
#		print("Screenshot Taken " + str(img_name))
#		img_counter += 1

save_path = 'wwwroot/Images/Screenshot'


def detect_and_predict_mask(frame, faceNet, maskNet):
	# grab the dimensions of the frame and then construct a blob
	# from it
	(h, w) = frame.shape[:2]
	blob = cv2.dnn.blobFromImage(frame, 1.0, (224, 224),
		(104.0, 177.0, 123.0))

	# pass the blob through the network and obtain the face detections
	faceNet.setInput(blob)
	detections = faceNet.forward()
	print(detections.shape)


	# initialize our list of faces, their corresponding locations,
	# and the list of predictions from our face mask network
	faces = []
	locs = []
	preds = []

	# loop over the detections
	for i in range(0, detections.shape[2]):
		# extract the confidence (i.e., probability) associated with
		# the detection
		confidence = detections[0, 0, i, 2]
		

		# filter out weak detections by ensuring the confidence is
		# greater than the minimum confidence
		if confidence > 0.5:
			# compute the (x, y)-coordinates of the bounding box for
			# the object
			box = detections[0, 0, i, 3:7] * np.array([w, h, w, h])
			(startX, startY, endX, endY) = box.astype("int")

			# ensure the bounding boxes fall within the dimensions of
			# the frame
			(startX, startY) = (max(0, startX), max(0, startY))
			(endX, endY) = (min(w - 1, endX), min(h - 1, endY))


			# extract the face ROI, convert it from BGR to RGB channel
			# ordering, resize it to 224x224, and preprocess it
			face = frame[startY:endY, startX:endX]
			face = cv2.cvtColor(face, cv2.COLOR_BGR2RGB)
			face = cv2.resize(face, (224, 224))
			face = img_to_array(face)
			face = preprocess_input(face)

			# add the face and bounding boxes to their respective
			# lists
			faces.append(face)
			locs.append((startX, startY, endX, endY))



	# only make a predictions if at least one face was detected
	if len(faces) > 0:
		# for faster inference we'll make batch predictions on *all*
		# faces at the same time rather than one-by-one predictions
		# in the above `for` loop
		faces = np.array(faces, dtype="float32")
		preds = maskNet.predict(faces, batch_size=32)

	# return a 2-tuple of the face locations and their corresponding
	# locations
	return (locs, preds)

# load our serialized face detector model from disk
prototxtPath = r"D:\FaceMaskDetection\face_detector\deploy.prototxt"
weightsPath = r"D:\FaceMaskDetection\face_detector\res10_300x300_ssd_iter_140000.caffemodel"
faceNet = cv2.dnn.readNet(prototxtPath, weightsPath)

# load the face mask detector model from disk
maskNet = load_model("mask_detector.model")

# initialize the video stream
print("[INFO] starting video stream...")
vs = VideoStream(src=0).start()

# Counter for screenshot taken
img_counter = 0
msg_counter = 50

# loop over the frames from the video stream
while True:
	# grab the frame from the threaded video stream and resize it
	# to have a maximum width of 400 pixels
	frame = vs.read()
	frame = imutils.resize(frame, width=400)

	sendMsg = False



	# detect faces in the frame and determine if they are wearing a
	# face mask or not
	(locs, preds) = detect_and_predict_mask(frame, faceNet, maskNet)

	# loop over the detected face locations and their corresponding
	# locations
	face_count = 0


	for (box, pred) in zip(locs, preds):
		# unpack the bounding box and predictions
		(startX, startY, endX, endY) = box
		(mask, withoutMask) = pred

		# Count the number of boxes created
		face_count = face_count+1

		maskP = mask * 100
		withoutMaskP = withoutMask * 100

		# determine the class label and color we'll use to draw
		# the bounding box and text
		label = "Mask" if mask > withoutMask else "No Mask"
		color = (0, 255, 0) if label == "Mask" else (0, 0, 255)




		# include the probability in the label
		label = "{}: {:.2f}%".format(label, max(mask, withoutMask) * 100)

		# display the label and bounding box rectangle on the output
		# frame
		cv2.putText(frame, label, (startX, startY - 10),
			cv2.FONT_HERSHEY_SIMPLEX, 0.45, color, 2)
		cv2.rectangle(frame, (startX, startY), (endX, endY), color, 2)


	if maskP < 70 and withoutMaskP < 70:
		img_name = "screenshot{}.png".format(img_counter)
		complete_name = os.path.join(save_path, img_name)
		cv2.imwrite(complete_name,frame)
		print("Screenshot Taken " + str(img_name))
		img_counter += 1

	if withoutMaskP > 95:
		msg_counter -= 1
		print("Time left till msg sent: " + str(msg_counter))
		if msg_counter == 0:
			client.publish(TopicArn="arn:aws:sns:us-east-1:111369219419:Mask_Notification", Message="Without Mask: " + str(withoutMaskP), Subject="Mask_Notification")
			print("Message Sent")
			msg_counter = 100

	# show the output frame
	print("[INFO] Total Number Of People: " + str(face_count))
	cv2.imshow("Frame", frame)
	key = cv2.waitKey(1) & 0xFF

	# if the `q` key was pressed, break from the loop
	if key == ord("q"):
		break





print("[INFO] Last Number Of Faces Detected: " + str(face_count));



# do a bit of cleanup
cv2.destroyAllWindows()
vs.stop()



