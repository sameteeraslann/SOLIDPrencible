using SOLID._2_OpenAndClose.GoodExample.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._2_OpenAndClose.GoodExample.Concrete
{
    public class Tea :GoodCoffee
    {
        public override double GetTotalPrice(double amount)
        {
            return amount * 1.25;
        }
    }
}
