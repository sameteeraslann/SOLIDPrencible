using SOLID._3_LiskovSubstiton.GoodExample.Abstract;
using SOLID._3_LiskovSubstiton.GoodExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._3_LiskovSubstiton.GoodExample.Concrete
{
    public class Ferrari : Car, IAirConditionable
    {
        public void OpenAirConditioning()
        {
            string message= "Klima açıldı";
        }

      
    }
}
