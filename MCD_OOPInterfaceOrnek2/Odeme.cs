using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_OOPInterfaceOrnek2
{
    public class Odeme 
    {
        private decimal _odenecekTutar;

        public decimal OdenecekTutar
        {
            get { return _odenecekTutar; }
            set { _odenecekTutar = value; }
        }

        public void OdemeTutariniKullanicidanAl()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Ödenecek Tutari Giriniz: ");
            this._odenecekTutar = Convert.ToDecimal(Console.ReadLine());
        }
            
        
    }
}
