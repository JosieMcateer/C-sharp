using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class operations
    {
        public int A, B;
        public void message()
        {
            Console.Write("hello ");
            Console.Write("friends ");
        }

        public void add(int a, int b)
        {
            int result = a + b;
            Console.Write("the result of addition is " + (a + b));
        }

        public void salarySlip(int salary)
        {
            float tax, net;
            if (salary >= 2000)
            {
                tax = salary * 10 / 100;
            }
            else
            {
                tax = salary * 10 / 100;
            }

            net = salary - tax;
            Console.WriteLine("your salary is " + salary);
            Console.WriteLine("tax calculated is" + tax);
            Console.WriteLine("net salary is " + net);
             }
    }
}
