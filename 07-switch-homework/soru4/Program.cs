namespace soru4;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Lütfen bir harf giriniz.");
        string char1=Console.ReadLine();
        char char2=Convert.ToChar(char1);
        if(char2=='a'||char2=='e'||char2=='ı'||char2=='i'||char2=='o'||char2=='ö'||char2=='u'||char2=='ü'){
            System.Console.WriteLine("Sesli harf girdiniz.");
        }else{
            System.Console.WriteLine("Sessiz harf girdiniz.");
        }
        
            
        
        
    }
}
