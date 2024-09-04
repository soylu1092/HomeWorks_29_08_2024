namespace soru1;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("lütfen 1. sayiyi giriniz.");
        string sayi1=Console.ReadLine();
        int sayi2=Convert.ToInt32(sayi1);
        if(sayi2<0){
            System.Console.WriteLine("sayi negatifdir.");
        }else if(sayi2>0){
            System.Console.WriteLine("sayi pozitifdir.");
        }else{
            System.Console.WriteLine("sayi 0'dir.");
        }
    }
}
