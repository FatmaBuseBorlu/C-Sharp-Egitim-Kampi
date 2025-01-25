using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    class Program
    {
        static void Main(string[] args)
        {

            #region For Döngüsü

            //int i;

            //for (i = 0; i <= 5; i++)
            //{
            //    Console.WriteLine("C Sharp Eğitim Kampı");
            //}
            //Console.Read();

            //int i;
            //for (i = 0; i <= 20; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.Read();

            //int i = 3;
            //for (i = 3; i <= 50; i += 3)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.Read();

            //int i;
            //Console.WriteLine("Lütfen ekrana yazmak istediğiniz adedi giriniz:");
            //int finishValue = int.Parse(Console.ReadLine());

            //for (i = 1; i <= finishValue; i++)
            //{
            //    Console.WriteLine("Yaşasın Cumhuriyet");
            //}
            //Console.Read();
            #endregion

            #region For Döngüsü İle Karar Yapıları
            //int i;
            //for (i = 0; i <= 100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.Read();

            //int i,sayı, total=0;

            //Console.Write("Lütfen bir sayı giriniz: ");
            //sayı = int.Parse(Console.ReadLine());

            //for (i = 0; i <= sayı; i++)
            //{
            //    total += i;
            //}
            //Console.Write(total);

            //Console.Read();

            //int totalValue = 0;
            //int i;

            //for (i = 1; i < 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalValue += i;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("---------");
            //Console.WriteLine(totalValue);


            //int i, count = 0;

            //for (i = 1; i < 50; i++)
            //{
            //    if (i % 7 == 0)
            //    {

            //        count++;
            //    }
            //}
            //Console.WriteLine(count);

            //int bacterium=1, i;

            //for (i = 0; i <= 24; i++)
            //{
            //    bacterium *= 2;
            //    Console.WriteLine(i + ". Saat sonunda: " + bacterium);
            //}
            #endregion

            #region While Döngüsü
            //int i = 1;

            //while (i <= 10)
            //{
            //    Console.WriteLine("Merhaba Döngüler ");
            //    i++;
            //}

            //int i = 1;
            //while (i <= 10)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            //int i=1, total=0;

            //while (i <= 10)
            //{
            //    total += i;
            //    i++;

            //}
            //Console.WriteLine(total);
            #endregion

            #region Örnek Sınav Sorusu

            //Klavyeden girilen 3 basamaklı sayının basamakları toplamını hesaplayan kodu yazınız.

            int number, ones, tens, hunders, total = 0;

            Console.Write("Lütfen iç haneli bir sayı giriniz: ");
            number = int.Parse(Console.ReadLine());


            ones = number % 10;
            tens = (number / 10) % 10;
            hunders = number / 100;

            total = (tens + ones + hunders);

            Console.WriteLine(total);
            #endregion
            Console.Read();
        }
    }
}
