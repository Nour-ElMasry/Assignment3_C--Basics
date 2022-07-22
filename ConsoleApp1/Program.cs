using System;
using ClassLibrary1;


namespace ConsoleApp 
{ 
    class Program
    {
        static void Main(string[] args) 
        {
            var politehnica = new College("Politehnica");

            var vasi = new Prof("Vasi", 45, "OOP");

            var nour = new Stud("Nour", 21, "1231A");

            var laur = new Stud("Laur", 22, "1231A");

            politehnica.AddProf(vasi);
            politehnica.AddStud(nour);
            politehnica.AddStud(laur);


            Console.WriteLine("College info {\n" + politehnica.ToString() + "\n}\n\n");

            Console.WriteLine("About Nour { \n");
            nour.About();

            Console.WriteLine("\n}\n\nAbout Laur { \n");
            laur.About();

            Console.WriteLine("\n}\n\nAbout Vasi { \n");
            vasi.About();
            Console.WriteLine("\n}");

        }
    }
}


