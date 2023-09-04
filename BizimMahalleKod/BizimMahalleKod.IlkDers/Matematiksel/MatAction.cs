using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizimMahalleKod.IlkDers.Matematiksel
{
    public class MatAction
    {
        Degiskenler degiskenler=new Degiskenler();
        public double Toplama()
        {
            Console.WriteLine("Sayı 1 Giriniz : ");
            degiskenler.sayi1=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Sayi 2 Giriniz : ");
            degiskenler.sayi2 = Convert.ToDouble(Console.ReadLine());
            degiskenler.toplam = degiskenler.sayi1 + degiskenler.sayi2;
            Console.WriteLine(degiskenler.toplam);
            return degiskenler.toplam;
        }

        public double Cikarma()
        {
            Console.WriteLine("Sayı 1 Giriniz : ");
            degiskenler.sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Sayi 2 Giriniz : ");
            degiskenler.sayi2 = Convert.ToDouble(Console.ReadLine());
            degiskenler.toplam = degiskenler.sayi1 - degiskenler.sayi2;
            Console.WriteLine(degiskenler.toplam);
            return degiskenler.toplam;
        }
        public double Carpma()
        {
            Console.WriteLine("Sayı 1 Giriniz : ");
            degiskenler.sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Sayi 2 Giriniz : ");
            degiskenler.sayi2 = Convert.ToDouble(Console.ReadLine());
            degiskenler.toplam = degiskenler.sayi1 * degiskenler.sayi2;
            Console.WriteLine(degiskenler.toplam);
            return degiskenler.toplam;
        }

        public double Bolme()
        {
            Console.WriteLine("Sayı 1 Giriniz : ");
            degiskenler.sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Sayi 2 Giriniz : ");
            degiskenler.sayi2 = Convert.ToDouble(Console.ReadLine());
            degiskenler.toplam = degiskenler.sayi1 / degiskenler.sayi2;
            Console.WriteLine(degiskenler.toplam);
            return degiskenler.toplam;
        }
    }
}
