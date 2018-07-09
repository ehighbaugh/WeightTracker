using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WeightTracker.Data
{
    public class WeightInitializer : DropCreateDatabaseIfModelChanges<WeightContext>
    {
        protected override void Seed(WeightContext context)
        {
            base.Seed(context);
        }
    }
}