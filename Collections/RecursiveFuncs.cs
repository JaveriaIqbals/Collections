using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class RecursiveFuncs
    {
        // This is non recursive method for Factorial
        public static void Factorial(int num)
        {
            long result = 1;
            for (int i = num; i >= 1; i--) // i => 5,4,3,2,1
            {
                result = result * i;
            }
            Console.WriteLine(result);
        }

        // Recursive Method for factorial
        public static long FactRecursive(int num)
        {
            // 5, 4!*5=120, 
            // 9!*10 =>
            // Do not forget BASE condition.
            if(num >=1)
                return num * FactRecursive(num - 1);
            else // when num = 0 
                return 1;

        }

        // Fibonacci => 0,1,1,2,3,5,8,13,....
        public static void Fibo(int size)
        {
            int firstnum = 0;
            int secondnum = 1;
            Console.Write(firstnum + " , " + secondnum);
            int sum = 0;
            for (int i = 3; i <= size; i++ )
            {
                sum = firstnum + secondnum;
                firstnum = secondnum;
                secondnum = sum;
                Console.Write("," + sum);
            }

        }

        public static void FiboHelper(int size)
        {
            FiboRecursive(0, 1, 1, size);
        }
        public static void FiboRecursive(int first, int second, int count, int size)
        {
            if (count <= size)
            {
                Console.Write(first + " , ");
                FiboRecursive(second, first + second, count + 1, size);
            }
        }
        public static void Main(string [] args)
        {
            // 0!  = 1
            //Factorial(0);
            long result = FactRecursive(5);
            Console.WriteLine(result);
            FiboHelper(10);
        }
    }
}
