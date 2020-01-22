using System;

namespace Queue_LinkedList
{

    internal class Node
    {
        internal int data;
        internal Node next;

        public Node(int d)
        {
            data = d;
            next = null;
        }
    }

    internal class LinkListQueue
    {
        Node head;
        Node tail;

        public LinkListQueue()
        {
            head = tail = null;
        }

        internal void Enqueue(int item)
        {
            Node newNode = new Node(item);

            if (tail == null)
            {
                head = tail = newNode;
            }

            else
            {
                tail.next = newNode;
                tail = newNode;
            }
            Console.WriteLine($"{item} inserted into Queue");
        }

        internal void Dequeue()
        {
            if (head == null)
            {
                Console.WriteLine("The Queue is empty");
                return;
            }

            Node temp = head; // Just to print the deleted elemnet

            head = head.next;

            if (head == null)
            {
                tail = null;
            }

            Console.WriteLine("Item deleted is {0}", temp.data);
        }
    }


    
}
