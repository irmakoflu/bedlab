using System.Collections;
internal class Program
{
    private static void Main(string[] args)
    {

        ArrayList kisiler = new ArrayList();
       

        int dongu = 0;
        while (dongu == 0)
        {

            String islemler = "1.kayıt etmek\n" +
           "2.kişi aramak\n" +
           "3.kişi silmek\n" +
           "4.cikis";

            Console.WriteLine(islemler);
            Console.WriteLine("yapmak istediğiniz işlemi seciniz:");
            int islem = int.Parse(Console.ReadLine());


            switch (islem)
            {
                case 1:
                    kayitet(kisiler);
                    break;


                case 2:
                    kisiara(kisiler);
                    break;
                case 3:
                    kisisil(kisiler);
                    break;
                case 4:
                    Console.WriteLine("CİKİS YAPİLİYOR...");
                    dongu = 1;
                    break;
                default:
                    Console.WriteLine("gecersiz islem girdiniz.");
                    break;
            }

        }

    }
    public static void kayitet(ArrayList kisiler)
    {

   
        Console.WriteLine("eklemek istediginiz kisinin adini soyadini giriniz:");
        String ads=Console.ReadLine();
        Console.WriteLine("kayıt etmek istediginiz kisinin numarasini giriniz:");
        String no = Console.ReadLine();
        Console.WriteLine("kayıt etmek istediginiz kisinin adresini giriniz:");
        String ad = Console.ReadLine();

        kisi kisi1 = new kisi(ads, no, ad);
        try
        {
            if (kisiler.Contains(kisi1))
            {
                Console.WriteLine("bu kisi zaten var.");
            }
            kisiler.Add(kisi1);

            Console.WriteLine("kaydedildi.");
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
        

    }
    public static void kisiara(ArrayList kisiler)
    {
        Console.WriteLine("aramak istediginiz kisiyi giriniz:");
        String ads=Console.ReadLine();
        bool bulundu=false;

        foreach(kisi s in kisiler)
        {
            if (s.adsoyad.Equals(ads, StringComparison.OrdinalIgnoreCase)){

                bulundu= true;
                Console.WriteLine($"kisi bulundu.{s.adsoyad} - {s.numara} - {s.adress}");
                break;
            }
           
        }
        if (!bulundu)
        {
            Console.WriteLine($"{ads} bulunamadi");
        }

    }
    public static void kisisil(ArrayList kisiler)
    {
        Console.WriteLine("silmek istediginiz kisinin adini soyadini giriniz:");
        String ads=Console.ReadLine();

        foreach (kisi s in kisiler)
        {
            if (s.adsoyad.Equals(ads, StringComparison.OrdinalIgnoreCase))
            {


               kisiler.Remove(s);
                Console.WriteLine("kisi silindi");
                break;
            }
           
        }
        Console.WriteLine("kisi zaten yok.");


    }



    internal class kisi
    {
        public String adsoyad { get; set; }
        public String numara { get; set; }
        public String adress { get; set; }

        public kisi(String Ad,String No,String Add) {
        adsoyad = Ad;
        numara = No;
        adress = Add;
        
        }
    }
}
