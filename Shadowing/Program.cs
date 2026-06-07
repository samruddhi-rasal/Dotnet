using Shadowing;
class Program
{
    public static void Main(string[] args){
        Parent parent = new Parent();
        parent.Show(); // Output: Parent

        Child child = new Child();
        child.Show(); // Output: Child

        Parent parentRefChild = new Child();
        parentRefChild.Show(); // Output: Parent (because of method hiding)
     }
}
