using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chisenoa
{
    class DoublyLinkedList
    {
        static void Main(String[] args)
        {
            linkedList list = new linkedList();

            Console.WriteLine("Doubly Linked List Test\n");

            char ch;

            do
            {
                Console.WriteLine("\nDoubly Linked List Operations\n");
                Console.WriteLine("1. Insert at begining");
                Console.WriteLine("2. Insert at end");
                Console.WriteLine("3. Insert at position");
                Console.WriteLine("4. Delete at position");
                Console.WriteLine("5. Check empty");
                Console.WriteLine("6. Get size");

                Console.Write("Enter choice : ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter integer element to insert : ");

                        list.insertAtStart(int.Parse(Console.ReadLine()));
                        break;
                    case 2:
                        Console.Write("Enter integer element to insert : ");

                        list.insertAtEnd(int.Parse(Console.ReadLine()));
                        break;
                    case 3:
                        Console.Write("Enter integer element to insert : ");

                        int num = int.Parse(Console.ReadLine());

                        Console.Write("Enter position : ");

                        int pos = int.Parse(Console.ReadLine());

                        if (pos < 1 || pos > list.getSize())
                            Console.WriteLine("Invalid position\n");
                        else
                            list.insertAtPos(num, pos);
                        break;
                    case 4:
                        Console.Write("Enter position : ");

                        int p = int.Parse(Console.ReadLine());

                        if (p < 1 || p > list.getSize())
                            Console.Write("Invalid position\n");
                        else
                            list.deleteAtPos(p);
                        break;
                    case 5:
                        Console.Write("Empty status = " + list.isEmpty());

                        break;
                    case 6:
                        Console.Write("Size = " + list.getSize() + " \n");

                        break;
                    default:
                        Console.Write("Wrong Entry \n ");

                        break;
                }

                list.display();

                Console.Write("\nDo you want to continue (Type y or n) : ");

                ch = Console.ReadLine().ElementAt(0);

            } while (ch == 'Y' || ch == 'y');
        }
        class Node
        {
            protected int data;
            protected Node next, prev;

            public Node()
            {
                next = null;
                prev = null;
                data = 0;
            }

            public Node(int d, Node n, Node p)
            {
                data = d;
                next = n;
                prev = p;
            }

            public void setLinkNext(Node n)
            {
                next = n;
            }

            public void setLinkPrev(Node p)
            {
                prev = p;
            }

            public Node getLinkNext()
            {
                return next;
            }

            public Node getLinkPrev()
            {
                return prev;
            }

            public void setData(int d)
            {
                data = d;
            }

            public int getData()
            {
                return data;
            }
        }

        class linkedList
        {
            protected Node start;
            protected Node end;
            public int size;

            public linkedList()
            {
                start = null;
                end = null;
                size = 0;
            }

            public bool isEmpty()
            {
                return start == null;
            }

            public int getSize()
            {
                return size;
            }

            public void insertAtStart(int val)
            {
                Node nptr = new Node(val, null, null);

                if (start == null)
                {
                    start = nptr;
                    end = start;
                }
                else
                {
                    start.setLinkPrev(nptr);
                    nptr.setLinkNext(start);
                    start = nptr;
                }
                size++;
            }

            public void insertAtEnd(int val)
            {
                Node nptr = new Node(val, null, null);

                if (start == null)
                {
                    start = nptr;
                    end = start;
                }
                else
                {
                    nptr.setLinkPrev(end);
                    end.setLinkNext(nptr);
                    end = nptr;
                }
                size++;
            }

            public void insertAtPos(int val, int pos)
            {
                Node nptr = new Node(val, null, null);

                if (pos == 1)
                {
                    insertAtStart(val);
                    return;
                }
                Node ptr = start;

                for (int i = 2; i <= size; i++)
                {
                    if (i == pos)
                    {
                        Node tmp = ptr.getLinkNext();
                        ptr.setLinkNext(nptr);
                        nptr.setLinkPrev(ptr);
                        nptr.setLinkNext(tmp);
                        tmp.setLinkPrev(nptr);
                    }
                    ptr = ptr.getLinkNext();
                }
                size++;
            }

            public void deleteAtPos(int pos)
            {
                if (pos == 1)
                {
                    if (size == 1)
                    {
                        start = null;
                        end = null;
                        size = 0;
                        return;
                    }
                    start = start.getLinkNext();
                    start.setLinkPrev(null);
                    size--;
                    return;
                }

                if (pos == size)
                {
                    end = end.getLinkPrev();
                    end.setLinkNext(null);
                    size--;
                }
                Node ptr = start.getLinkNext();

                for (int i = 2; i <= size; i++)
                {
                    if (i == pos)
                    {
                        Node p = ptr.getLinkPrev();
                        Node n = ptr.getLinkNext();

                        p.setLinkNext(n);
                        n.setLinkPrev(p);
                        size--;
                        return;
                    }
                    ptr = ptr.getLinkNext();
                }
            }

            public void display()
            {
                Console.Write("\nDoubly Linked List = ");

                if (size == 0)
                {
                    Console.Write("empty\n");

                    return;
                }

                if (start.getLinkNext() == null)
                {
                    Console.WriteLine(start.getData());

                    return;
                }
                Node ptr = start;

                Console.Write(start.getData() + " <-> ");

                ptr = start.getLinkNext();

                while (ptr.getLinkNext() != null)
                {
                    Console.Write(ptr.getData() + " <-> ");

                    ptr = ptr.getLinkNext();
                }

                Console.Write(ptr.getData() + "\n");
            }
        }
    }
}