using System.Security.Cryptography;

namespace soru4;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("lütfen yaricap degerini giriniz.");
        string sayi1=Console.ReadLine();
        double sayi2=Convert.ToDouble(sayi1);
        double pi=3.14;
        double cevre=(sayi2*2)*pi;
        double alan=(sayi2*sayi2)*pi;
        System.Console.WriteLine("Alan ise 1'i Cevre ise 2'yi tuslayiniz.");
        string s1=Console.ReadLine();
        double s2=Convert.ToDouble(s1);
        if(s2==1){
            System.Console.WriteLine($"Cevre:{cevre}");
        }else{
            System.Console.WriteLine($"Alan:{alan}");
        }
        


    }
}
