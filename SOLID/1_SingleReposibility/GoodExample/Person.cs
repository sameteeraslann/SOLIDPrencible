using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._1_SingleReposibility.GoodExample
{
    //Good Example 
    public class Person
    {
        public void ChangePersonName()
        {
            // Personel adını değiştirir.
        }
        public void ChangePersonEMailAdress()
        {
            // Personel E-mail adresini değiştirir.
        }
    }
    // Good example da gördüğümüz gibi Email gönder için ayrı bir sınıf açtık ve Person classından bağımsız bir hale geldi ve ileride değişiklik yaptığımız zaman Person sınıfından bağımsız olacağı için artık bu sınıfı ilgilendirmeyecektir.
}
