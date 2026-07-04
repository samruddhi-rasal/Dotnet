using LinkedList.CreateNode;

namespace LinkedList.List
{
    public class linkedlist
    {
        Node head = null;


        public void AddNodeEnd(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node p = head;
                while (p.next != null)
                {
                    p = p.next;
                }

                p.next = node;

            }
        }

        public void AddNodeMiddle(int data,int loc)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node p = head;
                int traverseIndex=1;
                while (traverseIndex != loc-1)
                {
                    p = p.next;
                    traverseIndex++;
                }
                node.next= p.next;
                p.next=node;

            }
        }

        public void AddNodeFirst(int data)
        {
            Node node = new Node(data);
            node.next = head;
            head = node;
        }

        public void display()
        {
            Node p = head;
            while (p != null)
            {
                Console.Write(p.data + "-->");
                p = p.next;
            }
        }

        public void DeleteFromEnd()
        {
            Node current = head;
            while (current.next.next != null)
            {
                current = current.next;
            }
            current.next = null;

        }

        public void DeleteFromFirst()
        {
            head = head.next;

        }

        public void DeleteFromMiddle(int data)
        {
            Node current = head;
            while (current.next.data != data)
            {
                current = current.next;
            }
            current.next = current.next.next;

        }


    }

}