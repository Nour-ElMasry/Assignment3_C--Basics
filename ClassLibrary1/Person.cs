using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonNS
{
    public abstract class Person : IPerson
    {
        public string _name;
        public int _age;

        public abstract void About();

        public void Intro()
        {
            Console.WriteLine("Hi, my name is " + _name + "! I am " + _age + " years old.");
        }
    }

    public interface IPerson
    {
        void Intro();
    }

    public interface IHobbies
    {
        int Hobbies();
        int Hobbies(int num);
    }
}
