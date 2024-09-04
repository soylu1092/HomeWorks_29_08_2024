namespace soru2;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("lütfen 1. uzunlugu giriniz.");
        string sayi1=Console.ReadLine();
        double sayi2=Convert.ToDouble(sayi1);
        System.Console.WriteLine("lütfen 2. uzunlugu giriniz.");
        string sayi3=Console.ReadLine();
        double sayi4=Convert.ToDouble(sayi3);
        System.Console.WriteLine("lütfen 3. uzunlugu giriniz.");
        string sayi5=Console.ReadLine();
        double sayi6=Convert.ToDouble(sayi5);
        double heron=sayi2+sayi4+sayi6;
        double heronS=heron/2;
        double sA=heronS-sayi2;
        double sB=heronS-sayi4;
        double sC=heronS-sayi6;
        double alan=heronS*sA*sB*sC;
        System.Console.WriteLine(Math.Sqrt(alan));
        
    }
}
