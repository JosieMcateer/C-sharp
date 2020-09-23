using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Nationwide
    {
        static void Main(string[] args)
        {
            NationWide X;
            X = new NationWide();
            X.A = 20;
            X.B = 25;
            X.C = X.A + X.B;
            Console.WriteLine(X.C);
            
            operations opt;
            opt = new operations();
            opt.message();
            opt.add(5, 10);

            opt.salarySlip(2000);
            opt.salarySlip(1000);

            maths call;
            call = new maths();
            call.add(7, 15);
            call.sub(10, 5);
            call.div(100, 10);
            call.mult(5, 10);

            Console.Read();

        }
    }
}
