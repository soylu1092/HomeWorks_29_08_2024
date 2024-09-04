namespace soru9;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("lütfen 1. sayiyi giriniz.");
        string sayi=Console.ReadLine();
        System.Console.WriteLine("lütfen 2. sayiyi giriniz.");
        string sayi1=Console.ReadLine();
        int sayi2=Convert.ToInt32(sayi);
        int sayi3=Convert.ToInt32(sayi1);
        System.Console.WriteLine(Math.Min(sayi2,sayi3));
    }
}
