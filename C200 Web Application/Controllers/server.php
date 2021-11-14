<?php
session_start();

$username = "";
$password = "";

$errors = array();

$db = mysql_connect('localhost','root','','account') or die("could not connect to database");

//form validation

if(empty($username)) {array_push($errors, "Username is required")};
if(empty($password)) {array_push($errors, "Password is required")};

$sql = "select * from loginform where user='".$username."'AND Password='".$password."' limit 1";

$result=mysql_query($sql);

    if(mysql_num_row($result)==1){
    ViewData["Message"] = "Logged In";
    exit();
    }

    else{
    ViewData["Message"] = "You have Entered an Incorrect Password";
    exit();
    }
    header('location: login.cshtml');
?>

