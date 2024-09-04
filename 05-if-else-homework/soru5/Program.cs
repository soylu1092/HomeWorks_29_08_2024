using System.Security.Cryptography;

namespace soru5;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("lütfen kilonuzu giriniz");
        string kilo1=Console.ReadLine();
        double kilo2=Convert.ToDouble(kilo1);
        System.Console.WriteLine("lütfen boyunuzu giriniz.");
        string boy1=Console.ReadLine();
        double boy2=Convert.ToDouble(boy1);
        double boy3=boy2*boy2;
        double vucutIndeks=kilo2/boy3;
        System.Console.WriteLine(vucutIndeks);
        if(vucutIndeks<=25){
            System.Console.WriteLine("Gayet sağliklisiniz!");
        }else{
            System.Console.WriteLine("Sağliksizsiniz lütfen tibbi bir destek alin.");
        }
    }
}
