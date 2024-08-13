using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Data
{
    //class using interface to set name to empty and list as a new empty list
    public class CusOrder : CustomerInfo
    {
        public string CustomerName { get; set; } = string.Empty;
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
    }

    //order item that has list and quantity
    public class OrderItem
    {
        public MenuItem MenuItem { get; set; } = new MenuItem();
        public int Quantity { get; set; }
    }

}



