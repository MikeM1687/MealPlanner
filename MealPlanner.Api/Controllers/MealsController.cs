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
    [Route("api/Meals")]
    public class MealsController : Controller
    {
        private readonly IDataService _dataService;

        public MealsController(IDataService dataService)
        {
            _dataService = dataService;
        }

        [HttpGet]
        public IEnumerable<Meal> GetMeals()
        {
            return _dataService.GetMeals();
        }
    }
}