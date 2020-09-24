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
        private int invalidmarks, failed;
        public void physics(int p)
        {
            if (p >= 0 && p <= 150)
            {
                phy = p;
                if (p < 60)
                failed = 1;
            }
            else
            {
                invalidmarks = -1;
                Console.Write("invalid physics marks");
            }
        }

        public void chemistry(int c)
        {
            if (c >= 0 && c <= 150)
            {
                che = c;
                if (c < 60)
                    failed = 1;
            }
            else
            {
                invalidmarks = -1;
                Console.Write("invalid chemistry marks");
            }
        }
        public void maths(int m)
        {
            if (m >= 0 && m <= 150)
            {
                mat = m;
                if (m < 60)
                    failed = 1;
            }
            else
            {
                invalidmarks = -1;
                Console.Write("invalid maths marks");
            }
        }
        public void showresults()
        {
            float total, per;
            total = phy + che + mat;
            per = total * 100 / 450;
            if (invalidmarks == 0)
                if (failed == 0)
                {
                    Console.WriteLine("Total marks: " + total);
                    Console.WriteLine("Percentage: " + per);
                }
                else
                {
                    Console.WriteLine("You have failed the exam");
                }
            }
        }
    }

