using System;


namespace DataStructures
{
    internal class Stack
    {
        LinkedLists linkedList;

        public Stack()
        {
            linkedList = new LinkedLists();
        }

        public void Push(Node node)
        {
            linkedList.AddNode(node);
        }
        public void DisplayStack()
        {
            Console.WriteLine("Stack elements are");
            linkedList.Display();
        }

        public void Top()
        {
            var value = linkedList.head;
            Console.WriteLine(value.data);
        }

    }
}
