namespace soru1;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("lütfen bir sayi giriniz.");
        string sayi1=Console.ReadLine();
        int sayi2=Convert.ToInt32(sayi1);
        int kdv=sayi2/100*20;
        int kdv2=sayi2/100*8;
        int kdvTutar1=sayi2+kdv;
        int kdvTutar2=sayi2+kdv2;
        if(sayi2<=1000){
            System.Console.WriteLine($"Kdv tutari:{kdv}");
            System.Console.WriteLine($"Kdvli toplam fiyat:{kdvTutar1}");
        }else{
            System.Console.WriteLine($"Kdv tutari:{kdv2}");
            System.Console.WriteLine($"Kdvli toplam fiyat:{kdvTutar2}");
        }
    }
}
