namespace soru5;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Lütfen bir sayi giriniz.");
        string sayi1=Console.ReadLine();
        int sayi2=Convert.ToInt32(sayi1);
        switch(sayi2){
            case 1:
            System.Console.WriteLine("İlkbahar");
            break;
            case 2:
            System.Console.WriteLine("Yaz");
            break;
            case 3:
            System.Console.WriteLine("Sonbahar");
            break;
            case 4:
            System.Console.WriteLine("Kiş");
            break;
        }
    }
}
