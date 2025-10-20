using System;

namespace StackDesign
{
    class Program
    {
        static void Main(string[] args)
        {
            StackOperation1(); //"Second", "First"
            StackOperation2(); //"Third"
            StackOperation3(); //"Fourth"
            StackOperation4(); // "9", "8", "7", "5", Exception

        }

        static void StackOperation1()
        {
            var stack = new Stacks();
            stack.Push("First");
            stack.Push("Second");
            stack.PeekAll();
        }

        static void StackOperation2()
        {
            var stack = new Stacks();
            stack.Push("Third");
            Console.WriteLine(stack.Pop().ToString());
        }

        static void StackOperation3()
        {
            var stack = new Stacks();
            stack.Push("Fourth");
            stack.PeekAll();
        }

        static void StackOperation4()
        {
            var stack = new Stacks();
            stack.Push("Fifth");
            stack.Push("Sixth");
            stack.Push(7);
            stack.Push(8);
            stack.Push(9);
            Console.WriteLine(stack.Pop().ToString());
            Console.WriteLine(stack.Pop().ToString());
            Console.WriteLine(stack.Pop().ToString());
            Console.WriteLine(stack.Count().ToString());
            stack.Clear();
            stack.PeekAll();

        }
    }
}