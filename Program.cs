using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mehemmed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            //Dictionary<int, string> telebeler = new Dictionary<int, string>();

            //telebeler.Add(1,"Məhəmməd");
            //telebeler.Add(2,"Səmid");
            //telebeler.Add(3,"Rəşad");
            //telebeler.Add(4,"Fərid");
            //telebeler.Add(5,"Uzun Həsən");

            //string secim ="";

            //while (secim != "4")
            //{
            //    Console.WriteLine("\n1 Tələbə əlavə et");
            //    Console.WriteLine("2 Tələbəni ID ilə axtar");
            //    Console.WriteLine("3 Bütün tələbələri göstər");
            //    Console.WriteLine("4 Çıxış");
            //    Console.Write("Seçim edin:");
            //    secim = Console.ReadLine();
            //    switch (secim)
            //    {
            //        case "1":
            //            Console.Write("ID");
            //            int id = Convert.ToInt32(Console.ReadLine());
            //            Console.Write("Ad");
            //            string ad = Console.ReadLine();
            //            telebeler.Add(id, ad);
            //            Console.WriteLine("Əlavə olundu.");
            //            break;

            //        case "2":
            //            Console.Write("Axtarılan ID");
            //            int axtarilanId = Convert.ToInt32(Console.ReadLine());
            //            string tapilanAd;
            //            if (telebeler.TryGetValue(axtarilanId, out tapilanAd))
            //            {
            //                Console.WriteLine("Tələbə" + tapilanAd);
            //            }
            //            else
            //            {
            //                Console.WriteLine("Tapılmadı");
            //            }
            //            break;

            //        case "3":
            //            foreach (var item in telebeler)
            //            {
            //                Console.WriteLine("ID" + item.Key + "Ad" + item.Value);
            //            }
            //            break;

            //        case "4":
            //            Console.WriteLine("Çıxış edilir");
            //            break;
            //    }
            //}
            //Task2
            //Console.WriteLine("Fiqur seçin: 1 - Dairə, 2 - Düzbucaqlı, 3 - Üçbucaq");
            //string secim = Console.ReadLine();

            //double sahe = 0;

            //switch (secim)
            //{
            //    case "1":
            //        Console.Write("Radius daxil edin");
            //        double r = Convert.ToDouble(Console.ReadLine());
            //        sahe = Math.PI * Math.Pow(r, 2);
            //        break;

            //    case "2":
            //        Console.Write("Eni: ");
            //        double en = Convert.ToDouble(Console.ReadLine());
            //        Console.Write("Uzunluğu: ");
            //        double uzunluq = Convert.ToDouble(Console.ReadLine());
            //        sahe = en * uzunluq;
            //        break;

            //    case "3":
            //        Console.Write("1-ci tərəf: ");
            //        double a = Convert.ToDouble(Console.ReadLine());
            //        Console.Write("2-ci tərəf: ");
            //        double b = Convert.ToDouble(Console.ReadLine());
            //        Console.Write("3-cü tərəf: ");
            //        double c = Convert.ToDouble(Console.ReadLine());
            //        double p = (a + b + c) / 2;
            //        sahe = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            //        break;

            //    default:
            //        Console.WriteLine("Səhv seçim.");
            //        return;
            //}

            //Console.WriteLine("Sahə: " + Math.Round(sahe, 2));

            //Task 3
            //List<int> ededler = new List<int>();

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write("Ədəd daxil edin");
            //    int eded = Convert.ToInt32(Console.ReadLine());
            //    ededler.Add(eded);
            //}

            //int enBoyuk = ededler[0];
            //int enKicik = ededler[0];
            //int cutSay = 0;
            //int tekSay = 0;

            //foreach (int eded in ededler)
            //{
            //    if (eded > enBoyuk)
            //    {
            //        enBoyuk = eded;
            //    }

            //    if (eded < enKicik)
            //    {
            //        enKicik = eded;
            //    }

             
            //    if (eded % 2 == 0)
            //    {
            //        cutSay++;
            //    }
            //    else
            //    {
            //        tekSay++;
            //    }
            //}

            //Console.WriteLine( enBoyuk);
            //Console.WriteLine( enKicik);
            //Console.WriteLine( cutSay);
            //Console.WriteLine(tekSay);


            //Task 4
            //Random random = new Random();
            //int tesadufiEded = random.Next(0, 101);
            //int texmin;

            //do
            //{
            //    Console.Write("Təxmininizi daxil edin: ");
            //    texmin = Convert.ToInt32(Console.ReadLine());

            //    if (texmin > tesadufiEded)
            //    {
            //        Console.WriteLine("Daha kiçik ədəd cəhd edin");
            //    }
            //    else if (texmin < tesadufiEded)
            //    {
            //        Console.WriteLine("Daha böyük ədəd cəhd edin");
            //    }

            //} while (texmin != tesadufiEded);

            //Console.WriteLine("Təbriklər");
        }
    }
}
