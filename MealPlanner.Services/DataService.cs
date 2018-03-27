using MealPlanner.Entities;
using MealPlanner.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MealPlanner.Services
{
    public class DataService<T> : IDataService
    {
        private readonly IUnitOfWork _unitOfWork;

        public DataService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public List<Meal> GetMeals()
        {
            return _unitOfWork.MealRepository.GetAll().ToList();
        }

        public List<Ingredient> GetIngredients()
        {
            return _unitOfWork.IngredientRepository.GetAll().ToList();
        }
    }
}
