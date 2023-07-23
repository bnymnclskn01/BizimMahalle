/*
 * Uzun bir yorum satırı kullanmak istiyorsak bu yorum satırı stilini
 * kullanmamız gerekiyor /**/
//Eğerki tek satır yorum yazacaksak // işareti kullanarak yapabiliriz.
/*
 Önce girdilerdi.
 Değişken = () Değişkenlerin Tipleri vardır.
 Bu değişken tiplerine göre de alacakları değerler belirlenir.
 Bu girdiye Değişken Adı verilmiştir.?
 Bu değişken tipleri nelerdir nerelerde neden kullanırız?
 1 - byte : Uzunluğu 1 bytelık yer kaplar 0 ile 255 arasında değer alır.
 2 - sbyte: ''   ''    ''   '' -128 ile 127 arasında değer alır.
 3 - short  Uzunluğu 2 bytetır. -32.768 ile 32.767 sayısı arasında değer alır.
 4 - ushort ''    '' ''  0 ile 65.535 sayıları arasında değer alır.
 5 - int: Uzunluğu 4 byte'tır. -2.147.483.648 ile 2.147.483.648 arasında değer alır.
 6 - uint : '' '' 0 ile 4.294.967.295 sayıları arasında değer alır.
 7 - Long '' 8 bytetır. -10 üzeri 20 ile 10 28 arasında değer alır.
 8 - ulong 8 bytetır. 0 ile 2x 10 üzeri 20 arasında değer alır.
 byte genellikle socket programlarında daha çok kullanır. socket programları
bilgisayarın ana donanımsal yazılımlarında kullanılır. iplendirme işlemlerinde daha
sıkça kullanılır.
short : genelikle portlar için kullanılır. port dediğimiz ise çıkış kapısıdır.
port atama işlemlerinde kullanılır.
int : genellikle tanımsız bir değer aldırmak ve veya tam sayı matematiksel işlemlerinde
kullanılır.
long : matematiksel işlemlerde genellikle integer'ın değerinin yetmediği alanlarda
kullanılır.

 9 - float uzunluğu 4 byte genelikle CBYS sistemlerinde Coğrafya Bilgi Yönetim S.
 burada harita koordinatlarını girebilmek için kullanılan değişken tipidir.
 47.00012 || 00000012
 10 - double genellikle kesirli veya virgüllü matematiksel işlemlerde hesaplama için
 kullanılır.
 11 - Char adı üstünde karekter algılamak için kullanırız. genellikle seçim
aracı olarak kullanılır örnek veriyorum Kadın Erkek Kadın ise K Erkek ise E ye basınız.
 12 - string metinsel ifadeler kapsar kısıtlaması yoktur istediğiniz kadar değişkenin bytenı
genişletebilirsiniz.
 13 boolean True False yanlış veya doğru bir işlem ya doğru olacak ya yanlış.
1 yada 0
 14 Decimal Para birimi işlemlerinde kullanılır. paralar üzerinde değer ataması yapılacaksa
kesinlikle decimal kullanmalıdır.
 İşlemler yapıldıktan sonra ekranda gösterebilmemiz için bir fonksiyon vardır.
Console.Write() veya Console.WriteLine()
Console.Write() Tek satırda ekrana basar
Console.WriteLine() Satırı ekrana yazar imleci bir alt satıra atar.
Değişken tutucularımız var
Değişken Tutucularımız.
Console.ReadLine();
 */
//string metin = "Bu bir metinsel ifadedir.";
//string metin2;
//Console.Write("Bir metin giriniz. ");
//metin2=Console.ReadLine();
//Console.WriteLine();
//Console.WriteLine(metin);
//Console.Write(metin2);
//int a=0, b=0, t=0;
//Console.WriteLine("Lütfen bir sayı giriniz : ");
//a = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("lütfen ikinci sayıyı giriniz : ");
//b = Convert.ToInt32(Console.ReadLine());
//t = a + b;
//Console.WriteLine(t);
/*
 Başla
 değişkenleri oluşturalım a=0, b=0 t=0;
 Kullanıcıdan a değişkeni değer atamasını istiyoruz.
 Kullanıcıdan b değişkeni için değer atamasını istiyoruz.
 t= a+b; a ile b topla t ye eşitle
 En son olarak t yi ekrana yazdır.
 Bitir.
 */
// Değişkenlere Default(Varsayılan) ve Kullanıcdan Gelen Değerlere göre işlem alacağız.
/*Varsayılan Değişken Değerleri*/
//int a = 9, b = 10, c = 11, t = 0;
//char secim; // Kullanıcı bazlı değişken değer atama.
//Console.Write("Lütfen yapmak istediğiniz işlemi yazınız 1-Toplama(+) 2- Çıkarma (-) 3- Çarpma (*) 4- Bölme (/) : ");
//secim = Convert.ToChar(Console.ReadLine());

//if (secim == '+')
//{
//    t = a + b + c;
//    Console.WriteLine("");
//    Console.Write("Sayıların Toplamı : " + t);
//}
//else if(secim=='-')
//{
//    t = a - b - c;
//    Console.WriteLine("");
//    Console.Write("Sayıların Farkı : " + t);
//}
//else if (secim == '*')
//{
//    t = a * b * c;
//    Console.WriteLine("");
//    Console.Write("Sayıların Çarpımı : " + t);
//}
//else if (secim == '/')
//{
//    t = a / b / c;
//    Console.WriteLine("");
//    Console.Write("Sayıların Böleni : " + t);
//}
//else
//{
//    Console.Write("Yanlış işlem yaptınız");
//}
//switch (secim)
//{
//    case '+':
//        t = a + b + c;
//        Console.WriteLine("");
//        Console.Write("Sayıların Toplamı : " + t);
//        break;
//    case '-':
//        t = a - b - c;
//        Console.WriteLine("");
//        Console.Write("Sayıların Farkı : " + t);
//        break;
//    case '*':
//        t = a * b * c;
//        Console.WriteLine("");
//        Console.Write("Sayıların Çarpımı : " + t);
//        break;
//    case '/':
//        t = a / b / c;
//        Console.WriteLine("");
//        Console.Write("Sayıların Böleni : " + t);
//        break;
//    default:
//        Console.Write("Yanlış işlem yaptınız");
//        break;
//}
/*
 * Başla
 * Varsayılan değerli 5 adet değişken tanımla;
 * Daha bu 5 değişkeni topla t değişkenine ata;
 * Daha sonra çıkan sonucu ekrana yazdır. T
 */
//int a = 5, b = 6, c = 7, d = 8, e = 9, t = 0;
//t = a + b + c + d + e;
//Console.WriteLine(t);
/*
 *  Başla
 *  İki adet değişken tanımla boş değer olarak
 *  Daha Sonra bu değişkenlerden bir tanesine kullanıcadan Adını İste
 *  Daha Sonra ikinci değişkene Soyadını iste
 *  Daha Sonrada 1 inci ve 2 inci değişkenleri ekrana yazdır.
 *  Bitir
 */
//string name, surname;
//Console.WriteLine("Lütfen Adınızı Giriniz : ");
//name = Console.ReadLine(); // Konsol ekranından gelen her değer string tipinde olduğu çevirmeye ihtiyaç yoktur.
//Console.WriteLine("Lütfen Soyadınızı Giriniz : ");
//surname = Console.ReadLine();
//Console.WriteLine(name + " " + surname);

/*
 * if else kullanarak bir algoritma oluşturalım
 * Başla
 * 2 adet değişken tanımlayınız varsayılan değerli
 * Koşula sokacağımız değişken kullanıcıdan gelsin
 * Eğer değer kullanıcının seçtiği gibiyse
 * ekrana mesaj yazsın
 * eğer değilse
 * bilgilendirme mesajı yazsın
 * Bitir.
 */

//string car = "5.20D";
//string brand = "BMW";
//char secim;
//Console.WriteLine(car + " Bu markalı araç Mercedes-Benz firmasına aitse 1'e basınız değilse 2'ye basınız");
//secim = Char.Parse(s: Console.ReadLine());
//if (secim == 1)
//{
//    Console.WriteLine("Seçim yaptığınız arabanın modelinin markası " + brand + " firmasına aittir.");
//}
//else
//{
//    Console.WriteLine("Evet Mercedes-Benz firmasına ait değildir. Model " + brand + " Firmasına aittir.");
//}

/*
 * Switch Case Kullanarak Algoritma Oluşturacağız
 * değişken tanımla ve kullanıcıdan değer iste
 * switch case ile gelen değere karşılık veren sonucu ekrana yazdır.
 * bitir.
 */
//string writeDay;
//Console.WriteLine("En çok hangi günü seversiniz.");
//writeDay = Console.ReadLine();
//switch (writeDay)
//{
//	case "Pazartesi":
//		Console.WriteLine("Pazartesi gününü sevdiğini zannetmiyorum");
//		break;
//	case "Salı":
//		Console.WriteLine("Salı Sallanır");
//		break;
//	case "Çarşamba":
//		Console.WriteLine("Çarşamba Çarşafa Dolanır");
//		break;
//	case "Perşembe":
//		Console.WriteLine("Perşembe Perşianlık");
//		break;
//	case "Cuma":
//		Console.WriteLine("Hayırlı evlat afferin mübarek günü seviyorsun");
//		break;
//	case "Cumartesi":
//		break;
//	case "Pazar":
//		break;
//	default:
//		Console.WriteLine("7 gün içinde gün tutturamadınya ....");
//		break;
//}

// string char int
// double float deciaml değişkenlerini kullanacağız.
// Gömülü Fonksiyonlar

/*
 * DİKDÖRTGEL ALAN ve Cevre HESAPLAMA
 * başla
 * ilk olarak kısa kenarı kullanıcıdan isticez
 * ikinci olarak uzun kenarı kullanıcıdan isticez.
 * daha sonra alan değişkenimize kısa kenar * uzun kenar
 * cevre 2* kısa+uzunkenar
 * alanın sonucunu ekrana basıcaz.
 * cevrenın sonucunu ekrana basıcaz.
 * bitir.
 */
//double kisaKenar, uzunKenar, alan, cevre;
//Console.WriteLine("Lütfen Kısa Kenarı Giriniz.");
//kisaKenar = double.Parse(Console.ReadLine());
//Console.WriteLine("Lütfen Uzun Kenarı Giriniz.");
//uzunKenar = double.Parse(Console.ReadLine());
//alan = kisaKenar * uzunKenar;
//cevre = 2 * (kisaKenar + uzunKenar);
//Console.WriteLine("Dikdörtgenin Alanı : "+ Math.Round(alan, 2));
//Console.WriteLine("Dikdörtgenin Çevresi : " + Math.Round(cevre, 2));

/*
 * Dairenin Alanı ve Çevresini Hesaplama
 * Başla
 * cevre değişkenini alan değişkenini r değişkenini oluştur.
 * Yarı çapı kullanıcıdan isticez (r)
 * cevre = 2*Math.PI*r;
 * alan Math.PI*r*r;
 * alan ve çevreyi ekrana yazıcaz
 * bitir.
 */
//double cevre, alan, r;
//Console.WriteLine("Yarı çapı giriniz : ");
//r = double.Parse(Console.ReadLine());

//cevre = 2 * Math.PI * r;
//alan = Math.PI * r * r;

//Console.WriteLine("Dairenin Çevresi : " + Math.Round(cevre, 2));
//Console.WriteLine("Dairenin Alanı  : " + Math.Round(alan, 2));

/*
 * Bir ürüne %20 KDV eklenecek
 * başla
 * ürün fiyat değişkeni oluşturalacak double tipinde
 * double tipinde kdv değişkeni oluşturulup varsayılan değerine 20 atanacak
 * daha sonrada double toplam değişkeni oluşturulup
 * toplam=(urunFiyat*kdv)+urunFiyat;
 * Toplam değişkenini ekrana basacaksınız
 * Bitir.
 */
/*10 dakikanız var bekliyorum kolay gelsin*/
//double fiyat, toplam, kdv=20;
//Console.WriteLine("Lütfen Ürününüzün fiyatını giriniz : ");
//fiyat = double.Parse(Console.ReadLine());
//toplam = ((fiyat * kdv) / 100) + fiyat;
//Console.WriteLine("Ürününüzün kdvli satış fiyatı : " + Math.Round(toplam, 2));

/*
 * Bir ürüne önce kdv eklenecek daha sonra indirim yapılacak;
 * toplamda 4 adet double tipinde değişken tanımlanacak
 * kdv değişkeni varsayılanı 20 olacak.
 * Önce Fiyat değişkenine veriyi kullanıcıdan isticez
 * daha sonra kdvsini hesaplayıp ekrana basıcaz.
 * toplam = ((fiyat*kdv)/100)+fiyat;
 * toplamı ekrana bas
 * Daha sonra indirim değişkenine kullanıcdan değer atayacağız.
 * Kullanıcıdan indirim değeri iste
 * toplam=((toplam*indirim)/100)-toplam;
 * Ekrana Ürünün indirimli hali diyip toplamı tekrar ekrana basacaksınız.
 */
//double indirim, fiyat, kdv, toplam;
//kdv = 20;
//Console.WriteLine("Fiyat giriniz : ");
//fiyat = double.Parse(Console.ReadLine());
//toplam = ((fiyat * kdv) / 100) + fiyat;
//Console.WriteLine("Ürünün kdv dahil fiyatı : " + Math.Round(toplam, 2));
//Console.WriteLine("İndirim miktarı girin : ");
//indirim = double.Parse(Console.ReadLine());
//toplam = (toplam - (toplam * indirim) / 100);
//Console.WriteLine("Ürünün indirimli fiyatı : " + Math.Round(toplam, 2));

/*
 * Toplamda 5 adet double değişkenini kullanarak 5 adet
 * hem algoritması hemde kod örneğiyle birlikte pazartesi gününe kadar hazır getirin.
 */

//Ekrana Yazdırma Komudumuz Var
//Ekrana 2 türlü yazdırabiliriz
//Console.Write("Bu bir test mesajıdır");
//Console.Write("Bu bir ikinci test mesajıdır.\n");
//Direk Alta indirmeyle ekrana yazdırma
//Console.WriteLine("Bu bir test mesajıdır.");
//Console.WriteLine("Bu bir ikinci test mesajıdır.");


// varsayılan değerli değişkenler birde program esnasında
//string adiniz = "Buraya isim giriniz.";
//string soyadiniz;
//int yas;
// değer değiştiren değişkenler
//soyadiniz = "Buraya soyadınızı giriniz.";
// Kullanıcıdan değer gelenler
// Konsol ekranında ne değer gelirse gelsin
// hepsi string metin tipindedir.
// eğerki değişkenim string değilse hemen convert işlemi
// dönüştürme değişken tipine dönüştürme.
// Okuma Satırı Gelecek Metini okur.
//Console.WriteLine("Lütfen adınızı giriniz :");
//adiniz = Console.ReadLine();
//Console.WriteLine("Lütfen soyadınızı giriniz : ");
//soyadiniz=Console.ReadLine();
//Console.WriteLine("Lütfen yaşınızı giriniz : ");
//yas = int.Parse(Console.ReadLine());
// Ayrıştırmak Okuma satırını integer tipinde ayrıştırdı.
// daha sonrada yas değişkenine atadı.
//Console.Clear();
//Console.WriteLine("Adınız : " + adiniz + " Soyadınız : " + soyadiniz + " Yaşınız : " + yas);
/*
 * Algoritma
 * Önce Girdiler Sonra Çıktılar
 * Başla
 * urunFiyat double, kdv int, indirim int
 * Kullanıcıdan urunFiyat değerini iste
 * Kullanıcıdan kdv değeri iste
 * daha sonrada urunFiyat=((urunFiyat*KDV)/100)+urunFiyat
 * urunFiyatın kdvli tarafına ekrana yazdır.
 * Kullanıcıdan indirimi iste
 * urunFiyat=((urunFiyat*indirim)/100)-urunFiyat;
 * En son olarak ürünün en son fiyatını ekrana yazdır.
 * Bitir.
 */
// eğerki int kdv, indirim virgül burada devamlılık arzeder.
// ; koyarsak orada işlemin bittiğini kabul eder program.

//double urunFiyat; int kdv, indirim;
//Console.WriteLine("Ürününüzün fiyatını giriniz : ");
//urunFiyat = double.Parse(Console.ReadLine());
//Console.WriteLine("Ürününüzün kdv tutarını giriniz :");
//kdv=int.Parse(Console.ReadLine());
// 100*1.20=120;
// 100*20/100=20;
// Önce Parentez içleri sonra çarpma sonra bölme sonra toplma çıkarma
//urunFiyat = ((urunFiyat*kdv)/100)+urunFiyat;
//Console.WriteLine("Ürününüzün KDV'li tutarı : " + urunFiyat+" TL");
//Console.WriteLine("Lütfen ürününüze indirim yüzdesini giriniz : ");
//indirim= int.Parse(Console.ReadLine());
//urunFiyat = urunFiyat - ((urunFiyat * indirim) / 100);
//Console.WriteLine("Ürününüzün İndirim'li tutarı : " + urunFiyat + " TL");
Console.ReadKey();