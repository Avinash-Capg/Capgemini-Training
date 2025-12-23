public class Student
{
    int rollno;
    string name;
    string addr;

    /// <summary>
    /// Default constructor of Student class
    /// </summary>
public Student()
    {
        rollno = 0;
        name = "Dummy";
        addr = "Dummy city";
    }

    // Parameterized constructor
    public Student(int id, string name, string city)
    {
        rollno = id;
        this.name = name;
        addr = city;
    }
    public void DisplayDetails(Student s1)
      {
        Console.WriteLine("Roll No: " + s1.rollno);
        Console.WriteLine("Name: " + s1.name);
        Console.WriteLine("Address: " + s1.addr);
    }
}