using System;

namespace StackAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            LinkedListUsingStack linkedListStack = new LinkedListUsingStack();
            linkedListStack.Push(57);
            linkedListStack.Push(30);
            linkedListStack.Push(70);
            linkedListStack.Display();
            linkedListStack.Peek(); //top.data;
            linkedListStack.Pop();
            linkedListStack.MakeEmpty();
            linkedListStack.Display();
            Console.ReadKey();
        }
    }
}