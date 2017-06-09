using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using RecipeRolodex.Models;

namespace RecipeRolodex.DAL
{
    public class RolodexContext : DbContext
    {
        public RolodexContext() : base("RolodexContext")
        {

        }

        public System.Data.Entity.DbSet<RecipeRolodex.Models.Drink> Drinks { get; set; }

        public DbSet<Recipe> Recipes { get; set; }
        //public DbSet<Drink> Drinks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
