using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizimMahalleKod.IlkDers
{
    public class Action
    {
        Tanimlamalar tanimlamalar = new Tanimlamalar();

        /*
         * void Metotlar geriye değer döndürülmeyen metot çeşididir.
         * Eğerki değişken tipi vererek bir metot döndürüyorsak bu geriye değer döndüren metotlardır.
         */
        public void ActionMetot()
        {

            Console.Write("Lütfen Adınızı Giriniz : ");
            tanimlamalar.Name = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Lütfen soyadınızı giriniz : ");
            tanimlamalar.Surname = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Lütfen mesleğiniz giriniz : ");
            tanimlamalar.Job=Console.ReadLine();
            Console.WriteLine();
            Console.Write("Lütfen yaşadığınız ili giriniz : ");
            tanimlamalar.City = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Lütfen yaşadığınız ilçeyi giriniz : ");
            tanimlamalar.District = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Lütfen yaşınızı giriniz : ");
            tanimlamalar.Age = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Clear();
            Console.WriteLine("Bize vermiş olduğunuz bilgiler aşağıdaki gibidir.");
            Console.WriteLine("Adınız : " + tanimlamalar.Name);
            Console.WriteLine("Soyadınız : " + tanimlamalar.Surname);
            Console.WriteLine("Mesleğiniz : " + tanimlamalar.Job);
            Console.WriteLine("Yaşadığınız Şehir : " + tanimlamalar.City);
            Console.WriteLine("Yaşadığınız İlçe : " + tanimlamalar.District);
            Console.WriteLine("Yaşınız : " + tanimlamalar.Age);
        }
    }
}
