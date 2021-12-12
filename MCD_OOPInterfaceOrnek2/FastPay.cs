using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MCD_OOPInterfaceOrnek2
{
    public class FastPay:Odeme,IOdeme
    {
        public string Eposta { get; set; }
        public string Sifre { get; set; }

        public void OdemeSekliAyariYap()
        {
            Console.WriteLine("FastPay --> 3");
        }

        public void OdemeYap()
        {
            Console.WriteLine("Eposta adresi giriniz: ");
            Eposta = Console.ReadLine();
            Console.WriteLine("Şifre giriniz: ");
            Sifre = Console.ReadLine();

           

            Random rnd1 = new Random();
            int bekleme1 = rnd1.Next(3, 5);
            Console.WriteLine(bekleme1);
            for (int i = 0; i < bekleme1; i++)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(i + "...");
                Thread.Sleep(bekleme1);
            }
            Console.WriteLine("Ödeme alındı.... iyi günler...");
        }
    }
}
