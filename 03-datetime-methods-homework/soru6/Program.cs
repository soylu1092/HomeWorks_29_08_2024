namespace soru6;

class Program
{
    static void Main(string[] args)
    {
        
        System.Console.WriteLine("lütfen bir yil giriniz.");
        string yi1=Console.ReadLine();
        int yil2=Convert.ToInt32(yi1);
        bool artikYil=DateTime.IsLeapYear(yil2);
        System.Console.WriteLine(artikYil);
        
        


    }
}
