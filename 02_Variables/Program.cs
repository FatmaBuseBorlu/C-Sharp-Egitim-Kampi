﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler
            //double number;
            //number = 4.85;
            //Console.WriteLine(number);
            //Console.Read();

            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("----- Elma Birim Fiyatı: " + applePrice + "TL");
            //Console.WriteLine("----- Portakal Birim Fiyatı: " + orangePrice + "TL");
            //Console.WriteLine("----- Çilek Birim Fiyatı: " + strawberryPrice + "TL");
            //Console.WriteLine("----- Patates Birim Fiyatı: " + potatoPrice + "TL");
            //Console.WriteLine("----- Domates Birim Fiyatı: " + tomatoPrice + "TL");
            //Console.WriteLine();

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice, orangeTotalPrice, strawberryTotalPrice, potatoTotalPrice, tomatoTotalPrice;
            //double totalPrice;

            //appleTotalPrice = applePrice * appleGram;
            //Console.WriteLine("Alınan Ürün: Elma - " + "Birim Fiyatı: " + applePrice + " - Gramaj: " + appleGram + " - Toplam Ödenecek Tutar: " + appleTotalPrice + " TL");

            //orangeTotalPrice = orangePrice * orangeGram;
            //Console.WriteLine("Alınan Ürün: Portakal - " + "Birim Fiyatı: " + orangePrice + " - Gramaj: " + orangeGram + " - Toplam Ödenecek Tutar: " + orangeTotalPrice + " TL");

            //strawberryTotalPrice = strawberryPrice * strawberryGram;
            //Console.WriteLine("Alınan Ürün: Çilek - " + "Birim Fiyatı: " + strawberryPrice + " - Gramaj: " + strawberryGram + " - Toplam Ödenecek Tutar: " + strawberryTotalPrice + " TL");

            //potatoTotalPrice = potatoPrice * potatoGram;
            //Console.WriteLine("Alınan Ürün: Patates - " + "Birim Fiyatı: " + potatoPrice + " - Gramaj: " + potatoGram + " - Toplam Ödenecek Tutar: " + potatoTotalPrice + " TL");

            //tomatoTotalPrice = tomatoPrice * tomatoGram;
            //Console.WriteLine("Alınan Ürün: Domates - " + "Birim Fiyatı: " + tomatoPrice + " - Gramaj: " + tomatoGram + " - Toplam Ödenecek Tutar: " + tomatoTotalPrice + " TL");

            //Console.WriteLine();
            //Console.WriteLine();

            //totalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;
            //Console.WriteLine("Toplam Ödenecek Miktar: " + totalPrice + " TL");

            //Console.Read();
            #endregion

            #region Char Değişkenler

            //char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);

            //Console.Read();
            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler

            //Console.WriteLine("***** CSharp Hava Yolları Yolcu Bilgisi *****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDisrict, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("Yolcu İlçe Bilgisi: ");
            //passengerDisrict = Console.ReadLine();

            //Console.Write("Yolcu İl Bilgisi: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcu Yaş: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu Kimlik Numarası: ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine("Yolcu TC Kimlik No: " + passengerIdentityNumber + " - Yolcu Ad-Soyad: " + passengerName + "" + passengerSurname + " - Yolcu İl/İlçe: " + passengerCity + "/" + passengerDisrict + " - Yolcu Yaş: " + passengerAge);

            //Console.Read();

            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //int shoesPrice, computerPrice, chairPrice, tvPrice;

            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye miktarını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız TV miktarını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice + chairCount * chairPrice + tvCount * tvPrice;
            //Console.WriteLine("Toplam Ödencek Miktar: " + totalPrice);

            //Console.Read();
            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1.Sınav notunu giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2.Sınav notunu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3.Sınav notunu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3)/3;
            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız: " + result);

            //Console.Read();
            #endregion

            #region Klavyeden Girilen Karakter Girişi

            //char gender;
            //Console.Write("Lütfen cinsiyet seçiniz: ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz cinsiyet: " + gender);


            //Console.Read();
            #endregion


        }
    }
}
