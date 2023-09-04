using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizimMahalleKod.IlkDers
{
    /*
     * Class = Sınıf demektir.
     * Programlama dilinde ortam oluşturmak anlamına gelir.
     * Tanimlamalar Ortamı oluşturdum
     * Bu ortamda ben değişkenlerimi tanımlayacağım.
     * Çünkü spagetti kod mantığından kurtulmamaız.
     * Bütün kodu dağıtarak işlem yapmaya başlıcaz.
     * internal class = tamamiyle yapı sadece class Tanimlamlar {}
     * public class = istediğimiz her yere kodu taşıyabiliriz.
     * bu class içerisinde public olursa istediğimiz ortama buradaki yazdıklarımızı taşıyabiliriz.
     */
    public class Tanimlamalar
    {
        /*
         * Property = Özellik yani değişken özelliği tanımlıyoruz.
         */

        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Job { get; set; }
        public string? City { get; set; }
        public string? District { get; set; }
        public int Age { get; set; }
    }
}
