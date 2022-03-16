using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinkedList
{
    public class MyLinkedList<T>
    {
        public Node<T>? Head;
        public int Size;
        public Node<T>? Last;
        public MyLinkedList()
        {
            Head = null;
            Size = 0;
            Last = null;

                
        }

        public void Add(T data)
        {
            var currentNode = new Node<T>(data);
            if (Head == null)
            {
                Head = currentNode;
            }
            else
            {
                Last.next = currentNode;
            }
            Last = currentNode;
            Size++;
        }

        public T Mth(int m)
        {
            if (Head == null)
            {
                throw new Exception("The linked list is empty");
            }
            if (m > this.Size - 1)
            {
                throw new Exception("Out of bounds of the List");
            }

            int counter = 1;
            var tempNode = Head;
            while (tempNode.next != null )
            {
                if (counter == Size - m)
                {
                    break;
                }
                counter++;  
                tempNode = tempNode.next;
            }
            return (T)tempNode.data;
        }

        public void ReverseWithIteration()
        {
            
            Node<T> previous = null;
            Node<T> next = null;
            Node<T> current = Head;
            
            Last = Head;
            
            while (current != null)
            {
                next = current.next;
                current.next = previous;
                previous = current;
                current = next;
            }
            Head = previous;


        }
        public Node<T> reverse(Node<T> node)
        {
            if (node == null)
            {
                return null;
            }

            
            if (node.next == null)
            {
                Head = node;
                return node;
            }
            var tempNode = reverse(node.next);
            tempNode.next = node;
            node.next = null;
            return node;

        }
        public void ReverseWithRecursion()
        {
            Last = Head;
            reverse(Head);
            
        }
    }
}
