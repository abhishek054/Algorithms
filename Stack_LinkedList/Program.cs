using System;

namespace Stack_LinkedList
{
    public class Stack_Linkedlist
    {

        private class Node
        {
            public int data;

            public Node link;
        }

        Node top;

        public Stack_Linkedlist()
        {
            this.top = null;
        }

        public void push(int x)
        {
            Node temp = new Node();

            if (temp == null)
            {
                Console.Write("\nStack Overflow");
                return;
            }

            temp.data = x;

            temp.link = top;

            top = temp;
        }

        public bool isEmpty()
        {
            return top == null;
        }

        public int peek()
        {
            // check for empty stack  
            if (!isEmpty())
            {
                return top.data;
            }
            else
            {
                Console.WriteLine("Stack is empty");
                return -1;
            }
        }

        public void pop()
        {
            if (top == null)
            {
                Console.Write("\nStack Underflow");
                return;
            }

            top = (top).link;
        }

        public void display()
        {
            // check for stack underflow  
            if (top == null)
            {
                Console.Write("\nStack Underflow");
                return;
            }
            else
            {
                Node temp = top;
                while (temp != null)
                {

                    // print node data  
                    Console.Write("{0}->", temp.data);

                    // assign temp link to temp  
                    temp = temp.link;
                }
            }
        }
    }
    class Program
    {
        public static void Main(String[] args)
        {
            Stack_Linkedlist obj = new Stack_Linkedlist();

            obj.push(11);
            obj.push(22);
            obj.push(33);
            obj.push(44);

            obj.display();
            Console.Write("\nTop element is {0}\n", obj.peek());

            obj.pop();
            obj.pop();

            obj.display();

            Console.Write("\nTop element is {0}\n", obj.peek());
        }
    }
}


