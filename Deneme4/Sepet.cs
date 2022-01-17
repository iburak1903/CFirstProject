using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deneme4
{
    internal class Sepet
    {
        public void sepet(Deneme4.Esya urun)
        {
            Console.WriteLine("Sepetim:" + urun.Adi);


        }     
        public void Toplam(int number1,int number2,int number3)
        {
            int Toplam = number1 + number2 + number3;
            Console.WriteLine("Alışveriş Toplam Fiyatı: " + Toplam);
 
        }
        public void Toplam2(int number4,int number5,int number6)
        {
            int Toplam2 = number4 + number5 + number6;
            Console.WriteLine("Toplam Stok Adedi: " + Toplam2);
        }


    }
}
        


