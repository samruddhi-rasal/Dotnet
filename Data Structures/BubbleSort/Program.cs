
using System;

class Program
{
    static void Main()
    {
        int [] myArray = { 64, 34, 25, 12, 22, 11, 90 };
        int n = myArray.Length;

        for(int i=0; i<n-1; i++)
        {
            for (int j = 0; j<n-i-1; j++)
            {
                if(myArray[j] > myArray[j + 1])
                {
                    //swap
                    int temp = myArray[j];
                    myArray[j] = myArray[j+1];
                    myArray[j+1] = temp;
                }
            }
            
        }
        Console.WriteLine("Sorted array: ");
        foreach(int num in myArray)
        {
            Console.Write(num + " ");
        }
    }
}