
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("kac elemanli dizi gireceksiniz?");
        int a = int.Parse(Console.ReadLine());

        int[] dizi = new int[a];

        for (int i = 0; i < a; i++)
        {
            Console.WriteLine(i + 1 + ".elemani giriniz:");
            dizi[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("aramak istediginiz sayiyi giriniz:");
        int aranacak = int.Parse(Console.ReadLine());



        int[] sdizi = bubblesort(dizi);
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("siralanmis dizi-->");
        for(int i = 0;i < sdizi.Length; i++)
        {
            Console.Write(sdizi[i]+" ");
        }
        Console.WriteLine();
        Console.WriteLine("----------------------------------------");
        int b = sayibul(sdizi, aranacak);

        if (b == -1) {
            Console.WriteLine("sayi bulunamadi.");
        }
        else
        {
            Console.WriteLine(aranacak +" sayisi " + (b+1)+ ". sirada bulundu.");
        }
    }
    public static int sayibul(int[] a, int s)
    {

        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] == s)
            {
                return i;
            }

        }
        return -1;
    }
    public static int[] bubblesort(int[] d)
    {
        int n = d.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - 1 - i; j++)
            {
                if (d[j] > d[j + 1])
                {
                    int temp = d[j];
                    d[j] = d[j + 1];
                    d[j + 1] = temp;
                }
            }
        }
        return d;
    }
}
