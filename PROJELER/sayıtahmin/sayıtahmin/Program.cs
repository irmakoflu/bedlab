internal class Program
{
    private static void Main(string[] args)
    {

        int hak = 3;
        Random rnd = new Random();
        int sayi = rnd.Next(100);
        Console.WriteLine(sayi);

        

        while (hak > 0)
        {

            Console.WriteLine("sayiyi tahmin ediniz(" + hak + " hakkiniz bulunmaktadir.):");
            int tahmin = int.Parse(Console.ReadLine());


            if (tahmin == sayi)
            {
                Console.WriteLine("tebrikler,dogru tahmin");
                break;
            }
            else
            {
                if(hak!=1){
                    if (tahmin < sayi)
                    {

                        Console.WriteLine("maalesef,daha buyuk bir sayi tahmin ediniz.");
                    }
                    else
                    {
                        Console.WriteLine("maalesef,daha kucuk bir sayi tahmin ediniz.");
                    }
                }
                    hak--;
                
            }
        }
        if (hak == 0)
        {
            Console.WriteLine("hakkiniz bitmistir.Bulamadiniz:(");
        }
    }
}