﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinkedList
{
    public class LinkedLists
    {
        internal Node head;
        internal void Add(int data)                     // Add method for inserting 56, 30, 70 into LinkedList 
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into linked list", node.data);
        }
        internal void AddInReverseOrder(int data)      // Add method for Reverse the order of created Linked List
        {
            Node newNode = new Node(data);
            if (this.head == null)
            {
                this.head = newNode;
            }
            else
            {
                Node temp = this.head;                  //70
                head = newNode;                         //30
                head.next = temp;                       //30->70
            }
        }
        public void Appending(int data)                
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node node1 = head;
                while (node1.next != null)
                {
                    node1 = node1.next;
                }
                node1.next = node;
            }
            Console.WriteLine("{0} appended into linked list", node.data);
        }
        public Node InsertAtRequiredPosition(int position, int data)           // Ability to insert 30 between 56 and 70
        {
            Node node = new Node(data);
            if (position < 1)
            {
                Console.WriteLine("Invalid Position");
            }
            else if (position == 1)
            {
                node.next = head;
                head = node;
            }
            else
            {
                Node temp = head;
                while (position > 2)
                {
                    temp = temp.next;
                    position--;
                }
                node.next = temp.next;
                temp.next = node;
            }
            Console.WriteLine("{0} Insert At Required Position into linked list", node.data);
            return head;
        }
        public Node DeletingFirstPosition()            // Deletiong the First Position element form Linked List by using pop methord
        {
            Node node = head;
            if (head == null)
            {
                Console.WriteLine("Linked List is empty: ");
            }
            else
            {
                head = head.next;
            }
            Console.WriteLine("{0} is the Deleted first Position element from linked list", node.data);
            return node;
        }
        public void DeletingLastPosition()              // Deletiong the Last Position element form Linked List by using pop methord
        {
            if (head == null)
            {
                Console.WriteLine("Linked List is empty");
            }
            else
            {
                Node n = head;
                while (n.next.next != null)
                {
                    n = n.next;
                }
                Node removeNode = n.next;
                n.next = null;
                Console.WriteLine("{0} is the Deleted Last Position element from linked list", removeNode.data);
            }
        }
        public int Search(int data)
        {
            int count = 1;
            Node temp = head;
            if (this.head == null)
            {
                return 0;
            }
            while (temp != null)
            {
                if (temp.data == data)
                {
                    return count;
                }
                temp = temp.next;
                count++;
                Console.WriteLine("{0} is the available in linked list", temp.data);
            }
            return 0;
        }
        internal void Display()    // Adding method for Display
        {

            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("linked list is empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + " currently available elements in list ");
                temp = temp.next;
            }
        }
        
    }
}
