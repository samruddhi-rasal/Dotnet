namespace  TFLCollections;

class Program
{
   
   public static void Main(string [] args)
    {
        LinkedList list=new LinkedList();
        int choice;

            do
            {
                Console.WriteLine("\n----- Linked List Menu -----");
                Console.WriteLine("1. Create Linked List");
                Console.WriteLine("2. Display Linked List");
                Console.WriteLine("3. Update Node");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                     Console.Write("Enter the number of nodes: ");
                    int n = int.Parse(Console.ReadLine());

                    for (int i = 1; i <= n; i++)
                    {

                        Console.WriteLine("Enter the data to insert");
                        int data = int.Parse(Console.ReadLine());

                        list.Insert(data);
                    }  
                        Console.WriteLine("Linked List Created Successfully.");
                        break;

                    case 2:
                        Console.WriteLine("Linked List:");
                        list.Traverse();
                        break;

                    case 3:
                        Console.Write("Enter value to update: ");
                        int oldValue = int.Parse(Console.ReadLine());

                        Console.Write("Enter new value: ");
                        int newValue = int.Parse(Console.ReadLine());

                        list.Update(oldValue, newValue);
                        break;

                    case 4:
                        Console.WriteLine("Exiting...");
                        break;

                    default:
                        Console.WriteLine("Invalid Choice!");
                        break;
                }

            } while (choice != 4);
        }


    
    }
   

