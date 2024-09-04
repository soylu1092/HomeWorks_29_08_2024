namespace soru2;

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
        System.Console.WriteLine("lütfen 3. sayiyi giriniz.");
        string sayi5=Console.ReadLine();
        int sayi6=Convert.ToInt32(sayi5);
        if(sayi2>sayi4&&sayi4>sayi6||sayi2>sayi6&&sayi6>sayi4){
            System.Console.WriteLine($"{sayi2}>{sayi4}>{sayi6}");
           
        } else if(sayi4>sayi2&&sayi2>sayi6||sayi4>sayi6&&sayi6>sayi2){
            System.Console.WriteLine($"{sayi4}>{sayi2}>{sayi6}");
        }else if(sayi6>sayi4&&sayi4>sayi2||sayi6>sayi2&&sayi2>sayi4){
            System.Console.WriteLine($"{sayi6}>{sayi4}>{sayi2}");
        }else{
            System.Console.WriteLine("hepsi esittir.");
        }
                
            


    }
}
