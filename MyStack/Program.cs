﻿namespace MyStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyStack<int> myStack = new MyStack<int>();  
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);
            myStack.Push(5);
            Console.WriteLine(myStack.Peek());
        }
    }
}
