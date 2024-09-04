namespace soru6;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("kaç kilo armut?");
        string armut1=Console.ReadLine();
        double armut2=Convert.ToDouble(armut1);
        System.Console.WriteLine("kac kilo bamya?");
        string bamya1=Console.ReadLine();
        double bamya2=Convert.ToDouble(bamya1);
        System.Console.WriteLine("kac kilo domates?");
        string domates1=Console.ReadLine();
        double domates2=Convert.ToDouble(domates1);
        System.Console.WriteLine("kac kilo muz?");
        string muz1=Console.ReadLine();
        double muz2=Convert.ToDouble(muz1);
        System.Console.WriteLine("kac kilo patlican?");
        string patlican1=Console.ReadLine();
        double patlican2=Convert.ToDouble(patlican1);
        double armut3=armut2*45.50;
        double bamya3=bamya2*81.40;
        double domates3=domates2*45.00;
        double muz3=muz2*65.00;
        double patlican3=patlican2*45.00;
        double result=patlican3+muz3+domates3+bamya3+armut3;
        System.Console.WriteLine($"Toplam tutar:{result}");
    }
}
