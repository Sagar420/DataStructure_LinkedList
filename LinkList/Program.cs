using System;

namespace LinkList
{
    class Node {
        public int data;
        public Node next;

        public Node(int k)
        {
            data = k;
            next = null;
        }
    }

    class LinkedList
    {
        private Node start=null;
        public Boolean empty()
        {
            if (start == null) return true;
            else return false;
        }

        public void create(int n)
        {
            Node p, q;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter data");
                int ele = Convert.ToInt32(Console.ReadLine());
                p = new Node(ele);
                if (start == null) start = p;
                else
                {
                    q = start;
                    while (q.next != null) q = q.next;
                    q.next = p;
                }
            }
        }

        public void display()
        {
            Node q = start;
            while(q!=null)
            {
                Console.Write(q.data + " ");
                q = q.next;
                
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter no of element to create");
            int ele = Convert.ToInt32(Console.ReadLine());
            LinkedList obj = new LinkedList();
            obj.create(ele);
            obj.display();
            Console.Read();
        }
    }
}
