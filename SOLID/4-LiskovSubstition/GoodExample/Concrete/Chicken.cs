using SOLID._4_LiskovSubstition.GoodExample.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._4_LiskovSubstition.GoodExample.Concrete
{
    public class Chicken : IFligtlessBird
    {
        public string Walk()
        {
            throw new NotImplementedException();
        }
    }
}
