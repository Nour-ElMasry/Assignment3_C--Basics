using ProfessorNS;
using StudentNS;


namespace CollegeNS;
public class College : ICloneable
{
    List<Professor> _profs;
    List<Student> _studs;
    public string Name { get; set; }

    public College(string name)
    {
        Name = name;
        _profs = new List<Professor>();
        _studs = new List<Student>();
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

    public void AddProf(Professor p)
    {
        p.ResidingCollege = Name;
        _profs.Add(p);
    }

    public void AddStud(Student s)
    {
        s.ResidingCollege = Name;
        _studs.Add(s);
    }

    public object Clone()
    {
        College c = new College(Name);
        _profs.ForEach(p => c.AddProf(p));
        _studs.ForEach(s => c.AddStud(s));

        return c;
    }
}


