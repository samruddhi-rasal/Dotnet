using LinkedList.List;

class Program
{

    public static void Main(string[] args)
    {
        linkedlist linked = new linkedlist();
        // Add Node at End

        
        linked.AddNodeEnd(1);
        linked.AddNodeEnd(2);
        linked.AddNodeEnd(3);
        linked.AddNodeEnd(4);
        linked.AddNodeEnd(5);
        Console.WriteLine("Final LinkedList: ");
        linked.display();


        // // Add Node at First
        // linked.AddNodeFirst(6);
        // Console.WriteLine("\nFinal LinkedList: ");
        // linked.display();

        // Add Node at middle
        linked.AddNodeMiddle(10,2);
        Console.WriteLine("\nFinal LinkedList: ");
        linked.display();

    //     //   delete Node at end
    //     linked.DeleteFromEnd();
    //     Console.WriteLine("\nFinal LinkedList: ");
    //     linked.display();

    // // delete Node at First
    //     linked.DeleteFromFirst();
    //     Console.WriteLine("\nFinal LinkedList: ");
    //     linked.display();

    // // delete Node at middle
    //     linked.DeleteFromMiddle(4);
    //     Console.WriteLine("\nFinal LinkedList: ");
    //     linked.display();


       
    }

}