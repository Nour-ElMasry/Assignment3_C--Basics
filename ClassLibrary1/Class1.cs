namespace ClassLibrary1;
public class College
{
    List<Prof> Profs;
    List<Stud> Studs;
    public string Name { get; set; }

    public College(string name)
    {
        Name = name;
        Profs = new List<Prof>();
        Studs = new List<Stud>();
    }

    public override string ToString()
    {
        return "Name: " + Name + PrintLists();
    }

    public string PrintLists()
    {
        string profString = "";
        string studString = "";

        Profs.ForEach(p => profString += p.ToString());
        Studs.ForEach(s => studString += s.ToString());

        return "\nProfs: [" + profString + "]\nStuds: [" + studString + "]";
    }

    public void AddProf(Prof p)
    {
        p.ResidingCollege = Name;
        Profs.Add(p);
    }

    public void AddStud(Stud s)
    {
        s.ResidingCollege = Name;
        Studs.Add(s);
    }
}

public abstract class Person : IPerson
{
    public string Name;
    public int Age;

    public abstract void About();
    public void Intro()
    {
        Console.WriteLine("Hi, my name is " + Name + "! I am " + Age + " years old.");
    }
}

public interface IPerson
{
    void Intro();
}

public class Prof : Person
{
    public string TeachingSubject { get; set; }
    public string ResidingCollege = "";

    public Prof(string name, int age, string teachingSubject)
    {
        Name = name;
        Age = age;
        TeachingSubject = teachingSubject;
    }

    public override string ToString()
    {
        return "{ Name: " + Name + ", Age: " + Age + ", TeachingSubject: " + TeachingSubject + " }, ";
    }

    public override void About()
    {
        Intro();
        Console.WriteLine("I am a professor at " + ResidingCollege);
    }
}

public class Stud : Person
{
    public string Group { get; set; }
    public string ResidingCollege = "";

    public Stud(string name, int age, string group)
    {
        Name = name;
        Age = age;
        Group = group;
    }

    public override string ToString()
    {
        return "{ Name: " + Name + ", Age: " + Age + ", Group: " + Group + " }, ";
    }

    public override void About()
    {
        Intro();
        Console.WriteLine("I am a student at " + ResidingCollege);
    }
}

