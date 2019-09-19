using System;

namespace QUIZ09092019_1
{
    class bangun_datar
    {

        public void LuasPersegi()
        {
            Console.WriteLine("Menghitung Luas Persegi");
            Console.WriteLine("---------------------");

            Console.WriteLine("Luas Persegi");

            int sisi;

            Console.Write("Masukkan nilai sisi: ");
            sisi = Convert.ToInt32(Console.ReadLine());
            int luas = (sisi * sisi);

            Console.WriteLine("Luas Persegi adalah :"+luas);
            Console.WriteLine("Tekan SPACE untuk melanjuti");
            Console.ReadKey(true);
        }
        public void LuasSegitiga()
        {
            Console.WriteLine("Menghitung Luas Segitiga");
            Console.WriteLine("---------------------");

            Console.WriteLine("Luas Segitiga");

            int alas,tinggi;

            Console.Write("Masukkan nilai tinggi: ");
            tinggi = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan nilai alas : ");
            alas = Convert.ToInt32(Console.ReadLine());
            int luas = (tinggi * alas / 2);

            Console.WriteLine("Luas Segitiga adalah :"+luas);
            Console.WriteLine("Tekan SPACE untuk melanjuti");
            Console.ReadKey(true);

        }
         public void LuasLingkaran()
        {
            Console.WriteLine("Menghitung Luas Lingkaran");
            Console.WriteLine("---------------------");

            Console.WriteLine("Luas Lingkaran");

            const double phi = 3.14;
            double luas;
            int r;

            Console.Write("Masukkan nilai jari: ");
            r = Convert.ToInt32(Console.ReadLine());
            luas = r * r * phi;

            Console.WriteLine("Luas Lingkaran adalah :"+luas);
            Console.WriteLine("Tekan SPACE untuk melanjuti");
            Console.ReadKey(true);
    
       } 
    }
}