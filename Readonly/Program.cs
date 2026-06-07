using System;
class Student{
    readonly int id;
    public Student(int x){
        id=x;
    }
    public void Display(){
        Console.WriteLine(id);
    }
}
class Program{
    static void Main(){
        Student s1 = new Student(101);
        s1.Display();
        Student s2 = new Student(102);
        s2.Display();
    }
}    
