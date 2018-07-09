using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeightTracker.Models
{
    public class Animal
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Species { get; set; }
        public Gender Gender { get; set; }
        public string ColorPattern { get; set; }

        public ICollection<WeightMs> Weights { get; set; }
        public ICollection<LengthMs> Lengths { get; set; }
        public ICollection<GirthMs> Girths { get; set; }
    }
}