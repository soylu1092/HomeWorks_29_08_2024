namespace soru9;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("lütfen 1. tarihi giriniz.");
        string tarih=Console.ReadLine();
        DateTime tarih1=Convert.ToDateTime(tarih);
        System.Console.WriteLine("lütfen 2. tarihi giriniz.");
        string tarih2=Console.ReadLine();
        DateTime tarih3=Convert.ToDateTime(tarih2);
        int result=DateTime.Compare(tarih1,tarih3);
        if(result>0){
            System.Console.WriteLine("1. tarih büyüktür.");
        }else if(result==-1){
            System.Console.WriteLine("2. tarih büyüktür.");
        }else{
            System.Console.WriteLine("iki tarih birbirine eşittir.");
        }
    }
}
