namespace soru6;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("lütfen bir not giriniz.");
        string not1=Console.ReadLine();
        int not2=Convert.ToInt32(not1);
        if(not2>=90){
            System.Console.WriteLine("Harf notunuz:AA");
        }else if(not2>=85){
            System.Console.WriteLine("Harf notunuz:BA");
        }else if(not2>=80){
            System.Console.WriteLine("Harf notunuz:BB");
        }else if(not2>=70){
            System.Console.WriteLine("Harf notunuz:CB");
        }else if(not2>=60){
            System.Console.WriteLine("Harf notunuz:CC");
        }else if(not2>=55){
            System.Console.WriteLine("Harf notunuz:DC");
        }else if(not2>=50){
            System.Console.WriteLine("Harf notunuz:DD");
        }else if(not2>=40){
            System.Console.WriteLine("Harf notunuz:ED");
        }else if(not2>=0){
            System.Console.WriteLine("Harf notunuz:FF");
        }

    }
}
