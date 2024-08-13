using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Data
{
    //getters and setters for menu item and partial orders
    public class MenuItem
    {
        public int ItemNumber { get; set; }
        public string ItemName { get; set; }
        public decimal Price { get; set; }
        public int? SelectedItem { get; set; }
        public int Quantity { get; set; }
    }
}



