using System;

namespace Latihan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var jumlahSpasi = 0;
            var kataTerpendek = 0;
            var kalimat = "";

            while (jumlahSpasi < 2 || kataTerpendek <= 1)
            {
                Console.Write("\nMasukkan Kalimat : ");
                kalimat = Console.ReadLine();
                kalimat = kalimat.ToUpper();

                kataTerpendek = kalimat.Length;
                var jumlahHurufKata = 0;

                for (int i = 0; i < kalimat.Length; i++)
                {
                    if (kalimat[i] == ' ')
                    {
                        if (kataTerpendek >= jumlahHurufKata)
                            kataTerpendek = jumlahHurufKata;

                        jumlahHurufKata = 0;
                        jumlahSpasi++;
                    }
                    else jumlahHurufKata++;
                }

                if (jumlahSpasi < 2)
                    Console.WriteLine("KATA PADA KALIMAT KURANG PANJANG !");
                if (kataTerpendek <= 1)
                    Console.WriteLine("HURUF PADA KATA KURANG PANJANG !");
            }

            Console.Write("\nMasukkan Kata : ");
            var kataDicari = Console.ReadLine();
            kataDicari = kataDicari.ToUpper();


            // Statistik Huruf
            Console.WriteLine("\nSTATISTIK HURUF : ");

            char[] kalimatArray = kalimat.ToCharArray();
            Array.Sort(kalimatArray);

            var jumlahHuruf = 1;
            var jumlahHurufTotal = 0;
            for (int i = 1; i < kalimatArray.Length; i++)
            {
                if (kalimatArray[i] == kalimatArray[i - 1])
                    jumlahHuruf++;
                else
                {
                    if (kalimatArray[i - 1] != ' ')
                        Console.WriteLine($"{kalimatArray[i - 1]} = {jumlahHuruf}");
                    jumlahHuruf = 1;
                }

                jumlahHurufTotal++;
            }

            // Statistik Kata
            Console.WriteLine("\nSTATISTIK KATA : ");

            var jumlahKataDicari = 0;
            while (kalimat.Contains(kataDicari))
            {
                jumlahKataDicari++;
                kalimat =kalimat.Remove(kalimat.IndexOf(kataDicari), kataDicari.Length);
            }

            Console.WriteLine($"{kataDicari} = {jumlahKataDicari}\n");
            Console.WriteLine($"JUMLAH HURUF = {jumlahHurufTotal}\n");
        }
    }
}
