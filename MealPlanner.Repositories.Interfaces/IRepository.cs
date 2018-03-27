using System;
using System.Collections.Generic;

namespace MealPlanner.Repositories.Interfaces
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
    }
}
