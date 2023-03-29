using System;
using System.Collections.Generic;

namespace Stacks.Net5._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //defining a new stack
            Stack<int> stack = new Stack<int>();
            //add elements to the stack using Push()
            stack.Push(1);
            //remove item from a stack
            int myStackItem = stack.Pop();
            stack.Push(1337);
            //Peek() will return the element at the top of the stack without removing it
            Console.WriteLine("Top value in the stack is : {0}", stack.Peek());
        }
    }
}
