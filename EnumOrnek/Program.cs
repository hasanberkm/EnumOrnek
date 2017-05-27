using System;

namespace EnumOrnek
{
    class Program
    {
        enum birler { sifir, bir, iki, uc, dort, bes, alti, yedi, sekiz, dokuz }
        enum onlar { on, yirmi, otuz, kirk, elli, altmis, yetmis, seksen, doksan }
        enum yuzler { yuz, ikiyuz, ucyuz, dortyuz, besyuz, altiyuz, yediyuz, sekizyuz, dokuzyuz }

        static void Main(string[] args)
        {
            int a, b, c; //Basamak Değerlerini Tutar
            char cevap = 'h'; //Cevabı Tutar Ee/Hh
            string gSayi; //Girilen Sayıyı Tutar

            while (cevap != 'e' || cevap != 'E') 
            {
                Console.WriteLine("Bir Sayi Girin");
                gSayi = Console.ReadLine();

                c = Convert.ToInt32(gSayi.Substring(0, 1)); //girilen sayının ilk rakamı alındı. 
                b = Convert.ToInt32(gSayi.Substring(1, 1)); //girilen sayının ikinci rakamı alındı.
                a = Convert.ToInt32(gSayi.Substring(2, 1)); //girilen sayının üçüncü rakamı alındı.

                birler bir = (birler)a; //birler enum'undan a'ncı eleman çağırıldı.
                onlar on = (onlar)b - 1;    //onlar  enum'undan b-1'inci eleman çağırıldı.
                yuzler yuz = (yuzler)c - 1; //yuzler enum'undan c-1'inci eleman çağırıldı.

                if (c == 0)
                    Console.WriteLine("Yüzler Basamağı Geçersiz!");

                else if (b == 0)               
                    Console.WriteLine(yuz + " " + bir); //elemanlar ekrana yazdırıldı.
                            
                else if(a == 0)               
                    Console.WriteLine(yuz + " " + on);
                
                else              
                    Console.WriteLine(yuz + " " + on + " " + bir); //elemanlar ekrana yazdırıldı.
                
                Console.WriteLine("Devam etmek ister misiniz? e/h");
                cevap = Convert.ToChar(Console.ReadLine());
            }     
        }
    }
}