namespace soru8;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("lütfen bir sayi giriniz.");
        string sayi1=Console.ReadLine();
        int sayi2=Convert.ToInt32(sayi1);
        if(sayi2%3==0&&sayi2%5==0){
            System.Console.WriteLine("Sayi kosullara uygun sekilde bölünmüştür.");
        }else{
            System.Console.WriteLine("Sayi kosullara uygun sekilde bölünememiştir!");
        }
    }
}
