using System;

namespace StackDesign
{
        class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stacks();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Count().ToString());
            try
            {
                Console.WriteLine(stack.Peek());
                stack.Clear();
                Console.WriteLine(stack.Count().ToString());
                Console.WriteLine(stack.Peek());
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}