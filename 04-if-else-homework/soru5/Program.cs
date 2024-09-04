namespace soru5;

class Program
{
    static void Main(string[] args)
    {
        /*
        birinci kenar+ikinci kenar=sonucun karesi=3.kenarın karesi
        */
    System.Console.WriteLine("1. kenar uzunluğunu giriniz.");
    string sayi1=Console.ReadLine();
    double sayi2=Convert.ToDouble(sayi1);
    System.Console.WriteLine("2. kenar uzunluğunu giriniz.");
    string sayi3=Console.ReadLine();
    double sayi4=Convert.ToDouble(sayi3);
    System.Console.WriteLine("3. kenar uzunluğunu giriniz.");
    string sayi5=Console.ReadLine();
    double sayi6=Convert.ToDouble(sayi5);
    double uzunluk1=Math.Pow(sayi2,2);
    double uzunluk2=Math.Pow(sayi4,2);
    double uzunluk3=Math.Pow(sayi6,2);
    double pisagor=uzunluk1+uzunluk2;
    double pisagor1=pisagor;
    if(pisagor==pisagor1){
        System.Console.WriteLine("üçgen oluşturulabilir.");
    }else{
        System.Console.WriteLine("üçgen oluşturulamaz.");
    }

    }
}
