namespace StackandQueueUsingArray
{
    internal class Queue
    {
        
        public int front;
        public int rear;
        public int[] queue;
        public Queue(int size)
        {
            queue = new int[size];
            front = 0;
            rear = -1;//0 
        }

        public void Enqueue(int data)
        {
            queue[++rear] = data;
        }
        public void Dequeue()
        {
            int value = queue[front];
            queue[front++] = 0;
            System.Console.WriteLine("Removed " + value);
            
        }

        public void Display()
        {
            for(int i =front; i <=rear; i++)
            {
                System.Console.WriteLine(queue[i]);
            }
        }
    }

}