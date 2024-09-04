namespace soru4;

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

        //  artik yil nedir:
        // 1- 4sayisinin kati olmalidir.
        // 2- 400sayisina kalansiz bölünebilmesi gerekir.
        // 3- 100e bölünememesi gerekir.
        // 4- 4000bölünmemesi gerekir.
    }
}
