using System;
namespace DataStructures
{
    internal class LinkedLists
    {
        public Node head;
        public Node tail;

        public LinkedLists()
        {
            head = null;
            tail = null;
        }

        public void AddNode(Node node)
        {
            if (head == null && tail == null)
            {
                head = node;
                tail = node;
            }
            else
            {
                node.next = head;
                head = node;// make new node as head
            }
        }
        public void Display()
        {
            Node temp = head;
            if (temp == null)
            {
                Console.WriteLine("Linked list is Empty");
            }
            else
            {
                Console.WriteLine("Elements are");
                while (temp != null)
                {
                    Console.Write(temp.data);
                    if (temp.next != null)
                    {
                        Console.WriteLine(" ");
                    }
                    temp = temp.next;
                }
            }
            Console.WriteLine();
        }

        public Node Search(int data)
        {
            Node temp = this.head;
            while (temp != null)
            {
                if (temp.data == data)
                {
                    return temp;
                }
                temp = temp.next;
            }
            return null;
        }


        public void DeleteNodeAtFirst()
        {
            if (this.head == null)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                Node temp = this.head;
                this.head = this.head.next;
                Console.WriteLine("Removed from list " + temp.data);
            }
        }

        public void AppendNode(Node node)
        {
            if (head == null) // if empty
            {
                head = tail = node;
            }
            else
            {
                tail.next = node;
                tail = node;
            }
            tail.next = null;
        }

        public void AddNodeAtStart(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = tail = node;
            }
            else
            {
                node.next = head;
                head = node;
            }
        }
        public void insert(int data, int dataBefore)
        {
            Node node = new Node(data);

            if (this.head == null)
                this.head = this.tail = node;
            else
            {

                Node nodeBefore = this.Search(dataBefore);
                if (nodeBefore != null)
                {

                    node.next = nodeBefore.next;
                    nodeBefore.next = node;

                    if (nodeBefore == this.tail)
                        this.tail = node;
                }
                else
                    Console.WriteLine();
            }
        }
        public void DeleteNode(int data)
        {

            if (this.head == null)
            {
                Console.WriteLine("Empty");
            }
            else
            {
                Node node = this.Search(data);

                if (node == null)
                {
                    Console.WriteLine("Not found");
                }
                else if (node == this.head)
                {
                    this.head = this.head.next;
                    if (node == this.tail)
                    {
                        tail = null;
                    }
                }
                else
                {
                    Node nodeBefore = null;
                    Node temp = this.head;
                    while (temp != null)
                    {
                        if (temp.next == node)
                        {
                            nodeBefore = temp;
                            break;
                        }
                        temp = temp.next;
                    }
                    nodeBefore.next = node.next;
                    if (node == this.tail)
                    {
                        this.tail = nodeBefore;
                    }
                    else
                    {
                        node.next = null;
                    }
                }
            }
        }
    }
}