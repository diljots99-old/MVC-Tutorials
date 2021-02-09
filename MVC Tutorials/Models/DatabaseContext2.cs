using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MVC_Tutorials.Models
{
    public class DatabaseContext2 : DbContext
    {
        public DatabaseContext2() : base("DatabaseContext")
        {

        }

        public DbSet<UserModel2> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }



    }
}