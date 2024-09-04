namespace soru2;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("lütfen bulundugumuz ayi giriniz.(1-12)");
        string sayi1=Console.ReadLine();
        int sayi2=Convert.ToInt32(sayi1);
        switch(sayi2){
            case 1:
            System.Console.WriteLine("Ocak");
            break;
            case 2:
            System.Console.WriteLine("Subat");
            break;
            case 3:
            System.Console.WriteLine("Mart");
            break;
            case 4:
            System.Console.WriteLine("Nisan");
            break;
            case 5:
            System.Console.WriteLine("Mayis");
            break;
            case 6:
            System.Console.WriteLine("Haziran");
            break;
            case 7:
            System.Console.WriteLine("Temmuz");
            break;
            case 8:
            System.Console.WriteLine("Agustos");
            break;
            case 9:
            System.Console.WriteLine("Eylül");
            break;
            case 10:
            System.Console.WriteLine("Ekim");
            break;
            case 11:
            System.Console.WriteLine("Kasim");
            break;
            case 12:
            System.Console.WriteLine("Aralik");
            break;
        }
    }
}
