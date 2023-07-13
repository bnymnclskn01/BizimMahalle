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
long a = 31899871245;
Console.ReadKey();