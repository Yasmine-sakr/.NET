Task 2 – OOP Assignment in C#
Part 1: Basic Concepts
1. Class & Object
What is a Class?
A class is a blueprint or template for creating objects.
It defines the properties and methods that the objects will have.
What is an Object?
An object is an instance of a class.
It has its own data and can use the methods defined in the class.
Student Class
The Student class contains three properties: Name, Age, and GPA. These properties store the student’s name, age, and grade point average.
using System;
using System;
class Student
{
    public string Name { get; set; }
 public int Age { get; set; }
 public double GPA { get; set; }
}
class Program
{ 
    static void Main() {
        Student student1 = new Student();
        student1.Name = "Yasmine"; 
        student1.Age = 21;
        student1.GPA = 3.5;
    Student student2 = new Student();
    student2.Name = "Sakr";
    student2.Age = 47;
    student2.GPA = 4;

    Console.WriteLine("Student 1:");
    Console.WriteLine("Name:" + student1.Name);
    Console.WriteLine("Age:" + student1.Age);
    Console.WriteLine("GPA: " + student1.GPA);

    Console.WriteLine("Student 2:");
    Console.WriteLine("Name:" + student2.Name);
    Console.WriteLine("Age:" + student2.Age);
    Console.WriteLine("GPA: " +student2.GPA);
}
}
 
Explanation
class Student defines the Student class.
Name, Age, and GPA are properties that store student information.
new Student() creates a new object from the Student class.



2. Why OOP?
Why do we need OOP?
We need OOP to organize our code into classes and objects. It makes programs easier to understand, maintain, and develop.
Three Advantages of OOP
1. Code Reusability: We can reuse existing code instead of writing it again.
2. Organization: We can organize our code into classes, making it easier to understand and manage.
3. Maintainability: We can update or fix parts of the code more easily without changing the entire program.
How does OOP help us organize and reuse code?
OOP helps us organize code by grouping related data and methods inside classes.
It also allows us to create multiple objects from the same class and reuse code through inheritance.
This reduces code duplication and makes programs easier to maintain.
student1 and student2 are two separate objects.
Console.WriteLine() prints the students’ information.
