using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Open.Closed
{
    public abstract class CustomerDiscount
    {
        public abstract decimal CustomerPrice(decimal price);
    }
}
