using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    class Program
    {
        static void Main(string[] args)
        {
            #region If Else
            //Console.Write("Lütfen şifreyi giriniz: ");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre Doğru");
            //}

            //else
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}
            //Console.Read();


            //string capital, country;
            //Console.Write("Başkenti Giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi Giriniz: ");
            //country = Console.ReadLine();

            //if(capital=="ankara"& country == "türkiye")
            //{
            //    Console.Write("Veriler doğrulandı");
            //}
            //else
            //{
            //    Console.Write("Veriler doğrulanmadı, hatalı bilgi");
            //}

            //Console.Read();


            //int number;
            //Console.Write("Sayiyi Giriniz: ");
            //number = int.Parse(Console.ReadLine());
            //if (number == 5)
            //{
            //    Console.WriteLine("Sayi Doğru ");
            //}

            //else
            //{
            //    Console.WriteLine("Sayi hatali ");
            //}
            //Console.Read();

            //int number, average, exam1, exam2, exam3;
            //string result = "Hata!";

            //Console.WriteLine("***** Not Ortalama Hesaplama *****");
            //Console.WriteLine();

            //Console.Write("Lütfen birinci sınav notunuzu giriniz: ");
            //exam1 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen ikinci sınav notunuzu giriniz: ");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen üçüncü sınav notunuzu giriniz: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Ortalama: " + average);

            //if (average > 0 && average <= 50)
            //{
            //    result = "Ortalamanız Vasat Seviyede";
            //}

            //if (average > 51 && average <= 70)
            //{
            //    result = "Ortalamanız Orta Seviyede";
            //}

            //if (average > 71 && average <= 85)
            //{
            //    result = "Ortalamanız Çok İyi Seviyede";
            //}

            //Console.WriteLine(result);
            //Console.Read();

            //string city;
            //Console.Write("Lütfen şehir girişi yapınız: ");
            //city = Console.ReadLine();

            //if (city == "adana" | city == "ankara"| city=="bursa" | city=="konya")
            //{
            //    Console.Write("Şehir mevcut");
            //}

            //else
            //{
            //    Console.Write("Şehir mevcut değil");
            //}
            //Console.Read();

            //Console.Write("Lütfen kullanıcını adını giriniz: ");
            //string username = Console.ReadLine();

            //if (username == "admin")
            //{
            //    Console.Write("Hoşgeldiniz!");
            //}

            //else
            //{
            //    Console.Write("Böyle bir kullanıcı kabul edilemez");
            //}
            //Console.Read();
            #endregion

            #region Mod İşlemleri
            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);
            //Console.Read();

            //int number1, number2, result;
            //Console.Write("Lütfen birinci sayıyı giriniz: ");
            //number1 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen ikincis sayıyı giriniz: ");
            //number2 = int.Parse(Console.ReadLine());

            //result = number1 % number2;
            //Console.WriteLine("1.sayinin 2.sayiya bölümünden kalan " + result);
            //Console.Read();

            //int number;
            //Console.Write("1.sayiyi giriniz: ");
            //number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.Write("Sayi çifttir. ");
            //}

            //else
            //{
            //    Console.Write("Sayi tektir. ");
            //}

            //Console.Read();
            #endregion

            #region Char Değişkenler ile Karar Yapıları
            //char team;

            //Console.Write("Lütfen bir takım sembolünü giriniz: ");
            //team = char.Parse(Console.ReadLine());

            //if(team=='b' | team == 'B')
            //{
            //    Console.Write("Girdiğiniz sembol Beşiktaş'a ait ");
            //}
            //if (team == 'g' | team == 'G')
            //{
            //    Console.Write("Girdiğiniz sembol Galatasaray'a ait ");
            //}
            //if (team == 'f' | team == 'F')
            //{
            //    Console.Write("Girdiğiniz sembol Fenerbahçe'ye ait ");
            //}
            //if (team == 't' | team == 'T')
            //{
            //    Console.Write("Girdiğiniz sembol Trabzonspor'a ait ");
            //}
            //Console.Read();
            #endregion

            #region Örnek Proje Uygulaması

            //Console.WriteLine("********** C# Eğitim Kampı Restoran **********");
            //Console.WriteLine();
            //Console.WriteLine("----------------------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3- Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("----------------------------");

            //string menuItem;
            //Console.Write("Lütfen detayını görmek istediğiniz menüyü seçin: ");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("--------------Ana Yemekler--------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Köri Soslu Tavuk");
            //    Console.WriteLine("2-Kızartma Tava");
            //    Console.WriteLine("3-Fasulye Pilav");
            //    Console.WriteLine("4-Fırında Somon");
            //    Console.WriteLine("5-Patlıcan Musakka");

            //    Console.WriteLine();
            //}

            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("--------------Çorbalar--------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mercimek Çorbası");
            //    Console.WriteLine("2-Ezogelin Çorbası");
            //    Console.WriteLine("3-Yayla Çorbası");
            //    Console.WriteLine("4-Şehriye Çorbası");
            //    Console.WriteLine("5-İşkembe Çorbası");

            //    Console.WriteLine();
            //}
            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("--------------Pizzalar--------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Akdeniz Pizza");
            //    Console.WriteLine("2-Margarita Pizza");
            //    Console.WriteLine("3-Tavuklu Pizza");
            //    Console.WriteLine("4-Karışık");

            //    Console.WriteLine();
            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("--------------İçecekler--------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Su");
            //    Console.WriteLine("2-Kola");
            //    Console.WriteLine("3-Ayran");
            //    Console.WriteLine("4-Maden Suyu");
            //    Console.WriteLine("5-Limonata");

            //    Console.WriteLine();
            //}
            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("--------------Tatlılar--------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Sütlaç");
            //    Console.WriteLine("2-Kazandibi");
            //    Console.WriteLine("3-Triliçe");
            //    Console.WriteLine("4-Kabak Tatlısı");
            //    Console.WriteLine("5-Kemalpaşa");

            //    Console.WriteLine();
            //}
            //Console.Read();
            #endregion

            #region Switch-Case

            //Console.Write("Lütfen ay girişi yapınız: ");
            //int montNumber = int.Parse(Console.ReadLine());
            //switch (montNumber)
            //{
            //    case 1: Console.Write("Ocak"); break;
            //    case 2: Console.Write("Şubat"); break;
            //    case 3: Console.Write("Mart"); break;
            //    case 4: Console.Write("Nisan"); break;
            //    case 5: Console.Write("Mayıs"); break;
            //    case 6: Console.Write("Haziran"); break;
            //    case 7: Console.Write("Temmuz"); break;
            //    case 8: Console.Write("Ağustos"); break;
            //    case 9: Console.Write("Eylül"); break;
            //    case 10: Console.Write("Ekim"); break;
            //    case 11: Console.Write("Kasım"); break;
            //    case 12: Console.Write("Aralık"); break;
            //    default: Console.Write("Hatalı Veri Girişi"); break;
            //}
            //Console.Read();
            #endregion

            #region Switch-Case Hesap Makinesi
            int number1, number2, result;
            char symbol;

            Console.Write("1.Sayıyı Giriniz: ");
            number1 = int.Parse(Console.ReadLine());

            Console.Write("2.Sayıyı Giriniz: ");
            number2 = int.Parse(Console.ReadLine());

            Console.Write("Lütfen yapmak istediğiniz işlemi giriniz: ");
            symbol = char.Parse(Console.ReadLine());

            switch (symbol)
            {
                case '+':
                    result = number1 + number2;
                    Console.WriteLine("Toplam: " + result);
                    break;

                case '-':

                    if (number1 <= number2)
                    {
                        result = number2 - number1;
                        Console.WriteLine("Fark: " + result);
                    }
                    else
                    {
                        result = number1 - number2;
                        Console.WriteLine("Fark: " + result);
                    }

                    break;

                case '*':
                    result = number1 * number2;
                    Console.WriteLine("Çarpım: " + result);
                    break;

                case '/':
                    if (number2<0 | number2>0)
                    {
                        result = number1 / number2;
                        Console.WriteLine("Bölüm: " + result);
                    }
                    else
                    {
                        Console.Write("Girdiğiniz 2.sayi 0 olamaz");
                    }
                    break;

            }
            Console.Read();
            #endregion
        }
    }
}
