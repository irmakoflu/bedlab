internal class Program
{
    private static void Main(string[] args)
    {
        bankahesabi hesap1=new bankahesabi("irmakoflu",2204,18500);


       

        int dongu = 0;

        while (dongu == 0)
        {
            String islemler = "1.hesap bilgilerini goruntuleme\n" +
            "2.para yatirma\n" +
            "3.para cekme";

            Console.WriteLine(islemler);
            Console.WriteLine("yapmak istediğiniz islemi seciniz:");
            int islem = int.Parse(Console.ReadLine());
            switch (islem)
            {
                case 1:
                    hesap1.hesapbilgilerigoruntule();
                    break;
                case 2:
                    Console.WriteLine("kac para yatırmak istiyorsunuz?");
                    int k = int.Parse(Console.ReadLine());
                    hesap1.parayatir(k);
                    break;
                case 3:
                    Console.WriteLine("kac para cekmek istersiniz?");
                    int b = int.Parse(Console.ReadLine());
                    hesap1.paracek(b);
                    break;
                default:
                    Console.WriteLine("gecersiz islem girdiniz.");
                    break;

            }
            Console.WriteLine("islemlere devam etmek ister misiniz(evet:0,hayir:1");
            dongu=int.Parse(Console.ReadLine());
            
        }
        Console.WriteLine("cikis yapiliyor...");

        


    }
    internal class bankahesabi //sadece tanımlandığı proje içinde erisilebilir
    {
        public String Hesapsahibi { get; private set; }
        public int Hesapno { get; private set; } //dısarıdan degistirilemez
        private int bakiye { get; set; }


        public bankahesabi(string hesapsahibi, int hesapno,int Bakiye)//constructor
        {
            Hesapsahibi = hesapsahibi;
            Hesapno = hesapno;
            bakiye =Bakiye;

        }
        public void paracek(int miktar)
        {
            try
            {
                if (miktar <= 0)
                {
                    throw new ArgumentException("cekilen miktar sifirdan buyuk olmalıdır.");
                }
                if (miktar > bakiye)
                {
                    throw new InvalidOperationException("yetersiz bakiye...");
                }

                bakiye -= miktar;
                Console.WriteLine($"{miktar} TL cekildi.Kalan bakiyeniz:{bakiye}");
            }
            catch ( ArgumentException ex)
            {
                Console.WriteLine(ex.Message );
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"beklenmeyen hata olustu:{ ex.Message}");
            }
        }
        public void parayatir(int ymiktar)
        {
            try
            {
                if (ymiktar <= 0)
                {
                    throw new ArgumentException("yatirilan miktar sifirdan buyuk olmalıdır.");
                }

                bakiye += ymiktar;
                Console.WriteLine($"yeni bakiyeniz:{bakiye}");
            }
            catch( ArgumentException ex)
            {
                Console.WriteLine (ex.Message );
            }
        }
        public void hesapbilgilerigoruntule()
        {
            Console.WriteLine($"hesap sahibi:{Hesapsahibi}- hesap numarası:{Hesapno}-mevcut bakiyeniz:{bakiye}");
        }

    }
}