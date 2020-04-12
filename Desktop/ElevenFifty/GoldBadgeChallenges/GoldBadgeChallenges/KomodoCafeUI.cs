using System;
using System.Collections.Generic;
using System.Text;

namespace GoldBadgeChallenges
{
    class KomodoCafeUI
    {
        private MenuRepository _menuRepo = new MenuRepository();

        public void Run()
        {
            CafeMenu();
        }

        public void CafeMenu()
        {
            bool keepProgramRunning = true;
            while (keepProgramRunning)
            {
                Console.Clear();
                Console.WriteLine("Please select an option below:\n" +
                    "1. Create a new menu item:\n" +
                    "2. See all menu items:\n" +
                    "3. Delete a menu item:\n" +
                    "4. Exit");
                string userInput = Console.ReadLine();

                if (userInput == "1")
                {
                    CreateNewMeal();
                }
                else if (userInput == "2")
                {
                    ViewAllMenuItems();
                }
                else if (userInput == "3")
                {
                    RemoveMenuItem();
                }
                else if (userInput == "4")
                {
                    keepProgramRunning = false;
                }
                else
                {
                    Console.WriteLine("Selection unknown. Please try again");
                    CafeMenu();

                }
            }
        }
        private void CreateNewMeal()
        {
            Console.Clear();
            MenuItems newMeal = new MenuItems();
            Console.WriteLine("Enter the name of the meal:\n");
            newMeal.MealName = Console.ReadLine();
            Console.WriteLine("Enter the corresponding meal number on the menu:\n");
            newMeal.MealNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the price of the meal:\n");
            newMeal.MealPrice = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the meal description:\n");
            newMeal.MealDescription = Console.ReadLine();
            newMeal.MealIngredients = CreateIngredientList();
            _menuRepo.CreateMenuItem(newMeal);
        }

        public List<string> mealIngredientsList = new List<string>();

        private List<string> CreateIngredientList()
        {

            Console.WriteLine("Enter an ingredient in the meal:\n");
            string ingredient = Console.ReadLine();
            Console.WriteLine("Would you like to add another ingredient? (y/n)");
            string answer = Console.ReadLine();
            if (answer.ToLower() == "y")
            {
                mealIngredientsList.Add(ingredient);
                CreateIngredientList();
            }
            else
            {
                mealIngredientsList.Add(ingredient);
            }
            return mealIngredientsList;
        }

        private void ViewAllMenuItems()
        {
            Console.Clear();
            List<MenuItems> menuList = _menuRepo.ShowAllMenuItems();
            foreach(MenuItems meal in menuList)
            {
                Console.WriteLine($" \n\nMeal name: {meal.MealName}\n" +
                    $"\nMeal number: {meal.MealNumber}\n" +
                    $"\nMeal price: {meal.MealPrice.ToString("C")}\n" +
                    $"\nMeal description: {meal.MealDescription}\n" +
                    $"\nIngredients: ");
                    foreach (string ingredient in meal.MealIngredients)
                    {
                    Console.WriteLine(ingredient);
                    }
            }
            Console.ReadLine();
        }

        private void RemoveMenuItem()
        {
            ViewAllMenuItems();
            Console.WriteLine("Please enter the name of the meal that you would like to remove:");
            string menuItemRemoval = Console.ReadLine();
            bool itemWasDeleted = _menuRepo.DeleteMenuItem(menuItemRemoval);
            if (itemWasDeleted == true)
            {
                Console.WriteLine("Item was successfully removed from the menu.");
            }
            else
            {
                Console.WriteLine("This item was not found. Please try again.");
            }
        }
    }
}
