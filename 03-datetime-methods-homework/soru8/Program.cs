namespace soru8;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("lütfen bir tarih giriniz.");
        string tarih=Console.ReadLine();
        DateTime tarih1=Convert.ToDateTime(tarih);
        System.Console.WriteLine(tarih1.ToString("MMM"));
        
        
        
    }
}
