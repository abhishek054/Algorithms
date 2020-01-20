using System;

namespace Stack_Array
{
    internal class Stack
    {
        static readonly int MAX = 1000;
        int top;
        readonly int[] stack = new int[MAX];

        bool IsEmpty()
        {
            return (top < 0);
        }

        public Stack()
        {
            top = -1;
        }

        internal bool Push(int data)
        {
            if (top >= MAX)
            {
                Console.WriteLine("Stack Overflow");
                return false;
            }
            else
            {
                stack[++top] = data;
                return true;
            }
        }

        internal int Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack Underflow");
                return 0;
            }
            else
            {
                int value = stack[top--];
                return value;
            }
        }

        internal void Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack Underflow");
                return;
            }
            else
                Console.WriteLine("The topmost element of Stack is : {0}", stack[top]);
        }

        internal void PrintStack()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return;
            }
            else
            {
                Console.WriteLine("Items in the Stack are :");
                for (int i = top; i >= 0; i--)
                {
                    Console.WriteLine(stack[i]);
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Stack stack = GetStack();
            stack.Peek();
            Console.WriteLine("Item popped from Stack : {0}", stack.Pop());
            stack.PrintStack();
        }

        static Stack GetStack()
        {
            Stack stack = new Stack();

            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Push(40);

            stack.PrintStack();

            return stack;
        }
    }
}
