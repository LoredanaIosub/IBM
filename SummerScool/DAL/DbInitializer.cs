using SummerScool.DAL.DbModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SummerScool.DAL
{
    public class DbInitializer : DropCreateDatabaseIfModelChanges<SummerSchoolDbContext> //Mostenirea unei alte clase
    {
        protected override void Seed(SummerSchoolDbContext context)
        {
            User user = new User()
            {
                Id = Guid.Empty,
                Email = "admin@admin.ro",
                UserName = "admin",
                Password = "adminadmin",
                FirstName = "Admin",
                LastName = "Admin",
                BirthDate = DateTime.Now.AddYears(-18),
                CreateAt = DateTime.Now,
                ModifiedAt = DateTime.Now.AddHours(-18)
        
            };

            context.Users.Add(user);
            context.SaveChanges();
        }
    }

    
}