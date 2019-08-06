using System;
using Xunit;
using DameComidaMobile.Model;

namespace DameComidaMobile.Tests
{
    public class DietTests
    {
        [Fact]
        public void GivenNewDiet_WhenCreated_ThenCountOfDaysIs0()
        {
            var diet = new Diet();
            Assert.Equal(0, diet.Days.Count);
        }

        [Fact]
        public void GivenNewDiet_WhenDayAdded_ThenCountOfDaysIsIncremented()
        {
            var diet = new Diet();
            diet.AddDay(new DietDay());
            Assert.Equal(1, diet.Days.Count);
        }

        [Fact]
        public void GivenNewDietDay_WhenCreated_ThenMealsAreCreated()
        {
            var dietDay = new DietDay();

            Assert.NotNull(dietDay.Meals[DietScheduledMealType.Breakfast]);
            Assert.NotNull(dietDay.Meals[DietScheduledMealType.MidMorning]);
            Assert.NotNull(dietDay.Meals[DietScheduledMealType.Lunch]);
            Assert.NotNull(dietDay.Meals[DietScheduledMealType.AfternoonSnack]);
            Assert.NotNull(dietDay.Meals[DietScheduledMealType.Dinner]);
        }

        [Fact]
        public void GivenNewDietScheduledMeal_WhenCreated_ThenFoodCountIs0()
        {
            var dietMeal = new DietScheduledMeal();
            Assert.Equal(0, dietMeal.FoodList.Count);
        }

        [Fact]
        public void GivenNewDietScheduledMeal_WhenNewFoodAdded_ThenFoodIsTracked()
        {
            var dietMeal = new DietScheduledMeal();
            var food = new DietFood("Name", 24);
            dietMeal.FoodList.Add(food);
            var foodAdded = dietMeal.FoodList[0];
            Assert.Equal(food.Name, foodAdded.Name);
            Assert.Equal(food.WeigthInGr, foodAdded.WeigthInGr);

        }

        [Fact]
        public void GivenNewFood_WhenCreatedWithWeight_ThenComponentsIsNull()
        {
            var food = new DietFood("Name", 24);
            Assert.Null(food.Components);
        }

        [Fact]
        public void GivenNewFood_WhenCreatedWithWeight_ThenNameAndWeightAreSet()
        {
            var food = new DietFood("Name", 24);

            Assert.Equal("Name", food.Name);
            Assert.Equal(24, food.WeigthInGr);
        }

        [Fact]
        public void GivenNewFood_WhenCreatedWithoutWeight_ThenComponentsIsNotNull()
        {
            var food = new DietFood("Name");

            Assert.NotNull(food.Components);
            Assert.Equal("Name", food.Name);
        }
    }
}
