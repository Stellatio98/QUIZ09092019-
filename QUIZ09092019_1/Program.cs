using System;

namespace QUIZ09092019_1
{
    class Program
    {
        static void Main(string[] args)
        {
            bangun_datar obj =  new bangun_datar();
            obj.LuasPersegi();
            Console.WriteLine("______________________________________________");
            obj.LuasSegitiga();
            Console.WriteLine("______________________________________________");
            obj.LuasLingkaran();
            Console.WriteLine("______________________________________________");      
        
            bangun_ruang tes = new bangun_ruang();
            tes.VolumeBalok();
            Console.WriteLine("______________________________________________");
            tes.VolumeKubus();
            Console.WriteLine("______________________________________________");

        }
    }
}
