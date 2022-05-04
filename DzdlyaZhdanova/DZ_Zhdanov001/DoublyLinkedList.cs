using System;
using System.Collections.Generic;
using System.Text;

namespace DzdlyaZhdanova
{
    class DoublyLinkedList <T> : iLinkedList<T>
    {
        private DoublyNode<T> head;
        private DoublyNode<T> tail;
        public int count { get; private set; }
        public DoublyNode<T> tailNext { get; private set; }

        public void AddNode(T data)
        {
            DoublyNode<T> newNode = new DoublyNode<T>();
            newNode.Data = data;
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                newNode.Previous = tail;
                tail.Next = newNode;
            }
            tail = newNode;
            count++;
        }

        public void AddFirst(T data)
        {
            DoublyNode<T> newNode = new DoublyNode<T>();
            newNode.Data = data;
            DoublyNode<T> temp = head;
            head = newNode;
            if (count == 0)
            {
                tail = head;
            }
            else
            {
                temp.Previous = newNode;
            }
            count++;
        }

        public override string ToString()
        {
            string list = "";
            DoublyNode<T> current = head;
            while (current != null)
            {
                list += $"<-|{current.Data}|->";
                current = current.Next;
            }
            return list;
        }

        public int GetCount()
        {
            return count;
        }

        public void Clear()
        {
            Console.Clear();
        }
    }
}
