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
}
