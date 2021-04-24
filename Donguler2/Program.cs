using System;

namespace Donguler2
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] dersler = new string[] { "deneme1", "deneme2", "deneme3" };

            for (int i = 0; i < dersler.Length; i+=1)
            {
                Console.WriteLine(dersler[i]);
            }

            foreach (var kurs in dersler)
            {
                Console.WriteLine(kurs);
            }
        }
    }
}
