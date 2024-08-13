using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Data
{
    public class MenuService
    {
        //read only list
        private readonly List<MenuItem> _menuItems = new List<MenuItem>();

        //adds items to menu list from menu.razor
        public void AddMenuItem(MenuItem item)
        {
            _menuItems.Add(item);
        }

        //searches for items in list and returns it and removes items if item is not null 
        public void RemoveMenuItem(int itemNumber)
        {
            var item = _menuItems.FirstOrDefault(m => m.ItemNumber == itemNumber);
            if (item != null)
            {
                _menuItems.Remove(item);
            }
        }

        //returns menuitem list
        public IEnumerable<MenuItem> GetMenuItems()
        {
            return _menuItems;
        }
    }
}

