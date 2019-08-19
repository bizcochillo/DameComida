using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using DameComidaMobile.Model;
using Xunit;

namespace DameComidaMobile.Tests
{
    public class YamlTestsTO_DELETE
    {
        private void ReadFile(string inputFile)
        {
            var listDays = new List<Dictionary<DietScheduledMealType, List<string>>>();

            using (var sr = new StreamReader(inputFile))
            {
                var day = new Dictionary<string, List<string>>();
                List<string> bulkMeal = null;
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine();
                    // Blank lines discarded;
                    if (line == string.Empty || line?.Length == 0) continue;
                    if (line.StartsWith('#'))
                    {
                        // New Meal
                        bulkMeal = new List<string>();
                        day.Add(line.Substring(1), bulkMeal);
                        

                        continue;
                    }

                    if (line.StartsWith("--"))
                    {
                        // New Day
                    }

                }
            }
        }

        [Fact]
        public void SaveYamlTests()
        {
            ReadFile("planInput.txt");
            var outputFile = "plan.yaml";
            var day = new DietDay();
            var meal = new DietScheduledMeal();
            meal.FoodList.Add(food);
            day.Meals.Add(DietScheduledMealType.Breakfast, meal);
            day.Meals.Add(DietScheduledMealType.MidMorning, meal);
            day.Meals.Add(DietScheduledMealType.Lunch, meal);
            day.Meals.Add(DietScheduledMealType.AfternoonSnack, meal);
            day.Meals.Add(DietScheduledMealType.Dinner, meal);
            var diet = new Diet();
            diet.AddDay(day);
        }
    }
}
