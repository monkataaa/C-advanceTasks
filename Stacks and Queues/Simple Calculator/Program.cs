using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
             var stack = new Stack<string>(Console.ReadLine().Split().Reverse());
            var result = 0;

            result += int.Parse(stack.Pop());

            while (stack.Any())
            {
                
                
                if (stack.Peek() == "+")
                {
                    stack.Pop();
                    result += int.Parse(stack.Pop());
                }
                else if (stack.Peek() == "-")
                {
                    stack.Pop();
                    result -= int.Parse(stack.Pop());
                }
                

            }
            Console.WriteLine(result);
        }
    }
}
