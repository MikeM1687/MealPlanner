using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MealPlanner.Entities
{
    public class MealPlannerContext : DbContext
    {
        public MealPlannerContext(DbContextOptions<MealPlannerContext> options)
            : base(options) { }

        public DbSet<Meal> Meals { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
    }
}
