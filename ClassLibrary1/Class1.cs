namespace ClassLibrary1;
public class College
{
    List<Prof> _profs;
    List<Stud> _studs;
    public string Name { get; set; }

    public College(string name)
    {
        Name = name;
        _profs = new List<Prof>();
        _studs = new List<Stud>();
    }

    public override string ToString()
    {
        return "Name: " + Name + PrintLists();
    }

    public string PrintLists()
    {
        string profString = "";
        string studString = "";

        _profs.ForEach(p => profString += p.ToString());
        _studs.ForEach(s => studString += s.ToString());

        return "\nProfs: [" + profString + "]\nStuds: [" + studString + "]";
    }

    public void AddProf(Prof p)
    {
        p.ResidingCollege = Name;
        _profs.Add(p);
    }

    public void AddStud(Stud s)
    {
        s.ResidingCollege = Name;
        _studs.Add(s);
    }
}

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

public class Prof : Person
{
    public string TeachingSubject { get; set; }
    public string ResidingCollege = "";

    public Prof(string name, int age, string teachingSubject)
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

public class Stud : Person, IHobbies
{
    public string Group { get; set; }
    public string ResidingCollege = "";
    public List<string> StudHobbies { get; set; }
    public Stud(string name, int age, string group, List<string> studHobbies)
    {
        _name = name;
        _age = age;
        Group = group;
        StudHobbies = studHobbies;
    }

    public Stud(string name, int age, string group)
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
        if (!StudHobbies.Any()) { 
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

