using SOLID._4_LiskovSubstition.BadExample.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._4_LiskovSubstition.BadExample.Concrete
{
    public class Chicken : IBird
    {
        public string Fly()
        {
            return "Tavuklar uçamaz.";
        }

        public string Walk()
        {
            return "Tavuklar yürüyebilir";
        }
    }
}
