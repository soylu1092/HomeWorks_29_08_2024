namespace soru8;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Lütfen bir sayi giriniz.");
        string sayi1=Console.ReadLine();
        int sayi2=Convert.ToInt32(sayi1);
        switch(sayi2){
            case 0:
            System.Console.WriteLine("Nokta");
            break;
            case 1:
            System.Console.WriteLine("Cizgi");
            break;
            case 2:
            System.Console.WriteLine("Açı");
            break;
            case 3:
            System.Console.WriteLine("Ücgen");
            break;
            case 4:
            System.Console.WriteLine("Kare");
            break;
            case 5:
            System.Console.WriteLine("Besgen");
            break;
            case 6:
            System.Console.WriteLine("Altigen");
            break;
        }
    }
}
