namespace soru3;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("lütfen kilometreyi giriniz.");
        string km1=Console.ReadLine();
        int km2=Convert.ToInt32(km1);
        int kmBasi=20;
        int acilis=30;
        int tutar=(acilis)+kmBasi*km2;
        if(km2<=3){
            System.Console.WriteLine($"indi bindi ücreti:{100}TL'dir.");
        }else if(km2>=4){
            System.Console.WriteLine($"taksi ücretiniz:{tutar}TL'dir.");
        }

        }

        

        

    }

