
using System;

class Program
{
    static void Main()
    {
        LMSService lms = new LMSService();

        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\n========= LMS MAIN MENU =========");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Add Instructor");
            Console.WriteLine("3. Add Course");
            Console.WriteLine("4. Enroll Student in Course");
            Console.WriteLine("5. Assign Instructor to Course");
            Console.WriteLine("6. View All Students");
            Console.WriteLine("7. View All Instructors");
            Console.WriteLine("8. View All Courses");
            Console.WriteLine("9. Send Notification");
            Console.WriteLine("10. Show Configuration");
            Console.WriteLine("11. Exit");
            Console.Write("Enter Choice: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:

                    Console.Write("Student ID: ");
                    int sid = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Student Name: ");
                    string sname = Console.ReadLine();

                    lms.Students.Add(new Student(sid, sname));

                    Console.WriteLine("Student Added Successfully");
                    break;

                case 2:

                    Console.Write("Instructor ID: ");
                    int iid = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Instructor Name: ");
                    string iname = Console.ReadLine();

                    lms.Instructors.Add(new Instructor(iid, iname));

                    Console.WriteLine("Instructor Added Successfully");
                    break;

                case 3:

                    Console.Write("Course ID: ");
                    int cid = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Course Name: ");
                    string cname = Console.ReadLine();

                    Console.Write("Duration: ");
                    int duration = Convert.ToInt32(Console.ReadLine());

                    lms.Courses.Add(new Course(cid, cname, duration));

                    Console.WriteLine("Course Added Successfully");
                    break;

                case 4:

                    Console.Write("Enter Student ID: ");
                    int studentId = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter Course ID: ");
                    int courseId = Convert.ToInt32(Console.ReadLine());

                    Student student =
                        lms.Students.Find(s => s.Id == studentId);

                    Course course =
                        lms.Courses.Find(c => c.CourseId == courseId);

                    if (student != null && course != null)
                    {
                        student.EnrollCourse(course);
                        Console.WriteLine("Enrollment Successful");
                    }
                    else
                    {
                        Console.WriteLine("Invalid IDs");
                    }

                    break;

                case 5:

                    Console.Write("Instructor ID: ");
                    int instructorId =
                        Convert.ToInt32(Console.ReadLine());

                    Console.Write("Course ID: ");
                    int assignCourseId =
                        Convert.ToInt32(Console.ReadLine());

                    Instructor instructor =
                        lms.Instructors.Find(i => i.Id == instructorId);

                    Course assignedCourse =
                        lms.Courses.Find(c => c.CourseId == assignCourseId);

                    if (instructor != null && assignedCourse != null)
                    {
                        instructor.AssignCourse(assignedCourse);
                        assignedCourse.AssignedInstructor = instructor;

                        Console.WriteLine("Instructor Assigned");
                    }

                    break;

                case 6:

                    foreach (Student s in lms.Students)
                    {
                        s.DisplayInfo();
                    }

                    break;

                case 7:

                    foreach (Instructor i in lms.Instructors)
                    {
                        i.DisplayInfo();
                    }

                    break;

                case 8:

                    foreach (Course c in lms.Courses)
                    {
                        c.DisplayCourse();
                    }

                    break;

                case 9:

                    Console.WriteLine("1. Email");
                    Console.WriteLine("2. SMS");

                    int type = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Message: ");
                    string msg = Console.ReadLine();

                    INotificationService service;

                    if (type == 1)
                    {
                        service = new EmailNotificationService();
                    }
                    else
                    {
                        service = new SmsNotificationService();
                    }

                    service.SendNotification(msg);

                    break;

                case 10:

                    LMSConfigurationManager config =
                        LMSConfigurationManager.GetInstance();

                    Console.WriteLine("\nInstitute Name : "
                                      + config.InstituteName);

                    Console.WriteLine("Version : "
                                      + config.Version);

                    Console.WriteLine("Admin Contact : "
                                      + config.AdminContact);

                    break;

                case 11:

                    exit = true;
                    Console.WriteLine("Thank You");
                    break;

                default:

                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }
    }
}