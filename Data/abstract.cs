using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Data
{
    //abstract class for item amounts for order and menu items
    public abstract class ItemAmount
    {
        protected int Quantity;

        protected ItemAmount() { }
    }

}
