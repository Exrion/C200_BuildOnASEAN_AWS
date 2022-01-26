using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C200_Web_Application___Identity.Models
{
    public class Statistics
    {
        [Name("Loss")]
        public double Loss { get; set; }
        [Name("Valid Loss")]
        public double ValidLoss { get; set; }
        [Name("Acc")]
        public double Accuracy { get; set; }
        [Name("Valid Acc")]
        public double ValidAccuracy { get; set; }
    }
}
