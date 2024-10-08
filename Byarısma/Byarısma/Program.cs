using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Byarısma
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int dogru = 0;//Dogru ve yanlış sayisini tutacak olan değişkenleri atıyoruz
            int yanlış = 0;

            Console.WriteLine("Yarısmaya hoş geldiniz");

            Console.WriteLine("İlk soru : Tüküren hayvan hangisidir? a)Lama   b)Deve");
            string s1 = Console.ReadLine();

            Console.Clear();//Konsoldan daha temiz çıktı almak için Console.Clear() kullandım

            if (s1 == "a")
            {
                Console.WriteLine("Tebrikler dogru cevap");
                dogru++;//Burada şartımız dogruysa dogru değişkenini artırıyoruz
            }
            else
            {
                Console.WriteLine("Yanlış cevap");
                yanlış++;//yanlışsa yanlış değişkenini 
            }


            Console.WriteLine("ikinci soru : Dünaya en yakın gezegen hangisidir? a)Venüs b)Mars");
            string s2 = Console.ReadLine();

            Console.Clear();


            if (s2 == "a")//ikinci soru içinde aynısını yapıyoruz
            {
                Console.WriteLine("tebrikler doğru cevap\n");
                dogru++;
            }
            else
            {
                Console.WriteLine("Yanlış cevap\n");
                yanlış++;
            } 


            if (s1 == "b" && s2 == "b")//Burda eğer ilk iki soru yanlışsa programı sonlandırıyoruz
            {
                Console.WriteLine("maalesef elendiniz ");
                Console.ReadLine();
            }

            else//ilk iki soru yanlış değilse else 'in içine bir if daha açarak 3.soruyu alalım
            {

                Console.WriteLine("Üçüncü soru :5 * 2 + 8 / 2 - 2 Cevabı nedir?  a)7    b)12");
                string s3 = Console.ReadLine();

                Console.Clear();

                if (s3 == "b")
                {
                    Console.WriteLine("Tebrikler doğru cevap");
                    dogru++;
                }
                else
                {
                    Console.WriteLine("Yanlış cevap");
                    yanlış++;
                }
            }



            Console.WriteLine("Dogru sayisi : " + dogru); //Yanlış ve dogru sayisini ekrana bastırıyoruz
            Console.WriteLine("Yanlış sayisi : " + yanlış);


            if (dogru == 2 || dogru == 3)//Ne kazandığımızı ekrana yazdırdığımız yer
            {
                Console.WriteLine("Tebrikler bir milyon tl kazandınız");
            }
            else
            {
                Console.WriteLine("maalesef başarılı olamadınız");
            }




            Console.ReadLine();

        }
    }
}
