using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ClassC:ClassP
    {
        public void Subtraction(int a, int b)
        {
            int result = a - b;
            Console.WriteLine("The result of subtraction is: " + result);
        }
    }
}
