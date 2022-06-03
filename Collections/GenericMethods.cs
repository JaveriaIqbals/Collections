using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class GenericMethods
    {
        // Generic Method : Type Parameters ONLY <T>
        
        /****************************************/
        static void sortArray1()
        {
            int[] array = { 11, 34, 56, 32, 54 };
            Array.Sort(array);
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
        }

        static void sortArray2(int[] array)
        {
            Array.Sort(array);
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
        }
        public static void sortArray2(char[] charsArray)
        {
            Array.Sort(charsArray);
            foreach (char i in charsArray)
            {
                Console.WriteLine(i);
            }
        }
        /****************************************/
        static void Add<T>(T a , T b)
        {
            dynamic n1 = a;
            dynamic n2 = b;
            Console.WriteLine(n1 + n2);
        }
        static void SwapValue<T>(ref T a , ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
            
        }
        static void SortList<T>(T [] arr)
        {
            Array.Sort(arr);// increasing order

        }
        /*public static void Main(string [] args)
        {
            Add(1, 2);
            Add(2.3f, 3.44f);
            Add(222.45, 5678.23);
            int num1 = 10;
            int num2 = 20;  
            SwapValue(ref num1, ref num2);

            Console.WriteLine(num1); // 20
            Console.WriteLine(num2); // 10
            float f1 = 2.3f;
            float f2 = 3.4f;
            SwapValue(ref f1, ref f2);
            Console.WriteLine(f1); // 3.4f 
            Console.WriteLine(f2);  // 2.3f 
            string s1 = "Hello";
            string s2 = "Goodbye";
            SwapValue(ref s1, ref s2);
            Console.WriteLine(s1); //  
            Console.WriteLine(s2);  //     
            
            // Sorting the Arrays
            int[] arr = { 11, 2, -3, 44, 5 };
            SortList<int>(arr);
            
            Console.WriteLine("After Sorting : ");
            foreach(int i in arr)
                Console.WriteLine(i);

            char[] charArr = { 'z', 'h', 'a', 'd' };
            SortList<char>(charArr);

            Console.WriteLine("After Sorting : ");
            foreach (char i in charArr)
                Console.WriteLine(i);

        }*/
    }
}
