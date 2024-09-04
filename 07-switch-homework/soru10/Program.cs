namespace soru10;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Lütfen bir işlem karakteri giriniz(+,-,/,*,%)");
        string char1=Console.ReadLine();
        char char2=Convert.ToChar(char1);
        switch(char2){
            case '+':
            System.Console.WriteLine("Toplama");
            break;
            case '-':
            System.Console.WriteLine("Cıkarma");
            break;
            case '*':
            System.Console.WriteLine("Carpma");
            break;
            case '/':
            System.Console.WriteLine("Bölme");
            break;
            case '%':
            System.Console.WriteLine("Yüzde hesaplama");
            break;
        }
    }
}
