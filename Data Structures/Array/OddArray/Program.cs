// //Print only odd numbers.

// using System;

// class Program
// {
//     static void Main()
//     {
//         int[] numbers = { 10, 15, 20, 25, 30, 35, 40 };

//         foreach (int num in numbers)
//         {
//             if (num % 2 != 0)
//             {
//                 Console.WriteLine(num);
//             }
//         }
//     }
// }

// using System;
// class Program
// {
//     static void Main()
//     {
//         int[] arr = {1, -2, 3, -4, 5 };
        
//         for(int i=0; i<arr.Length; i++)
//         {
//             if (arr[i] > 0)
//             {
//                 Console.WriteLine(arr[i]);
//             }
//         }
//     }
// }

using System;

class Program
{
    static void Main()
    {
        int[] arr = {10,20,30,40,50};
        
        int smallest = arr[0];

        foreach(int num in arr)
        {
            if (num < smallest)
            {
                smallest=num;
            }
        }
            Console.WriteLine("Smallest Number:" + smallest);
        
    }
}