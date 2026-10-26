using System;

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Name:" + Name);
        Console.WriteLine("Age: " + Age);
    }
}

class Student : Person
{
    public string StudentId { get; set; }

    public Student(string name, int age, string studentId)
        : base(name, age)
    {
        StudentId = studentId;
    }

    public void Study()
    {
        Console.WriteLine(Name + " is studying.");
    }
}

class Instructor : Person
{
    public string Subject { get; set; }

    public Instructor(string name, int age, string subject)
        : base(name, age)
    {
        Subject = subject;
    }

    public void Teach()
    {
        Console.WriteLine(Name + " is teaching " + Subject + ".");
    }
}

class Program
{
    static void Main()
    {
        Student student = new Student("Yasmine", 21, "Y1sm3n");

        Console.WriteLine("Student Information:");
        student.DisplayInfo();
        Console.WriteLine("Student ID: " + student.StudentId);
        student.Study();

        Console.WriteLine();

        Instructor instructor = new Instructor("Sakr", 47, "C#");
        Console.WriteLine("Instructor Information:");
        instructor.DisplayInfo();
        Console.WriteLine("Subject: " + instructor.Subject);
        instructor.Teach();
    }
}
