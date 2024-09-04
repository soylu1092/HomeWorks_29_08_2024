namespace soru1;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Lütfen bir kelime giriniz.");
          string metin=Console.ReadLine();
          string[] kelimeler=metin.Split(' ');
          System.Console.WriteLine(kelimeler.Length);
    }
}
