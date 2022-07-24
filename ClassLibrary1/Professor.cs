using PersonNS;

namespace ProfessorNS
{
    public class Professor : Person
    {
        public string TeachingSubject { get; set; }
        public string ResidingCollege = "";

        public Professor(string name, int age, string teachingSubject)
        {
            _name = name;
            _age = age;
            TeachingSubject = teachingSubject;
        }

        public override string ToString()
        {
            return "{ Name: " + _name + ", Age: " + _age + ", TeachingSubject: " + TeachingSubject + " }, ";
        }

        public override void About()
        {
            Intro();
            Console.WriteLine("I am a professor at " + ResidingCollege);
        }
    }

}
