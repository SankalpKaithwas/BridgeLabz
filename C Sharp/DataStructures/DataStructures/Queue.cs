using System;


namespace DataStructures
{
    internal class Queue
    {
        LinkedLists linkedLists;

        public Queue()
        {
            linkedLists = new LinkedLists();
        }

        public void Enqueue(Node data)
        {
            linkedLists.AppendNode(data);
        }
        public void DisplayQueue()
        {
            linkedLists.Display();
        }

        public void Top()
        {
            var value = linkedLists.head;
            Console.WriteLine(value.data);
        }
    }
}
