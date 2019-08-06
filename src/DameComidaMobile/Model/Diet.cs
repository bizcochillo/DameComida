using System;
using System.Collections.Generic;
using System.Text;

namespace DameComidaMobile.Model
{
    public class Diet
    {
        private List<DietDay> _days;
        public ICollection<DietDay> Days => _days;

        public Diet()
        {
            _days = new List<DietDay>();
        }

        public void AddDay(DietDay day)
        {
            _days.Add(day);
        }

    }

    public class DietDay
    {
        private Dictionary<DietScheduledMealType, DietScheduledMeal> _meals;
        public IDictionary<DietScheduledMealType, DietScheduledMeal> Meals => _meals;

        public DietDay()
        {
            _meals = new Dictionary<DietScheduledMealType, DietScheduledMeal>();
            _meals.Add(DietScheduledMealType.Breakfast, new DietScheduledMeal());
            _meals.Add(DietScheduledMealType.MidMorning, new DietScheduledMeal());
            _meals.Add(DietScheduledMealType.Lunch, new DietScheduledMeal());
            _meals.Add(DietScheduledMealType.AfternoonSnack, new DietScheduledMeal());
            _meals.Add(DietScheduledMealType.Dinner, new DietScheduledMeal());
        }
    }

    public enum DietScheduledMealType
    {
        Breakfast,
        MidMorning,
        Lunch,
        AfternoonSnack,
        Dinner
    }

    public class DietScheduledMeal
    {
        public IList<DietFood> FoodList { get; }

        public DietScheduledMeal()
        {
            FoodList = new List<DietFood>();
        }
    }

    public class DietFood
    {
        public int WeigthInGr { get; }
        public string Name { get; }

        public List<DietFood> Components { get; }

        public DietFood(string name, int weightInGr)
        {
            Name = name;
            WeigthInGr = weightInGr;
        }

        public DietFood(string name)
        {
            Name = name;
            Components = new List<DietFood>();
        }
    }

    public class DietTracking : Diet
    {
        public DateTime FirstDay { get; private set; }

        public DateTime LastDay { get; private set; }

        public Diet TrackedDiet { get; }

        public DietTracking(Diet diet)
        {
            TrackedDiet = diet;
        }

        public DietDay GetDay(DateTime day)
        {
            throw new NotImplementedException();
        }

        public DietScheduledMeal GetNextNotTrackedMeal()
        {
            throw new NotImplementedException();
        }
    }
}
