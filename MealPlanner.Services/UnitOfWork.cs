using MealPlanner.Entities;
using MealPlanner.Repositories.Interfaces;
using MealPlanner.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MealPlanner.Services
{
    public class UnitOfWork : IUnitOfWork
    {
        private MealPlannerContext _context { get; }

        public IRepository<Meal> MealRepository { get; }
        public IRepository<Ingredient> IngredientRepository { get; }

        public UnitOfWork(MealPlannerContext context,
            IRepository<Meal> mealRepository,
            IRepository<Ingredient> ingredientRepository)
        {
            _context = context;
            MealRepository = mealRepository;
            IngredientRepository = ingredientRepository;
        }
    }
}
