namespace soru7;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("lütfen bir derece giriniz(0-360)");
        string derece=Console.ReadLine();
        double derece1=Convert.ToDouble(derece);
        double pi=3.14;
        double radyan=180;
        double radyanHesaplama=derece1*pi/radyan;
        
        if(derece1<=360)
        {
            System.Console.WriteLine($"Radyan Degeri:{radyanHesaplama}");

        }else
        {
            System.Console.WriteLine("lütfen verilen degerler arasinda bir derece giriniz.");
        }
    }
}
