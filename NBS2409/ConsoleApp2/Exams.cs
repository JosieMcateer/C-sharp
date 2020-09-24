using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Exams
    {
        private int phy, che, maxmarks, passmarks;
        private int invalidmarks, failed;
        public Exams()
        {
            maxmarks = 100;
            passmarks = 50;
        }

        public Exams(int m, int p)
        {
            maxmarks = m;
            passmarks = p;
        }

        public void physics(int p)
        {
            if (p >= 0 && p <= maxmarks)
            {
                phy = p;
                if (p < passmarks)
                    failed = 1;
            }
            else
            {
                invalidmarks = -1;
                Console.Write("Invalid physics marks " + maxmarks + " are the maximum marks");
            }
        }
        public void chemistry(int c)
        {
            if (c >= 0 && c <= maxmarks)
            {
                che = c;
                if (c < passmarks)
                    failed = 1;
            }
            else
            {
                invalidmarks = -1;
                Console.Write("Invalid chemistry marks " + maxmarks + " are the maximum marks");
            }
        }
        public void showresults()
        {
            float total;
            total = phy + che;
            if (invalidmarks == 0)
            if (failed==0)
            {
                Console.Write("Total marks: " + total);
            }
            else
            {
                    Console.Write("You have failed the exam ");
            }
            
        }

    }
}
