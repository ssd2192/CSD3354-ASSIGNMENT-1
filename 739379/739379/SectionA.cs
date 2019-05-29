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
            //AA object_AA = new AA();
            //object_AA.PrintName();

            //AB object_ab = new AB();
            //object_ab.simpleMaths();

            //AC object_ac = new AC();
            //object_ac.swap();

            //AD object_ad = new AD();
            //object_ad.Multiplication();

            //AE object_ae = new AE();
            //object_ae.MultiTable();

            //AF object_af = new AF();
            //object_af.CalcAverage();

            AG object_ag = new AG();
            object_ag.PrintName();

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

    class AC
    {
        public void swap()
        {
            int x, y;
            Console.WriteLine("Enter value of x");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value of y");
            y = Convert.ToInt32(Console.ReadLine());

            int temp =x;
            x = y;
            y = temp;

            Console.WriteLine("After Swaping: x is {0}, y is {1}", x, y);
            
        }
    }

    class AD
    {
        public void Multiplication()
        {
            Console.Write("Enter First Number");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Number");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Emter Third Number");
            int z = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Multiplication of numbers: {0} x {1} x {2} = {3}", x, y, z, (x*y*z));
        }
    }

    class AE
    {
        public void MultiTable()
        {
            Console.Write("Enter the number (Table to be calculated) : ");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} X {1} = {2}", number, i, (number * i));

            }
        }
    }

    class AF
    {
        public void CalcAverage()
        {
            double num1, num2, num3, num4, result;
            Console.WriteLine("Enter 4 numbers");
            num1 = Convert.ToDouble(Console.ReadLine());
            num2 = Convert.ToDouble(Console.ReadLine());
            num3 = Convert.ToDouble(Console.ReadLine());
            num4 = Convert.ToDouble(Console.ReadLine());

            result = (num1 + num2 + num3 + num4) / 4;
            Console.WriteLine("The average of {0}, {1}, {2}, {3} is {4} ", num1, num2, num3, num4, result);
        }
    }

    class AG
    {
        public void PrintName()
        {
            Console.WriteLine("Enter Your name");
            string name = Console.ReadLine();
            Console.WriteLine("{0}, You look older than 20.", name);
        }
    }


}
