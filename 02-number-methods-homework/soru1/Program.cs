namespace soru1;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("lütfen bir sayi giriniz.");
        string result=Console.ReadLine();
        double result1=Convert.ToDouble(result);
        System.Console.WriteLine(Math.Ceiling(result1));
    }
}
