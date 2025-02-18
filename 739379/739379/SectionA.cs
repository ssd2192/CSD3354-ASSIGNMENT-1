﻿using System;
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

            AC object_ac = new AC();
            object_ac.swap();

            AD object_ad = new AD();
            object_ad.Multiplication();

            AE object_ae = new AE();
            object_ae.MultiTable();

            AF object_af = new AF();
            object_af.CalcAverage();

            AG object_ag = new AG();
            object_ag.PrintName();

            AH object_ah = new AH();
            object_ah.TripleSum();

            AI object_ai = new AI();
            object_ai.WithinRange();

            AJ object_aj = new AJ();
            object_aj.AddNaturalForLoop();

            AK object_ak = new AK();
            object_ak.AddNaturalWhileLoop();

            AL object_al = new AL();
            object_al.EqualOrNot();

            AM object_am = new AM();
            object_am.LargestOfThree();




        }
    }

    // Input your name and hello in separate lines
    class AA
    {
        public void PrintName()
        {
            Console.Write("Enter your name.. ");
            String name = Console.ReadLine();
            Console.WriteLine("Hello! \n{0}", name);
        }
    }

    //Sum Product Division of two numbers
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

    //Swapping two numbers
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

    //Multiple of 3 numbers
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

    //Print Table of user enterd number
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

    //Average of 4 numbers entered
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

    //Print name
    class AG
    {
        public void PrintName()
        {
            Console.WriteLine("Enter Your name");
            string name = Console.ReadLine();
            Console.WriteLine("{0}, You look older than 20.", name);
        }
    }

    //Triple the sum if numbers are equal
    class AH
    {
        public void TripleSum()
        {
            Console.WriteLine("Enter two numbers");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 == num2)
            {
                Console.WriteLine("Both numbers are equal. Their triplet is {0}", (num1+num2)*3);
            }
            else
            {
                Console.WriteLine("sum of two numbers is {0}", (num1+num2));
            }
        }
    }

    //Find if number is 20 within 100
    class AI
    {
        public void WithinRange()
        {
            Console.Write("Enter Number.. ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (Math.Abs(a - 100) <= 20 || Math.Abs(a + 100) <= 20)
            {
                Console.WriteLine("Within Range");
            }
            else
            {
                Console.WriteLine("Out of range");
            }     
        }
    }

    //Add Natural numbers with for loop
    class AJ
    {
        public void AddNaturalForLoop()
        {
            
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                sum += i;
            }
            Console.WriteLine("sum of first 10 natural numbers is {0}", sum);
        }
    }

    // Add natural numbers with while loop
    class AK
    {
        public void AddNaturalWhileLoop()
        {
            int i=1, sum = 0;
            while (i <= 10)
            {
                sum += i;
                i++;
            }
            Console.WriteLine("sum of first 10 natural numbers is {0}", sum);
        }
    }

    //Evaluate if 2 numbers equal or not
    class AL
    {
        public void EqualOrNot()
        {
            Console.WriteLine("Enter two numbers.. ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 == num2)
            {
                Console.WriteLine("Both numbers are equal.", num1, num2);
            }
            else
            {
                Console.WriteLine("Numbers are not equal.", num1, num2);
            }
        }
    }

    //Firnd the Largest of 3 numbers
    class AM
    {
        public void LargestOfThree()
        {
            Console.WriteLine("Enter 3 Numbers to check the Largest Number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("Largest is {0}", num1); 
            }
            else if (num2>num1 && num2 > num3)
            {
                Console.WriteLine("Largest is {0}",num2);
            }
            else
            {
                Console.WriteLine("Largest is {0}", num3);
            }
        }
    }
}
