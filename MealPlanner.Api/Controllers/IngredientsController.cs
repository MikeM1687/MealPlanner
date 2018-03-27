using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MealPlanner.Entities;
using MealPlanner.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MealPlanner.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/Ingredients")]
    public class IngredientsController : Controller
    {
        private readonly IDataService _dataService;

        public IngredientsController(IDataService dataService)
        {
            _dataService = dataService;
        }

        [HttpGet]
        public IEnumerable<Ingredient> GetIngredients()
        {
            return _dataService.GetIngredients();
        }
    }
}