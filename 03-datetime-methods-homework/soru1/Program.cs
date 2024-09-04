using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace soru1;

class Program
{
    static void Main(string[] args)
    {
        
        System.Console.WriteLine("bir tarih giriniz.");
        string birtDay=Console.ReadLine();
        DateTime birtDay1=Convert.ToDateTime(birtDay);
        System.Console.WriteLine(birtDay1.DayOfWeek);
        
        
        
        
    }
}
