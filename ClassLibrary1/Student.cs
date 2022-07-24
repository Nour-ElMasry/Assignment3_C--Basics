using PersonNS;

namespace StudentNS
{
    public class Student : Person, IHobbies
    {
        public string Group { get; set; }
        public string ResidingCollege = "";
        public List<string> StudHobbies { get; set; }
        public Student(string name, int age, string group, List<string> studHobbies)
        {
            _name = name;
            _age = age;
            Group = group;
            StudHobbies = studHobbies;
        }

        public Student(string name, int age, string group)
        {
            _name = name;
            _age = age;
            Group = group;
            StudHobbies = new List<string>();
        }

        public override string ToString()
        {
            return "{ Name: " + _name + ", Age: " + _age + ", Group: " + Group + " }, ";
        }

        public override void About()
        {
            Intro();
            Console.WriteLine("I am a student at " + ResidingCollege);
        }

        public int Hobbies()
        {
            if (!StudHobbies.Any())
            {
                Console.WriteLine(_name + " doesn't have any hobbies registered");
                return -1;
            }

            Console.WriteLine(_name + "'s hobbies are: ");

            StudHobbies.ForEach(x => Console.WriteLine(x + ","));

            Console.WriteLine("\n");

            return 0;
        }

        public int Hobbies(int num)
        {
            if (!StudHobbies.Any())
            {
                Console.WriteLine(_name + " doesn't have any hobbies registered");
                return -1;
            }

            if (num > StudHobbies.Count)
                throw new Exception("Out of range! " + _name + " has " + StudHobbies.Count + " hobbies.");

            Console.WriteLine(_name + "'s hobbies are: ");

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(StudHobbies[i] + ",");
            }

            Console.WriteLine("\n");

            return 0;
        }
    }
}
