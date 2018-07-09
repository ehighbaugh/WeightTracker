using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeightTracker.Models
{
    public class WeightMs : Measurement
    {
        public WeightUnits Units { get; set; }
    }
}