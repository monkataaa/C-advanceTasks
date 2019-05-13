using System;
using System.Collections.Generic;
using System.Linq;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            var stack = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            var commandInfo = Console.ReadLine().ToLower();

            while (commandInfo != "end")
            {
                var tokens = commandInfo.Split();
                var command = tokens[0].ToLower();

                if (command == "add")
                {
                    stack.Push(int.Parse(tokens[1]));
                    stack.Push(int.Parse(tokens[2]));
                }
                var removeNumebrs = int.Parse(tokens[1]);
                if (command == "remove" && removeNumebrs < stack.Count())
                {
                    for (int i = 0; i < removeNumebrs; i++)
                    {
                        stack.Pop();
                    }
                }
                commandInfo = Console.ReadLine().ToLower();
            }
            Console.WriteLine($"Sum: {stack.Sum()}");



        }
    }
}
