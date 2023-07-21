using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCompetition2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // *** Bilgi yarısması ***

            //toplam 3 soru
            //her soruda 3 sık
            //diger soruya gecebilmel için her soruya dogru cevap vermek gerekiyor
            //yanlıs cevap verilince yarısma sona erer
            //3 sorunun tamamı dogru cevaplanır ise oyun biter

            char soru1;
            char soru2;
            char soru3;


            Console.WriteLine("Lütfen 1. soruyu yanıtlayın");
            soru1 = Convert.ToChar(Console.ReadLine());

            if (soru1 == 'a')
            {
                Console.WriteLine("Lütfen 2. soruyu yanıtlayın");
                soru2 = Convert.ToChar(Console.ReadLine());

                if (soru2 == 'b')
                {
                    Console.WriteLine("Lütfen 3. soruyu yanıtlayın");
                    soru3 = Convert.ToChar(Console.ReadLine());

                    if (soru3 == 'c')
                    {
                        Console.WriteLine("Tebrikler, yarısmayı kazandınız");
                    }
                    else
                    {
                        Console.WriteLine("Yarısmayı kaybettiniz");
                    }
                }
                else
                {
                    Console.WriteLine("Yarısmayı kaybettiniz");
                }

            }
            else
            {
                Console.WriteLine("Yarısmayı kaybettiniz");
            }

            Console.Read();
        }
    }
}
