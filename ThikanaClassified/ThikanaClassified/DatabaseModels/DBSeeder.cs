using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ThikanaClassified.DatabaseModels
{
    public class DBSeeder : DropCreateDatabaseIfModelChanges<ClassifiedDbContext>
    {
        protected override void Seed(ClassifiedDbContext context)
        {
            Authentication Admin = new Authentication()
            {
                User = "sa",
                Password = "sa"
            };

            context.Authentication.Add(Admin);
            context.SaveChanges();
            base.Seed(context);

        }
    }
}