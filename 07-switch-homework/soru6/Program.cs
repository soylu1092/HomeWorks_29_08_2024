namespace soru6;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Lütfen notunuzu giriniz.");
        string not1=Console.ReadLine();
        int not2=Convert.ToInt32(not1);
        switch(not2){
            case >=85:
            System.Console.WriteLine("A");
            break;
            case >=70:
            System.Console.WriteLine("B");
            break;
            case >=55:
            System.Console.WriteLine("C");
            break;
            case >=40:
            System.Console.WriteLine("D");
            break;
            case <=39:
            System.Console.WriteLine("F");
            break;


        }


    }
}
