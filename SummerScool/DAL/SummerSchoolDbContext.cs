using SummerScool.DAL.DbModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;

namespace SummerScool.DAL
{
    public class SummerSchoolDbContext : DbContext //mostenire
    {
        public SummerSchoolDbContext() : base("ConnectionString")
        {
            Database.SetInitializer<SummerSchoolDbContext>(new DbInitializer());
        }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove();
        }

    }
}