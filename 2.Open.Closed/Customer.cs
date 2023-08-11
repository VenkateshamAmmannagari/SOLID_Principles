using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Open.Closed
{
    internal class Customer
    {
        public decimal GetTotal(decimal SubTotal, CustomerType customerType)
        {
            switch (customerType)
            {
                case CustomerType.Bronze:
                    return SubTotal += SubTotal * .2M;
                case CustomerType.Silver:
                    return SubTotal += SubTotal * .3M;
                case CustomerType.Gold:
                    return SubTotal += SubTotal * .4M;
                default: return SubTotal;
            }
        }
    }
}
