using System;

public class Course
{
    public int CourseId { get; set; }
    public string CourseName { get; set; }
    public int Duration { get; set; }

    public Instructor AssignedInstructor { get; set; }

    public Course(int id, string name, int duration)
    {
        CourseId = id;
        CourseName = name;
        Duration = duration;
    }

    public void DisplayCourse()
    {
        Console.WriteLine($"Course ID: {CourseId}");
        Console.WriteLine($"Course Name: {CourseName}");
        Console.WriteLine($"Duration: {Duration} Days");

        if (AssignedInstructor != null)
            Console.WriteLine($"Instructor: {AssignedInstructor.Name}");

        Console.WriteLine();
    }
}