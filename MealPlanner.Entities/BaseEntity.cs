using System;

namespace MealPlanner.Entities
{
    public class BaseEntity : IBaseEntity
    {
        public int Id
        {
            get;
            set;
        }
    }

    public interface IBaseEntity
    {
        int Id
        {
            get;
            set;
        }
    }
}
