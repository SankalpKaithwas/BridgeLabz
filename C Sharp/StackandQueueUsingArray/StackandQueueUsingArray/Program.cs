using System;

namespace StackandQueueUsingArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue(5);
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(4);
            //queue.Enqueue(5);
            //queue.Display();
            //queue.Dequeue();
            //queue.Dequeue();
            //queue.Dequeue();
            //queue.Enqueue(111);
            //queue.Display();


            Stack stack = new Stack(5);//56/2/1
            stack.Push(1);
            stack.Push(2);
            stack.Push(23);
            stack.Push(3);
            stack.Push(5);
            stack.Display();
            stack.Pop();
            stack.Pop();
            stack.Pop();
            stack.Push(56);
            stack.Display();
        }
    }
}
