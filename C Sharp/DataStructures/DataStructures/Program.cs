using System;

namespace DataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedLists linkedList = new LinkedLists();
            Node node_1 = new Node(1);
            Node node_2 = new Node(2);
            Node node_3 = new Node(3);

            linkedList.AddNode(node_1);
            linkedList.AddNode(node_2);
            linkedList.AddNode(node_3);
            // linkedList.Display();


            //Console.WriteLine("Enter number to search");
            //int data = int.Parse(Console.ReadLine());
            //if (linkedList.Search(data) != null)
            //{
            //    Console.WriteLine("Node found");
            //}
            //else
            //{
            //    Console.WriteLine("Node not found");
            //}

            //linkedList.DeleteNodeAtFirst();
            //linkedList.Display();

            // Console.WriteLine("enter data to append");
            //int data = int.Parse(Console.ReadLine());
            //linkedList.AppendNode(node_2);
            //linkedList.Display();

            //Console.WriteLine("Ener data to append at start");
            //data = int.Parse(Console.ReadLine());
            //linkedList.AddNodeAtStart(data);
            //linkedList.Display();

            //Console.WriteLine("Enter data to delete end node");
            //data = int.Parse(Console.ReadLine());
            //linkedList.DeleteNode(data);
            //linkedList.Display();

            //linkedList.insert(50, 2);
            //linkedList.Display();


            Stack stack = new Stack();
            stack.Push(node_1);
            stack.Push(node_2);
            stack.Push(node_3);
            stack.DisplayStack();


            Queue queue = new Queue();
            queue.Enqueue(node_1);
            queue.Enqueue(node_2);
            queue.Enqueue(node_3);
            queue.DisplayQueue();



        }
    }
}
