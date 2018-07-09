using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WeightTracker.Models;

namespace WeightTracker.Data
{
    public class WeightContext : DbContext
    {
        public WeightContext() : base("WeightTrackerDB")
        {
            Database.SetInitializer<WeightContext>(new DropCreateDatabaseIfModelChanges<WeightContext>());
        }

        public DbSet<Animal> Animals { get; set; }
        public DbSet<WeightMs> Weights { get; set; }
        public DbSet<LengthMs> Lengths { get; set; }
        public DbSet<GirthMs> Girths { get; set; }
    }
}