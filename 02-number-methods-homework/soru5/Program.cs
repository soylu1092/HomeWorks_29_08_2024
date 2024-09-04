namespace soru5;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("lütfen 1. sayiyi giriniz.");
        string result=Console.ReadLine();
        double result1=Convert.ToDouble(result);
        System.Console.WriteLine("lütfen 1. sayinin üs degerini giriniz.");
        string result3=Console.ReadLine();
        double result4=Convert.ToDouble(result3);
        System.Console.WriteLine(Math.Pow(result1,result4));
        System.Console.WriteLine("lütfen 2. sayiyi giriniz.");
        string result5=Console.ReadLine();
        double result6=Convert.ToDouble(result5);
        System.Console.WriteLine("lütfen 2. sayinin üs degerini giriniz.");
        string result7=Console.ReadLine();
        double result8=Convert.ToDouble(result7);
        System.Console.WriteLine(Math.Pow(result6,result8));



    }
}
