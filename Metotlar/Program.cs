using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 25;
            urun1.Aciklama = "Amasya Elmasi";
            urun1.StokAdedi = 100;

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 32;
            urun2.Aciklama = "Diyarbakır karpuzu güzeldir.";
    

            Console.WriteLine("------------------------");

            SepetManager spt = new SepetManager();
            spt.Ekle(urun1);
            spt.Ekle(urun2);


            spt.ekle2("elma", "yeşil elma", 21,21.5);
        }
    }
}
