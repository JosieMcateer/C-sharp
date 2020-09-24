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
            Exams school = new Exams();
            school.physics(40);
            school.showresults();

            Exams Uni = new Exams(150, 65);
            Uni.chemistry(70);
            Uni.showresults();
            
            
            Console.Read();
        }
    }
}
