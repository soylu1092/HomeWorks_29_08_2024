namespace soru4;

class Program
{
    static void Main(string[] args)
    {
        DateTime tarih=new DateTime(2001,02,15);
        DateTime tarih1=new DateTime(2024,02,15);
        TimeSpan result=tarih1-tarih;
        System.Console.WriteLine(result);
    }
}
