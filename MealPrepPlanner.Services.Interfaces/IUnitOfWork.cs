using MealPlanner.Entities;
using MealPlanner.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MealPlanner.Services.Interfaces
{
    public interface IUnitOfWork
    {
        IRepository<Meal> MealRepository { get; }
        IRepository<Ingredient> IngredientRepository { get; }
    }
}
