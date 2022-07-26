﻿using CollegeNS;
using PersonNS;
using ProfessorNS;
using StudentNS;

namespace ConsoleApp 
{ 
    class Program
    {
        static void Main(string[] args) 
        {
            var politehnica = new College("Politehnica");

            var vasi = new Professor("Vasi", 45, "OOP");

            var nour = new Student("Nour", 21, "1231A", new List<string>() { "Football", "Fishing", "Video games", "Billiard", "Ping pong"});

            var laur = new Student("Laur", 22, "1231A");

            politehnica.AddProf(vasi);
            politehnica.AddStud(nour);
            politehnica.AddStud(laur);


            Console.WriteLine("College info {\n" + politehnica.ToString() + "\n}");


            Console.WriteLine("\n////////////////////////////////////////////////////////////////////////////\n");

            Console.WriteLine("About Nour { \n");
            nour.About();

            Console.WriteLine("\n}\n\nAbout Laur { \n");
            laur.About();

            Console.WriteLine("\n}\n\nAbout Vasi { \n");
            vasi.About();
            Console.WriteLine("\n}\n");

            Console.WriteLine("\n////////////////////////////////////////////////////////////////////////////\n");

            nour.Hobbies();
            //nour.Hobbies(2);

            laur.Hobbies();

            //The below line of code produces an exception due to not having enough hobbies to fulfill the desired amount given in the parameter
            //laur.Hobbies(3);

            Console.WriteLine("\n////////////////////////////////////////////////////////////////////////////\n");

            //IEnumerable
            Person[] peopleArray = new Person[3]
            {
                vasi,
                nour,
                laur,
            };

            People peopleList = new People(peopleArray);
            foreach (Person p in peopleList)
                p.Intro();

            Console.WriteLine("\n////////////////////////////////////////////////////////////////////////////\n");

            //ICloneable
            var clonedCollege = politehnica.Clone();
            Console.WriteLine(clonedCollege.ToString());

        }
    }
}


