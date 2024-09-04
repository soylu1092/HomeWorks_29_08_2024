namespace soru7;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("lütfen bir sayi giriniz(1-5)");
        string sayi1=Console.ReadLine();
        int sayi2=Convert.ToInt32(sayi1);
        switch(sayi2){
            case 1:
            System.Console.WriteLine("1Krs");
            break;
            case 2:
            System.Console.WriteLine("5Krs");
            break;
            case 3:
            System.Console.WriteLine("10Krs");
            break;
            case 4:
            System.Console.WriteLine("25Krs");
            break;
            case 5:
            System.Console.WriteLine("50Krs");
            break;
        }
    }
}
