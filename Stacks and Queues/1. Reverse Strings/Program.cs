using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            var stack = new Stack<char>();
            var input = Console.ReadLine();


            foreach (var item in input)
            {
                stack.Push(item);
            }

            while (stack.Count != 0)
            {
                Console.Write(stack.Pop());
            }

        }
    }
}
