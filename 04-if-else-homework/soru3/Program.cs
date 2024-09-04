namespace soru3;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("lütfen bir karakter giriniz.");
        string char1=Console.ReadLine();
        char char2=Convert.ToChar(char1);
        if(char1=="a"||char1=="e"||char1=="ı"||char1=="i"||char1=="o"||char1=="ö"||char1=="u"||char1=="ü"){
            System.Console.WriteLine("Sesli harfdir.");
        }else{
            System.Console.WriteLine("Sessiz harfdir.");
        }
    }
}
