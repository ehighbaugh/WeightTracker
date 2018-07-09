using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WeightTracker.Models
{
    public abstract class Measurement
    {
        public int ID { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

        public double Amount { get; set; }

        public Animal Animal { get; set; }
    }
}