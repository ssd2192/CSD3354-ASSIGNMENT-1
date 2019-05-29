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
            int n, i, m = 0, flag = 0;
            //Console.WriteLine("Enter the number to check Prime: ");
            //n = int.Parse(Console.ReadLine());
            m = num / 2;

            for (i = 2; i <= m; i++)
            {
                if (num % i == 0)
                {
                    //Console.WriteLine("Number is not Prime");
                    //Console.WriteLine(num);
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
            {
                //Console.WriteLine(num);
                //Console.WriteLine("Number is not Prime");
            }

            return flag;

        }
       
    }
    class B_B2
    {

    }
}
