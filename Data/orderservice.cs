using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RMS.Components.Pages.Order;

namespace RMS.Data
{
    public class OrderService
    {
        //read only list for orders
        private readonly List<CusOrder> _orders = new List<CusOrder>();

        //adds orders to list from order.razor
        public void AddOrder(CusOrder order)
        {
            _orders.Add(order);
        }

        //returns order list
        public IEnumerable<CusOrder> GetOrders()
        {
            return _orders;
        }
    }
}


