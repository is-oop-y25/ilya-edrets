namespace Isu.Entities;

public class Student
{
    public Student(int id, string firstName, string lastName)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
    }

    public Student(string firstName, string lastName)
        : this(0, firstName, lastName)
    {
    }

    public int Id { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public DateTime DateBirth { get; set; }

    public object? Group { get; set; }

    public override string ToString()
    {
        return FirstName + " " + LastName;
    }
}
