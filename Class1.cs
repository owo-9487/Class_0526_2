using System;

public class Person
{
    public Person()
    {
        Student s1 = new Student();
        Console.WriteLine(s1.GetName());
    }

    public class Student
    {
        public string GetName()
        {
            return "Student";
        }
    }
}