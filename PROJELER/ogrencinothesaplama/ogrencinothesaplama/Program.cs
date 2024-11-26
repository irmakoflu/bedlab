internal class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine("sinif mevcut sayisini giriniz:");
        int n = int.Parse(Console.ReadLine());

        Dictionary<string, int> d = new Dictionary<string, int>();

        List<string> ogr = new List<string>();
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("ogrenciyi giriniz:");
            string a = Console.ReadLine();
            ogr.Add(a);

            int[] notlar = new int[3];
            Console.WriteLine(ogr[i] + "notunu giriniz:");
            for (int j = 0; j < 3; j++)
            {
                notlar[j] = int.Parse(Console.ReadLine());
            }
            int ort = orthesapla(notlar);

            d.Add(ogr[i], ort);

            
           
        
          
           
        }

        foreach (KeyValuePair<string, int> dyaz in d)
        {
            Console.WriteLine("ogrenci adi:{0} - ogrenci ortalamasi{1}", dyaz.Key, dyaz.Value);
        }

        int genelort = 0;
        foreach (int ortalama in d.Values)
        {
            genelort += ortalama;
        }

        Console.WriteLine("sınıf genel ortalamasi:" + (genelort / n));

    }

    public static int orthesapla(int[]dizi) {

        int top = 0;
        for(int i = 0;i < dizi.Length; i++)
        {
            top += dizi[i];
        }
        int sonuc=(top/dizi.Length);
        return sonuc;

    }

}