using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Exam
    {
        private int phy, che, mat;
        public void physics(int p)
        {
            if (p >= 0 && p <= 150)
            {
                phy = p;
            }
            else
            {
                Console.Write("invalid physics marks");
            }
        }

        public void chemistry(int c)
        {
            if (c >= 0 && c <= 150)
            {
                che = c;
            }
            else
            {
                Console.Write("invalid chemistry marks");
            }
        }
        public void maths(int m)
        {
            if (m >= 0 && m <= 150)
            {
                mat = m;
            }
            else
            {
                Console.Write("invalid maths marks");
            }
        }
        public void showresults()
        {
            float total, per;
            total = phy + che + mat;
            per = total * 100 / 450;
            Console.WriteLine("Total marks: " + total);
            Console.WriteLine("Percentage: " + per);
        }
    }
}
