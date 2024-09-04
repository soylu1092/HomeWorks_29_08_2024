namespace soru9;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("bir yil giriniz.");
        string yil=Console.ReadLine();
        int yil1=Convert.ToInt32(yil);
        if(((yil1%4==0 && yil1%100!=0)||yil1%400==0)&&yil1%4000!=0){
            System.Console.WriteLine($"Artik yil:{yil1}");
        }
        else{
            System.Console.WriteLine($"{yil1} Artik yil değildir.");
        }
    }
}
