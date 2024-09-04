namespace soru1;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Lütfen haftanin bir gün sayisini giriniz(1-7)");
        string sayi1=Console.ReadLine();
        int sayi2=Convert.ToInt32(sayi1);
        switch(sayi2){
            case 1:
            System.Console.WriteLine("Pazartesi");
            break;
            case 2:
            System.Console.WriteLine("Sali");
            break;
            case 3:
            System.Console.WriteLine("Carsamba");
            break;
            case 4:
            System.Console.WriteLine("Persembe");
            break;
            case 5:
            System.Console.WriteLine("Cuma");
            break;
            case 6:
            System.Console.WriteLine("Cumartesi");
            break;
            case 7:
            System.Console.WriteLine("Pazar");
            break;
        }
    }
}
