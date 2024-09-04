namespace soru8;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("lütfen bir sayi giriniz.");
        string sayi=Console.ReadLine();
        double sayi1=Convert.ToDouble(sayi);
        System.Console.WriteLine(Math.Log10(sayi1));

    }
}
