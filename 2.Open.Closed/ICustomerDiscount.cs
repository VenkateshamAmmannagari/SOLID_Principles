using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Open.Closed
{
    internal interface ICustomerDiscount
    {
        public decimal CustomerPrice(decimal price);
    }
}
