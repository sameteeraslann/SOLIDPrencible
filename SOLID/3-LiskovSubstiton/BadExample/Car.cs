using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._3_LiskovSubstiton.BadExample
{
   public abstract class Car
    {
        public string Run()
        {
            return "Araba çalıştırıldı";
        }
        public abstract string OpenAirConditioning();
    }


    public class Ferrari:Car
    {
        public override string OpenAirConditioning()
        {
            return "Klima açıldı";
        }

    }
    // Buraya kadar herşey çok güzel Car sınıfındaki OpenAirConditioning() 'dan kalıtım aldık ve Ferrari'nin klimasını açtık fakat kliması olmayan bir araç için ekleme yaptığımızda program bize hata verir veya null değer döndürür.

    public class DoganSLX : Car
    {
        public override string OpenAirConditioning()
        {
            throw new NotImplementedException();
        }

        // Bu sınıfı oluşturduktan sonra işlemlere devam ettiğimizde bizim için artık zor ve sıkıcı bir süreç başlar.
    }
}
