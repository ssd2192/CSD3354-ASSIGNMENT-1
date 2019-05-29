using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _739379
{
    class SectionA
    {
        public void ManagerA()
        {
            AA object_AA = new AA();
            object_AA.PrintName();

            AB object_ab = new AB();
            object_ab.simpleMaths();
        }
    }
    class AA
    {
        public void PrintName()
        {
            // input your name and print hello with your name in a separate line
            Console.Write("Enter your name.. ");
            String name = Console.ReadLine();
            Console.WriteLine("Hello! \n{0}", name);
        }
    }

    class AB
    {
        public void simpleMaths()
        {
            int x, y;
            Console.WriteLine("Enter Value of X");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Value of Y");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sum: {0}, Product: {1}, Division: {2}",(x+y),(x*y),(x/y));
        }
    }

}
