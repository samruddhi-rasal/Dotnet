using System.Collections.Generic;

public class LMSService
{
    public List<Student> Students = new List<Student>();
    public List<Instructor> Instructors = new List<Instructor>();
    public List<Course> Courses = new List<Course>();

    // Compile Time Polymorphism

    public void AddCourse(string name)
    {
        System.Console.WriteLine($"Course Added : {name}");
    }

    public void AddCourse(string name, int duration)
    {
        System.Console.WriteLine($"Course Added : {name} Duration : {duration}");
    }
}