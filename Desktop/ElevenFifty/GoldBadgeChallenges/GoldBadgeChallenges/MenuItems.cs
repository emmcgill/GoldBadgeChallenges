using System;
using System.Collections.Generic;
using System.Text;

namespace GoldBadgeChallenges
{
    class MenuItems
    {
        public int MealNumber { get; set; }
        public string MealName { get; set; }
        public string MealDescription { get; set; }
        public double MealPrice { get; set; }
        public List<string> MealIngredients { get; set; }


        public MenuItems()
        {

        }

        public MenuItems(int mealNumber, string name, double price, string description, string ingredients)
        {
            MealNumber = mealNumber;
            MealName = name;
            MealPrice = price;
            MealDescription = description;
            MealIngredients.Add(ingredients);
        }
    }
}
