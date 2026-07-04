namespace  TFLCollections;

public  class LinkedList
{
    private Node head;
    public LinkedList()
    {
        head = null;
    }
    
    public void Insert(int data)
    {
         Node node = new Node(data);
        if (head == null)
        {
            head = node ;
        }

        else
        {
            Node current = head;
            while(current.next != null)
            {
                current =current.next;
            }

            current.next =node;
    }
}
    public void Remove(int data)
    {
       
        if (head == null)
        {
            Console.WriteLine("Can't remove");
        }

        else
        {
            Node current = head;
            while(current.next.next != null)
            {
                current =current.next;
            }

            current.next =null;
        }
        Console.Write("NULL");
    }
    
    public void Update(int oldData,int newData)
    {
        
        Node current = head;
         while(current != null)
        {
            if( current.value== oldData)
            {
                current.value= newData;
                
            }

            else
            {
                Console.WriteLine("Data Not Found");
            }

            current =current.next;
        }




    }
    
    public void Traverse()
    {
         Node current  = head;
            while (current != null)
            {
                Console.Write(current.value + "-->");
                current = current.next;
            }
        Console.Write("NULL");
    }

    // public void InsertAtFront()
    // {
    //     Node node = new Node(50);
    //     node.next = head;
    //     head = node ;
    
    // }

    // public void InsertAtEnd(int data)
    // {
    //     Node node = new Node(data);
    //     if (head == null)
    //     {
    //         head = node ;
    //     }

    //     else
    //     {
    //         Node current = head;
    //         while(current.next != null)
    //         {
    //             current =current.next;
    //         }

    //         current.next =node;
    //     }
    // }


    
}