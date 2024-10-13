using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230812_Metodlar_Ornek2
{
    internal class Metodlar
    {
        public int ToplamaYaptir(int[] sayilar)
        {
            int toplam = 0;
            foreach (var item in sayilar)
            {
                toplam += item;
            }
            return toplam;
        }

        public void ToplamiVeOrtalamayiYazdir(int toplam,int adet)
        {
            Console.WriteLine("Girdiğiniz Sayıların Toplamı = "+toplam);
            Console.WriteLine("Girdiğiniz Sayıların Ortalaması = "+((double)toplam/adet));
        }
    }
}
