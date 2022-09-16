using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class LinkedListQueue
    {
        private Node top;               //Create a Queue
        private Node head;
        public LinkedListQueue()
        {
            this.top = null;
        }
        internal void Enqueue(int value)                //Enqueue Opeartion of the list
        {
            Node node = new Node(value);
            if (this.top == null)
            {
                node.next = null;
            }
            else
            {
                node.next = this.top;
            }
            this.top = node;
            Console.WriteLine("{0} pushed to queue", value);
        }
        internal void Dequeue()                                 //Dequeue operation of the list
        {
            if (this.head == null)
            {
                Console.WriteLine("queue is empty,Deletion is not possible");
                return;
            }
            else
            {
                while (this.head != null)
                {
                    Console.WriteLine("valye Dequeue is {0}", this.head.data);
                    this.head = this.head.next;
                }
            }
        }
        internal void Display()
        {
            Node temp = this.top;
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}
