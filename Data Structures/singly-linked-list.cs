using System;
using System.Linq;

namespace Chisenoa
{
    class SinglyLinkedList
    {
        static void Main(String[] args)
        {
            linkedList list = new linkedList();
            char ch;

            do
            {
                Console.WriteLine("Singly Linked List Operations\n");
                Console.WriteLine("1. insert at begining");
                Console.WriteLine("2. insert at end");
                Console.WriteLine("3. insert at position");
                Console.WriteLine("4. delete at position");
                Console.WriteLine("5. check empty");
                Console.WriteLine("6. get size");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter integer element to insert");

                        list.insertAtStart(int.Parse(Console.ReadLine()));
                        break;
                    case 2:
                        Console.WriteLine("Enter integer element to insert");

                        list.insertAtEnd(int.Parse(Console.ReadLine()));
                        break;
                    case 3:
                        Console.WriteLine("Enter integer element to insert");

                        int num = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter position");

                        int pos = int.Parse(Console.ReadLine());

                        if (pos <= 1 || pos > list.getSize())
                            Console.WriteLine("Invalid position\n");
                        else
                            list.insertAtPos(num, pos);
                        break;
                    case 4:
                        Console.WriteLine("Enter position");

                        int p = int.Parse(Console.ReadLine());

                        if (p < 1 || p > list.getSize())
                            Console.WriteLine("Invalid position\n");
                        else
                            list.deleteAtPos(p);
                        break;
                    case 5:
                        Console.WriteLine("Empty status = " + list.isEmpty());

                        break;
                    case 6:
                        Console.WriteLine("Size = " + list.getSize() + " \n");

                        break;
                    default:
                        Console.WriteLine("Wrong Entry \n ");

                        break;
                }
                list.display();

                Console.WriteLine("Do you want to continue (Type y or n) \n");

                ch = Console.ReadLine().ElementAt(0);
            } while (ch == 'Y' || ch == 'y');
            Console.ReadLine();
        }
    }
    class Node
    {
        protected int data;
        protected Node link;

        public Node()
        {
            link = null;
            data = 0;
        }

        public Node(int d, Node n)
        {
            data = d;
            link = n;
        }

        public void setLink(Node n)
        {
            link = n;
        }

        public void setData(int d)
        {
            data = d;
        }

        public Node getLink()
        {
            return link;
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
            Node nptr = new Node(val, null);
            size++;
            if (start == null)
            {
                start = nptr;
                end = start;
            }
            else
            {
                nptr.setLink(start);
                start = nptr;
            }
        }

        public void insertAtEnd(int val)
        {
            Node nptr = new Node(val, null);
            size++;
            if (start == null)
            {
                start = nptr;
                end = start;
            }
            else
            {
                end.setLink(nptr);
                end = nptr;
            }
        }

        public void insertAtPos(int val, int pos)
        {
            Node nptr = new Node(val, null);
            Node ptr = start;
            pos = pos - 1;

            for (int i = 1; i < size; i++)
            {
                if (i == pos)
                {
                    Node tmp = ptr.getLink();
                    ptr.setLink(nptr);
                    nptr.setLink(tmp);
                    break;
                }
                ptr = ptr.getLink();
            }
            size++;
        }

        public void deleteAtPos(int pos)
        {
            if (pos == 1)
            {
                start = start.getLink();
                size--;
                return;
            }

            if (pos == size)
            {
                Node s = start;
                Node t = start;
                while (s != end)
                {
                    t = s;
                    s = s.getLink();
                }
                end = t;
                end.setLink(null);
                size--;
                return;
            }

            Node ptr = start;
            pos = pos - 1;

            for (int i = 1; i < size - 1; i++)
            {
                if (i == pos)
                {
                    Node tmp = ptr.getLink();
                    tmp = tmp.getLink();
                    ptr.setLink(tmp);
                    break;
                }
                ptr = ptr.getLink();
            }
            size--;
        }

        public void display()
        {
            Console.WriteLine("Singly Linked List = ");

            if (size == 0)
            {
                Console.Write("empty\n");

                return;
            }

            if (start.getLink() == null)
            {
                Console.WriteLine(start.getData());

                return;
            }
            Node ptr = start;

            Console.Write(start.getData() + "->");

            ptr = start.getLink();

            while (ptr.getLink() != null)
            {
                Console.Write(ptr.getData() + "->");

                ptr = ptr.getLink();
            }

            Console.Write(ptr.getData() + "\n");
        }
    }
}