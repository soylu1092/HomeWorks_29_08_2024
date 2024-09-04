namespace soru9;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Lütfen bir sayi giriniz(1-5)");
        string sayi1=Console.ReadLine();
        int sayi2=Convert.ToInt32(sayi1);
        switch(sayi2){
            case 1:
            System.Console.WriteLine("Birinci");
            break;
            case 2:
            System.Console.WriteLine("İkinci");
            break;
            case 3:
            System.Console.WriteLine("Ücüncü");
            break;
            case 4:
            System.Console.WriteLine("Dördüncü");
            break;
            case 5:
            System.Console.WriteLine("Besinci");
            break;
        }
    }
}
