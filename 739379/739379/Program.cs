using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _739379
{
    class Program
    {
        static void Main(string[] args)
        {
            //Run method in Manager class consists of all Objects created for Problem classes
            Manager mn = new Manager();
            mn.Run();
        }
    }

    // Manages others classes objects
    class Manager
    {
        public void Run()
        {
           //Objects creeated using new keyword
            B_B1 object_b1 = new B_B1();
            //Calling Method in class using object
            object_b1.PrimeCheck();

            B_B2 object_b2 = new B_B2();
            object_b2.CharacterSwap();

            B_B3 object_b3 = new B_B3();
            object_b3.PrintMiddle();

            B_B33 object_b33 = new B_B33();
            object_b33.SwapLast();

            B_B4 object_b4 = new B_B4();
            object_b4.SumNatural();

            B_B5 object_b5 = new B_B5();
            object_b5.CountSpace();

            // A level Problems solutions are Called from ManagerA method in class SectionA
            SectionA sa = new SectionA();
            sa.ManagerA();

            //To hold the Console Output window
            Console.ReadKey();
        }
    }

    //Count first 500 prime numbers
    class B_B1
    {
        public void PrimeCheck()
        {
            int counter = 0, sum = 0, n = 2;

            while (counter < 500)
            {
                if (checkSum(n) == 0)
                {
                    sum += n;
                    counter++;
                }
                n++;
            }
            Console.WriteLine("Sum is {0}", sum);
            Console.ReadKey();
        }
        public int checkSum(int num)
        {
            int i, m = 0, flag = 0;
            m = num / 2;

            for (i = 2; i <= m; i++)
            {
                if (num % i == 0)
                {
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
            {
                //Console.WriteLine("Number is not Prime");
            }
            return flag;
        }

    }

    //Move 2 cahracter from last to first index
    class B_B2
    {
        public void CharacterSwap()
        {
            string str = "";
            while (str.Length < 2)
            {
                Console.WriteLine("Enter String");
                str = Console.ReadLine();
            }
            Console.WriteLine(str.Substring(str.Length - 2) + str.Remove(str.Length - 2));
        }
    }

    //New String Using Middle Character of String
    class B_B3
    {
        public void PrintMiddle()
        {
            string str = "";
            while (str.Length < 2 || (str.Length % 2) != 0)
            {
                Console.WriteLine("Enter valid String");
                str = Console.ReadLine();
            }
            Console.WriteLine(str.Substring(str.Length / 2 - 1, 2));
        }
    }

    //New String after Swapping Last two characters
    class B_B33
    {
        public void SwapLast()
        {
            string str = "";
            Console.WriteLine("Enter valid String");
            str = Console.ReadLine();
            if (str.Length > 1)
            {
                Console.WriteLine(str.Substring(str.Length - 1) + str.Substring(1, str.Length - 2) + str.Substring(0, 1));
            }
            else
            {
                Console.WriteLine(str);
            }
        }
    }

    // N natural numbers using Recursion
    class B_B4
    {
        int printNatural(int start, int n)
        {
            if (n < 1)
            {
                return start;
            }
            n--;
            Console.Write(" {0} ", start);
            return printNatural(start + 1, n);
        }
        public void SumNatural()
        {
            Console.WriteLine("Recursion : Print the first n natural number :");
            Console.WriteLine(" How many numbers to print : ");
            int n = Convert.ToInt32(Console.ReadLine());
            // Call recursive method with two parameters	
            printNatural(1, n);
            Console.WriteLine();
        }
    }

    // Count Number of spaces in the String Entered
    class B_B5
    {
        public void CountSpace()
        {
            char space = ' ';
            int i, count;
            count = 0;
            Console.WriteLine("Count the number spaces in string");
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();
            for (i = 0; i < input.Length; i++)
            {
                if (input[i].Equals(space))
                {
                    count++;
                }
            }
            Console.WriteLine("Number of spaces=" + count);
            Console.ReadLine();
        }
    }
}
