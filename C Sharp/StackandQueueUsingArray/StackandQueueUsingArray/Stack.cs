namespace StackandQueueUsingArray
{
    internal class Stack
    {
        private int size;
        int[] stack;
        int top;

        public Stack(int size)
        {
            this.size = size;
            stack = new int[size];
            top = -1;
        }
        public void Push(int data)
        {
            if (IsFull())
            {
                System.Console.WriteLine("Stack is Full");
            }
            else
            {
                stack[++top] = data;
            }
        }

        public bool IsFull()//4
        {
            if (top >= (size - 1))//01234
            {
                return true;
            }
            return false;
        }

        public void Pop()
        {
            int popped = stack[top--];
            System.Console.WriteLine("Popped " + popped);
        }
        public void Display()
        {
            System.Console.WriteLine("Stack - ");
            for (int i = top; i >= 0; i--)
            {
                System.Console.WriteLine(stack[i]);
            }
        }
    }
}