using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._1_SingleReposibility.BadExample
{
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
        public void SendAnEmail()
        {
            // EMail gönderir.
        }
        // İlk başta bakıldığında mantıklı ve düzgün gözükse de aslında Single Reposibility Principle göre hatalı bir tasarımdır. "ChangePersonName" & "ChangePersonEMailAdress" methodları "Person" classının sorumluluğu altındadır ama "SendAnEmail" methodu bu sorumluluk altında değildir. 

    }
}
