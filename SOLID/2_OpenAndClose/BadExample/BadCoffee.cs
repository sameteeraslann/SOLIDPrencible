using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._2_OpenAndClose.BadExample
{
    public enum CoffeType { Sahlep, Water,Tea }
   public class BadCoffee
    {
        public double GetTotalPrice(double amount, CoffeType coffeType)
        {
            double totalPrice = 0;
            if (coffeType == CoffeType.Sahlep)
            {
                totalPrice += amount * 2.6;
            }
            else if (coffeType == CoffeType.Tea)
            {
                totalPrice += amount * 1.25;
            }
            else if (coffeType == CoffeType.Water)
            {
                totalPrice += amount *0.5;
            }
            return totalPrice;
        }

        // Burada gördüğümüz üzere Sipariş türü ve liste fiyatımızı yazdık. Fakat daha sonra bu sipariş türlerinden herhangi birini değiştirmeye kalktığımızda, eklemeye kalktığımızda veya  birim fiyatları üzerinde güncellemeye gidildiğinde bütün kod satırı üzerinde değişiklik yapmak zorunda kalacağız. Bu bizim için büyük bir zaman kaybıdır.
	
    }
}
