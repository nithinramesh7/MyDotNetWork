using System;

namespace ConsoleApp1
{
    internal class mystack
    {
        static readonly int max = 9;
        int top;
        int[] stack = new int[max];

        public mystack()
        {
            top = -1;
        }
        internal bool isempty()
        {
            return (top < 0);
        }
        internal bool push(int data)
        {
            if (top >= max)
            {
                Console.WriteLine("stack overflow");
                return false;
            }
            else
            {
                stack[++top] = data;
                return true;
            }
        }
        internal int pop()
        {
            if (top < 0)
            {
                Console.WriteLine("stack underflow");
            }
        }
        internal int peek()
        {
            if (top < 0)
            {
                return -1;
            }
            else
            {
                return stack[top];
            }
        }
        internal bool isfull()
        {
            if (top == max)
            {
                return true;
            }
            else
                return false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            mystack st = new mystack();
            Console.WriteLine(st.isfull());
            Console.WriteLine(st.isempty());
            Console.WriteLine(st.pop());

        }
    }
}
