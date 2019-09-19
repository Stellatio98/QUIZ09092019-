using System;

namespace QUIZ09092019_1
{
    class bangun_ruang
    {

        public void VolumeBalok()
        {
            Console.WriteLine("Menghitung Volume Balok");
            Console.WriteLine("---------------------");

            Console.WriteLine("Volume Balok");

            int panjang, lebar, tinggi;

            Console.Write("Masukkan nilai panjang: ");
            panjang = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Masukkan nilai lebar: ");
            lebar = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukkan nilai tinggi: ");
            tinggi = Convert.ToInt32(Console.ReadLine());

            int volume = ( panjang * lebar * tinggi);

            Console.WriteLine("Volume balok adalah :"+volume);
            Console.WriteLine("Tekan SPACE untuk melanjuti");
            Console.ReadKey(true);
        }
         public void VolumeKubus()
        {
            Console.WriteLine("Menghitung Volume Kubus");
            Console.WriteLine("---------------------");

            Console.WriteLine("Volume Kubus");

            int sisi;

            Console.Write("Masukkan nilai sisi: ");
            sisi = Convert.ToInt32(Console.ReadLine());
        
            int volume = ( sisi * sisi * sisi);

            Console.WriteLine("Volume Balok adalah :"+volume);
            Console.WriteLine("Selesai");
            Console.ReadKey(true);
        }
    }
}    

          