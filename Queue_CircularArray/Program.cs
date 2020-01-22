using System;

namespace Queue_CircularArray
{
    class Queue
    {
        private int[] element;
        private int front;
        private int rear;
        private readonly int size;

        public Queue(int size)
        {
            element = new int[size];
            front = -1;
            rear = -1;
            this.size = size;
        }

        public void Enqueue(int item)
        {
            if (IsFull())
                return;

            else if (IsEmpty())
            {
                front = rear = 0;
                element[rear] = item;
                return;
            }

            rear = (rear + 1) % size;
            element[rear] = item;
        }

        public int Dequeue()
        {
            if (IsEmpty())
                return default(int);

            else if (front == rear)
            {
                Console.WriteLine(element[front] + " dequeued from queue");
                int deletedElement = element[front];
                front = rear = -1;
                Console.WriteLine("Queue is empty now");
                return deletedElement;
            }

            else
            {
                Console.WriteLine(element[front] + " dequeued from queue");
                int deletedElement = element[front];
                front = (front + 1) % size;
                Console.WriteLine();
                Console.WriteLine("Front item is {0}", element[front]);
                Console.WriteLine("Rear item is {0} ", element[rear]);
                return deletedElement;
            }
        }

        public bool IsEmpty()
        {
            if (front == -1 && rear == -1)
                return true;

            return false;
        }

        public bool IsFull()
        {
            if ((rear + 1) % size == front)
            {
                Console.WriteLine("Queue Overflow");
                return true; ;
            }

            return false;
        }

        public void PrintQueue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is Empty");
                return;
            }

            for (int i = front; i <= rear; i++)
            {
                if (i == rear)
                {
                    Console.WriteLine(element[i] + " -> ");
                }
                else
                {
                    Console.Write(element[i] + " -> ");
                }
            }

        }
    }

    class Program
    {
        static void Main()
        {
            Queue Q = new Queue(5);

            Q.Enqueue(10);
            Q.Enqueue(20);
            Q.Enqueue(30);
            Q.Enqueue(40);
            Q.PrintQueue();
            Q.Dequeue();
            Q.Dequeue();
            Q.PrintQueue();
        }
    } 
}
