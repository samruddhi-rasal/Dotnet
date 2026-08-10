using System;
using System.IO.Compression;
class Stack
{
    int[] arr = new int[5];
    int top = -1;

    public void Push(int value)
    {
        if (top == arr.Length - 1)
        {
            Console.WriteLine("Stack OverFlow");
            return;
        }
        top++;
        arr[top] = value;
    }
    public void Pop()
    {
        if (top == -1)
        {
            Console.WriteLine("Stack Underflow");
            return;
        }
        Console.WriteLine("Removed:" + arr[top]);
        top--;
    }
    public void Peek()
    {
        if (top == -1)
        {
            Console.WriteLine("Stack is Empty");
            return;
        }
        Console.WriteLine("Top:" + arr[top]);
    }

    // Display
    public void Display()
    {
        if (top == -1)
        {
            Console.WriteLine("Stack is Empty");
            return;
        }

        for (int i = top; i >= 0; i--)
        {
            Console.WriteLine(arr[i]);
        }
    }
}



class Program
{
    static void Main()
    {
        Stack stack = new Stack();
        stack.Push(10);
        stack.Push(20);
        stack.Push(30);

        Console.WriteLine("Stack:");
        stack.Display();

        Console.WriteLine("\nPeek:");
        stack.Peek();

        Console.WriteLine("\nPop:");
        stack.Pop();

        Console.WriteLine("\nStack after Pop:");
        stack.Display();
    }
}