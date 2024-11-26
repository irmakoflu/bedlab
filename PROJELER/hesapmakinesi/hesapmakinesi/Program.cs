internal class Program
{
    private static void Main(string[] args)
    {
        
        int cevap = 1;

        while (cevap > 0)
        {

            Console.WriteLine("sayı giriniz:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("sayı giriniz:");
            int b = int.Parse(Console.ReadLine());


            Console.WriteLine("Hangi işlemi yapacaksınız");
            string islemler = ("1-toplama\n"
                    + "2-cikarma\n"
                    + "3-carpma\n"
                    + "4-bolme");
            Console.WriteLine(islemler);
            int secim = int.Parse(Console.ReadLine());
            switch (secim)
            {
                case 1:
                    Console.WriteLine(a + b);
                    break;
                case 2:
                    Console.WriteLine(a - b);
                    break;
                case 3:
                    Console.WriteLine(a * b);
                    break;
                case 4:
                    if (b == 0)
                    {
                        Console.WriteLine("bu işem gecersiz...");
                    }
                    else
                    {
                        Console.WriteLine(a / b);
                    }
                    break;
                default:
                    Console.WriteLine("gecersiz islem girdiniz...");
                    break;
            }
            Console.WriteLine("isleme devam etmek istiyor musunuz?(evet:1 , hayir:0)");
             cevap=int.Parse(Console.ReadLine());
        }
    }
}