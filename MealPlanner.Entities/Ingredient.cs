using System;
using System.Collections.Generic;
using System.Text;

namespace MealPlanner.Entities
{
    public class Ingredient : BaseEntity
    {
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public string Units { get; set; }
    }
}
