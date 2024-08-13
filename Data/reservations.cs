using RMS.Components.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Data
{
    //class getter setters using interface for customer name
    public class Reservation : CustomerInfo
    {
        public string? CustomerName { get; set; }
        public DateTime ReservationDateTime { get; set; }
        public int NumberOfPeople { get; set; }
    }

}
