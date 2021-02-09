using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007YasHesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Doğum Tarihini Giriniz: ");
            string dogumTarihiGiris = Console.ReadLine();
            DateTime dateTime = DateTime.Parse(dogumTarihiGiris);
            int yas = YasHesapla(dateTime);
            Console.WriteLine("Yaşınız: " + yas);
            Console.ReadLine();

            Console.ReadLine();
        }
        static int YasHesapla(DateTime dateTime)
        {
            int yas;
            DateTime bugun = DateTime.Now.Date;

            double toplamSaat = (bugun - dateTime).TotalHours;
            yas = Convert.ToInt32(Math.Floor(toplamSaat)) / (365 * 24 + 6);
            return yas;
        }
    }
}
