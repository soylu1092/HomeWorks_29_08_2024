namespace soru4;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("lütfen bir sayi giriniz.");
        string result=Console.ReadLine();
        int result1=int.Parse(result);
        System.Console.WriteLine(Math.Sqrt(result1));
    }
}
