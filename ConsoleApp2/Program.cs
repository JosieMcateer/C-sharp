using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Exam Josie = new Exam();
            Josie.physics(1070);
            Josie.chemistry(150);
            Josie.maths(180);
            Josie.showresults();
            Console.Read();
        }
    }
}
