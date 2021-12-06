using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_OOPInterfaceOrnek2
{
    class Program
    {
        static void Main(string[] args)
        {
            //1-FastPayOdeme de Eposta ve Sifre bilgisi isteyip thread ile bir random bekleme süresi belirtip ekran rengi değişsin Ödeme alındı ise bilgisi versin sonunda.
            // 2 - KapidaOdeme de Teslimatı yapan kurye ad soyad kurye biligis istensin.Hasarsızmı? diye sorsun E ise Teslimat başarılı H ise başarısız
            // 3 - KrediKartiOdeme de tüm kart bilgileri uygun bir şekilde istenip doğru olup olmadığı kontrol edilsin.thread ile bir random bekleme süresi belirtip ekran rengi değişsin Ödeme alındı ise bilgisi versin sonunda.

            KrediKartiOdeme krediKartiIleOde = new KrediKartiOdeme();
            KapidaOdeme kapidaOde = new KapidaOdeme();
            FastPay fastPayOde = new FastPay();

            List<KeyValuePair<byte, IOdeme>> odemeturulistesi = new List<KeyValuePair<byte, IOdeme>>()
            {
                new KeyValuePair<byte, IOdeme>(1,krediKartiIleOde),
                new KeyValuePair<byte, IOdeme>(2,kapidaOde),
                new KeyValuePair<byte, IOdeme>(3,fastPayOde)
            };
            foreach (var item in odemeturulistesi)
            {
                item.Value.OdemeSekliAyariYap();
            }

            int secim = Convert.ToInt32(Console.ReadLine());
            odemeturulistesi[secim - 1].Value.OdemeYap();
            //switch (secim)
            //{
            //    case 1:
            //        krediKartiIleOde.OdemeTutariniKullanicidanAl();
            //        krediKartiIleOde.OdemeYap();
            //            break;
            //    case 2:
            //        kapidaOde.OdemeTutariniKullanicidanAl();
            //        kapidaOde.OdemeYap();
            //        break;
            //    case 3:
            //        fastPayOde.OdemeTutariniKullanicidanAl();
            //        fastPayOde.OdemeYap();
            //        break;
            //    default:
            //        Console.WriteLine("Hatalı Seçim!!");
            //        break;
            //}
            Console.ReadKey();
        }
    }
}
