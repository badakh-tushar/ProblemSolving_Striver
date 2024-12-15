using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_Striver
{
    public class LinkedList<T>
    {
       Node<T> head;
       public LinkedList()
        {
            head = null;
        }

        public void InsertLast(T data)
        {
            Node<T> newNode = new Node<T>(data);    
            if (head == null)
            {
                head = newNode;
                return;
            }

            Node<T> current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;

        }

        public void AtIndexInsertNode(int index,T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (index == 0)
            {
                newNode.Next = head;
                head= newNode;
                return;
            }

            Node<T> current = head;
            int count = 0;
            while(count < index)
            {
                count++;
                current = current.Next;
            }
            newNode.Next = current.Next;
            current.Next = newNode;
        }
        public void DeleteNodeBydata(T data)
        {
            Node<T> current = head;
            Node<T> prev = head;
            if (head.Data.Equals(data))
            {
                head = head.Next;
            }

            while (current.Next != null)
            {
                if (current.Data.Equals(data))
                {
                    prev.Next = current.Next;
                    break;
                }
                prev = current;
                current = current.Next;
            }
            if (current.Data.Equals(data))
            {
                prev.Next = current.Next;
            }
        }

        public void Display()
        {
            Node<T> current = head;
            while (current.Next != null)
            {
                Console.Write(current.Data + " ->");
                current = current.Next;
            }
            Console.Write(current.Data);
        }
    }
    public class Node<T>
    {
        public T Data;
        public Node<T> Next;

        public Node(T Data)
        {
            this.Data = Data;
            this.Next = null;
        }
                
    }

    
}
