namespace soru7;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("lütfen 1. sayiyi giriniz.");
        string sayi1=Console.ReadLine();
        int sayi2=Convert.ToInt32(sayi1);
        System.Console.WriteLine("lütfen 2. sayiyi giriniz.");
        string sayi3=Console.ReadLine();
        int sayi4=Convert.ToInt32(sayi3);
        System.Console.WriteLine("lütfen bir islem giriniz.");
        string char1=Console.ReadLine();
        char char2=Convert.ToChar(char1);
        switch(char2){
            case '+':
            System.Console.WriteLine(sayi2+sayi4);
            break;
            case '-':
            System.Console.WriteLine(sayi2-sayi4);
            break;
            case '*':
            System.Console.WriteLine(sayi2*sayi4);
            break;
            case '/':
            System.Console.WriteLine(sayi2/sayi4);
            break;
        }
    }
}
