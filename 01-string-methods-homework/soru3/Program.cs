using System.Reflection;
using System.Xml.XPath;

namespace soru3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("lutfen bir cümle giriniz.");
        string cumle=Console.ReadLine();
        System.Console.WriteLine("aranacak kelime?");
        string aranacakKelime=Console.ReadLine();
        string[] stringArr=cumle.Trim().Split(" ");
        int sayac=0;
        for (int i = 0; i < stringArr.Length; i++)
        {
            if(stringArr[i]==aranacakKelime){
                sayac++;
            }
        }
        System.Console.WriteLine(sayac);

        
    }
}
