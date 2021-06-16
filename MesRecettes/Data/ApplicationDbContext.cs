using MesRecettes.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MesRecettes.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<FoodEthnicity> FoodEthnicities { get; set; }
        public  DbSet<FoodType> FoodTypes { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<RecipeIngredient> RecipeIngredients { get; set; }
        public DbSet<UnitsOfMeasure> UnitsOfMeasures { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<RecipeIngredient>()
                .HasKey(t => new { t.RecipeId, t.IngredientId });
        }
    }
}
