using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YazdırmaKomutları
            //Console.Write("Merhaba Dünya");
            //Console.WriteLine("Selam");

            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri *****");

            //Console.Read();
            #endregion
            #region String Değişkenler
            //string name;
            //name = "Buse";
            //Console.Write(name);
            //Console.Read();

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Ali";
            //customerSurname = "Çınar";
            //customerPhone = "+90 500 658 40 38";
            //customerEmail = "deneme@gmail.com";
            //district = "Üsküdar";
            //city = "İstanbul";

            //Console.WriteLine("**** Rezervasyon Kartı ****");
            //Console.WriteLine();
            //Console.WriteLine("----------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("----------------------------");
            //Console.WriteLine();

            //customerName = "Ayşegül";
            //customerSurname = "Cihan";
            //customerPhone = "+90 543 223 29 84";
            //customerEmail = "ayşecihann@gmail.com";
            //district = "Arifiye";
            //city = "Sakarya";

            //Console.WriteLine("----------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("----------------------------");

            //Console.Read();

            #endregion
            #region Int Değişkenler

            //int number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int fricePrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 50;

            Console.WriteLine("***** Restoran Menü Fiyatı *****");
            Console.WriteLine();
            Console.WriteLine("----Hamburger Fiyatı: " + hamburgerPrice + "TL");
            Console.WriteLine("----Pizza Fiyatı: " + pizzaPrice + "TL");
            Console.WriteLine("----Kola Fiyatı: " + cokePrice + "TL");
            Console.WriteLine("----Su Fiyatı: " + waterPrice + "TL");
            Console.WriteLine("----Limonata Fiyatı: " + lemonadePrice + "TL");
            Console.WriteLine("----Kızartma Fiyatı: " + fricePrice + "TL");
            Console.WriteLine();


            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice = 0;
            int totalCokePrice = 0;
            int totalWaterPrice = 0;
            int totalFriesPrice = 0;
            int totalPizzaPrice = 0;
            int totalLemonadePrice = 0;
            int totalPrice;


            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;

            Console.WriteLine("***** Hesap Miktarı *****");

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            Console.WriteLine("Hamburger Tutarı: " + totalHamburgerPrice + "TL");

            totalCokePrice = cokeCount * cokePrice;
            Console.WriteLine("Kola Tutarı: " + totalCokePrice + "TL");

            totalWaterPrice = waterCount * waterPrice;
            Console.WriteLine("Su Tutarı: " + totalWaterPrice + "TL");

            totalFriesPrice = friesCount * fricePrice;
            Console.WriteLine("Kızartma Fiyatı: " + totalFriesPrice + "TL");

            totalPizzaPrice = pizzaCount * pizzaPrice;
            Console.WriteLine("Pizza Fiyatı: " + totalPizzaPrice + "TL");

            totalLemonadePrice = lemonadeCount * lemonadePrice;
            Console.WriteLine("Limonata Fiyatı: " + totalLemonadePrice + "TL");

            Console.WriteLine();

            totalPrice = (totalHamburgerPrice + totalCokePrice + totalWaterPrice + totalFriesPrice + totalPizzaPrice + totalLemonadePrice);
            Console.WriteLine("Toplam Ödenecek Tutar: " + totalPrice + "TL");
            
            Console.Read();
            #endregion

        }
    }
}
