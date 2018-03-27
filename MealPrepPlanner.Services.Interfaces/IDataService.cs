using MealPlanner.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MealPlanner.Services.Interfaces
{
    public interface IDataService
    {
        List<Meal> GetMeals();
        List<Ingredient> GetIngredients();
    }
}
