using MealPlanner.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MealPlannerClient
{
    public interface IRestClient
    {
        Task<IEnumerable<Meal>> GetMeals(CancellationToken token);
    }
}
