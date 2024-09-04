namespace soru10;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("lütfen bir sayi giriniz.");
        string sayi1=Console.ReadLine();
        int sayi2=Convert.ToInt32(sayi1);
        if(sayi2%2!=0&&sayi2%sayi2==0&&sayi2%1==0){
            System.Console.WriteLine("asaldir.");
        }else{
            System.Console.WriteLine("asal değildir.");
        }
        
        

    }
}
