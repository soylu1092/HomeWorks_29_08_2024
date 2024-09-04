namespace soru2;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("lütfen 1. sayiyi giriniz.");
        string sayi=Console.ReadLine();
        int sayi1=Convert.ToInt32(sayi);
        System.Console.WriteLine("lütfen 2. sayiyi giriniz.");
        string sayi2=Console.ReadLine();
        int sayi3=Convert.ToInt32(sayi2);
        if (sayi1>sayi3)
        {
            System.Console.WriteLine(sayi1);
        }
        else if (sayi3 > sayi1)
        {
            System.Console.WriteLine(sayi3);
        }else
        {
            System.Console.WriteLine("iki sayida eşittir.");
        }
    }
}
