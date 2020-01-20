using System;

namespace DoublyLinkedList
{
    internal class DNode
    {
        internal int data;
        internal DNode prev;
        internal DNode next;
        public DNode(int d)
        {
            data = d;
            prev = null;
            next = null;
        }
    }

    internal class DoublyLinkedList
    {
        internal DNode head;

        internal void InsertFront(DoublyLinkedList list, int data)
        {
            DNode newNode = new DNode(data);
            newNode.next = list.head;
            newNode.prev = null;
            if (list.head != null)
            {
                list.head.prev = newNode;
            }
            list.head = newNode;
        }

        internal void InsertLast(DoublyLinkedList list, int data)
        {
            DNode newNode = new DNode(data);
            if (list.head == null)
            {
                newNode.prev = null;
                list.head = newNode;
                return;
            }
            DNode lastNode = GetLastNode(list);
            lastNode.next = newNode;
            newNode.prev = lastNode;
        }

        internal DNode GetLastNode(DoublyLinkedList list)
        {
            DNode temp = list.head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }

        internal void InsertAfter(DNode prevNode, int data)
        {
            if (prevNode == null)
            {
                Console.WriteLine("The given prevoius node cannot be null");
                return;
            }
            DNode newNode = new DNode(data);
            newNode.next = prevNode.next;
            prevNode.next = newNode;
            newNode.prev = prevNode;
            if (newNode.next != null)
            {
                newNode.next.prev = newNode;
            }
        }

        internal void DeleteNodebyKey(DoublyLinkedList list, int key)
        {
            DNode temp = list.head;
            if (temp != null && temp.data == key)
            {
                list.head = temp.next;
                list.head.prev = null;
                return;
            }
            while (temp != null && temp.data != key)
            {
                temp = temp.next;
            }
            if (temp == null)
            {
                return;
            }
            if (temp.next != null)
            {
                temp.next.prev = temp.prev;
            }
            if (temp.prev != null)
            {
                temp.prev.next = temp.next;
            }
        }
    }

    


}
