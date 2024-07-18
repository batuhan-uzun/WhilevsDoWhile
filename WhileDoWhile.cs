Console.WriteLine("Lütfen bir limit değeri belirleyiniz");
int limit = Convert.ToInt32(Console.ReadLine());
int sayac = 1;

Console.WriteLine("\nWhile Döngüsü Çıktısı\n");
while (sayac <= limit)
{
    Console.WriteLine("Ben bir Patika'lıyım");
    sayac++;
}

sayac = 0;

Console.WriteLine("\nDo While Döngüsü Çıktısı\n");
do
{
    Console.WriteLine("Ben bir Patika'lıyım");
    sayac++;
} while (sayac <= limit);

// while döngüsünde koşul sağlandığı sürece scopetaki işlemler gerçekleşir, do-while döngüsünde ise ilk önce scopetaki kod bloğunu 1 kere gerçekleştirir daha sonrasında while döngüsü gibi koşulun devam edip etmediğine bakarak işlemlerini yapar. Bu ödevi kontrol edecek arkadaşlara yardımcı olabilmesi açısından do-while döngüsünü "yap sonra bak" (do/yap) olarak aklınızda tutabilirsiniz.