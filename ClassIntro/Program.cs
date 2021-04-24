using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Kurs Kurs1 = new Kurs();

            Kurs1.KursAdi = "C# ile başlangıç seviyesi eğitimleri";
            Kurs1.KursEğitmeni = "Ufuk çetin";
            Kurs1.IzlenmeOrani = 100;

            Kurs Kurs2 = new Kurs();

            Kurs2.KursAdi = "Java";
            Kurs2.KursEğitmeni = "Şadiye Şermin ÇEtin";
            Kurs2.IzlenmeOrani = 144;


            Kurs Kurs3 = new Kurs();

            Kurs3.KursAdi = "c++ a giriş";
            Kurs3.KursEğitmeni = "Osman Yıldırım";
            Kurs3.IzlenmeOrani = 33;




            Kursum Kursum1 = new Kursum();
            Kursum1.KursAdi = "denemem";

            Kursum[] deneme = new Kursum[] { Kursum1 };

           

            foreach (var x in deneme)
            {
                Console.WriteLine(x.KursAdi);
            }

        }
    }
    public class Kurs
    {
        public string KursAdi { get; set; }
        public string KursEğitmeni { get; set; }
        public int IzlenmeOrani { get; set; }
    }

    public class Kursum
    {
        public string KursAdi { get; set; }
        public string KursEğitmeni { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
