using System;

class Node
{
    public int data;
    public Node? next;

    public Node(int value)
    {
        data=value;
        next=null;
    }
}
class Program
{
    static void Main()
    {
        Node first=new Node(10);
        Node second = new Node(20);
        Node third = new Node(30);
        Node fourth = new Node(40);

        first.next = second;
        second.next = third;
        third.next = fourth;
        fourth.next = first;
        
        //Display using loop
        Node temp = first;
        do
        {
            Console.Write(temp.data + " ");
            temp = temp.next;
        }
        while(temp != first);

        Console.Write(temp.data);
        Console.WriteLine("Circular Linked List created");
    }
}