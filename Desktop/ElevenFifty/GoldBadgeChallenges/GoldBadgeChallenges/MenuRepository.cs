using System;
using System.Collections.Generic;
using System.Text;

namespace GoldBadgeChallenges
{
    class MenuRepository
    {
        private List<MenuItems> _listOfMenuItems = new List<MenuItems>();

        public void CreateMenuItem(MenuItems meal)
        {
            _listOfMenuItems.Add(meal);
        }

        public List<MenuItems> ShowAllMenuItems()
        {
            return _listOfMenuItems;
        }

        private MenuItems GetMenuItemByMealName(string name)
        {
            foreach (MenuItems meal in _listOfMenuItems)
            {

                if (meal.MealName == name)
                {
                    return meal;
                }
            }
            return null;
        }



        public bool DeleteMenuItem(string meal)
        {
            MenuItems menuItem = GetMenuItemByMealName(meal);
            if (menuItem == null)
            {
                return false;
            }

            int initialListCount = _listOfMenuItems.Count;
            _listOfMenuItems.Remove(menuItem);

            if (initialListCount > _listOfMenuItems.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
