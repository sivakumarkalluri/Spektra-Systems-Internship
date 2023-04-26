using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Program
    {


        //*****************  Creating Node  ***************
        class Node
        {
            public int data;
            public Node next;

            public Node(int data)
            {
                this.data = data;
                this.next = null;
            }


        }


        // ******************  Creating Linked List  **************
        class LinkedList
        {
            Node head ;
            Node tail;
            int length;

            public LinkedList()
            {
                head = null;
                tail = null;
                length = 0;
            }

            //************ Adding Node At Front *************
            public void AddNodeToFront(int data)
            {
                Node newNode = new Node(data);
                if (head == null)
                {
                    tail = newNode;
                }
                newNode.next = head;
                head = newNode;

                if (head == null)
                {
                    tail = head;
                }

                length++;

            }


            //************ Adding Node At End *************

            public void AddNodeToEnd(int data)
            {
                Node newNode = new Node(data);
                tail.next = newNode;
                tail = newNode;

                length++;

            }


            //************ Delete Node At Front  ****************

            public void deleteNodeAtFront()
            {
                Console.WriteLine("  **** Deleted Node At Front ***** \n");

                Node temp = head;
                head = head.next;
                temp.next = null;
                length--;
            }


            //************ Delete Node At End ****************
            public void deleteNodeAtEnd()
            {
                Console.WriteLine("  **** Deleted Node At End **** \n");
                Node current = head;
                while (current.next.next != null)
                {
                    current = current.next;
                }
                current.next = null;
                length--;
            }


            //************ Displaying LinkedList ****************
            public void display()
            {
                Node current = head;
                Console.WriteLine("The Linked List you provided is \n");
                while (current != null)
                {
                    Console.Write(current.data+" -> ");
                   
                    current = current.next;
                }
                Console.WriteLine("\n\n");
                
            }


        }
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.AddNodeToFront(3);
            list.AddNodeToFront(1);
            list.AddNodeToFront(5);
            list.AddNodeToFront(7);
            list.AddNodeToFront(9);
            list.AddNodeToEnd(2);

            list.display();
            list.deleteNodeAtFront();
            list.display();
            list.deleteNodeAtEnd();
            list.display();


            //string[] empID = { "Siva","Pankaj","Deepali"};
            //Console.WriteLine("Displaying elements of a Linked List: ");
            //LinkedList<string> myList = new LinkedList<string>(empID);
           

            //myList.AddFirst("Manoj");
            //myList.AddLast("Kumar");

            //Console.WriteLine("Displaying elements of a Linked List: ");
            //foreach (var res in myList)
            //{
            //    Console.WriteLine(res);
            //}

            //myList.RemoveFirst();
            //myList.RemoveLast();

            //Console.WriteLine("Displaying elements of a Linked List: ");
            //foreach (var res in myList)
            //{
            //    Console.WriteLine(res);
            //}



        }
    }
} 
