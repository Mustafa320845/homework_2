using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mustafa_karacik
{
    internal class Program
    {
        class BankaHesabi
        {
            private int bakiye;

            public int Bakiye
            {
                get { return bakiye; }
                set { bakiye = value; }
            }

            public void ParaCek(int miktar)
            {
                if (miktar > bakiye)
                {
                    Console.WriteLine("Yetersiz bakiye.İşlem gerçekleştirilemedi.");
                }
                else
                {
                    bakiye = miktar;
                    Console.WriteLine($"{miktar} TL çekildi. Yeni bakiye: {bakiye} TL");
                }
            }
        }

        class Program1
        {
            static void Main(string[] args)
            {
                BankaHesabi hesap = new BankaHesabi();
                hesap.Bakiye = 1000;

                Console.Write("Çekilecek miktarı girin: ");
                int miktar = Convert.ToInt32(Console.ReadLine());

                hesap.ParaCek(miktar);

                Console.ReadLine();
            }
        }
    }
}
