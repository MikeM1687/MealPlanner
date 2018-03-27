using System;
using System.Collections.Generic;
using System.Text;

namespace MealPlanner.Entities
{
    public class Meal : BaseEntity
    {
        public string Name { get; set; }
        public List<Ingredient> Ingredients { get; set; }
    }
}
