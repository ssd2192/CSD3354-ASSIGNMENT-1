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
            Manager mn = new Manager();
            mn.Run();
        }
    }

    class Manager
    {
        public void Run()
        {
            A_B1 object_b1 = new A_B1();
            object_b1.PrimeCheck();

            B_B2 object_b2 = new B_B2();
            object_b2.SumNatural();

            B_B5 object_b5 = new B_B5();
            object_b5.CountSpace();

            A_AI obj = new A_AI();
            obj.RunAI();

            Console.ReadKey();
        }
    }

    class A_B1
    {
        public void PrimeCheck()
        {
            int counter = 0, sum = 0, n=2;
           
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
    class B_B2
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
    class A_AI
    {
        public void RunAI()
        {
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(result(n));

            
        }
        public static bool result(int n)
        {
            if (Math.Abs(n - 100) <= 20 || Math.Abs(n + 100) <= 20)
                return true;
            return false;
        }
    }
}
