using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {
        // Collections : ArrayList is a non-generic collection 
        // This is not a type safe data struture.
        /*static void Main(string[] args)
        {
            int[] arr = new int[5];
            Array.Resize(ref arr, 15); // size will grow
            Console.WriteLine(arr.Length);

            // your arr is deleted , and before deleting another copy is made for array arr with 
            // new size 15.

            // 1. auto increasing
            // 2. Insert/Delete 
            ArrayList list1 = new ArrayList();
            Console.WriteLine(list1.Capacity);
            list1.Add(1); // [indexes => 0,1,.... ]
            list1.Add(2);
            list1.Add(3);
            list1.Add(4);
            Console.WriteLine(list1.Capacity);
            list1.Add(5);
            Console.WriteLine(list1.Capacity);

            foreach(int l in list1)
            {
                Console.WriteLine("Value: " + l);
            }

            list1.Insert(3, 10); // 4th element
            Console.WriteLine("After Insertion:  ");
            foreach (int l in list1)
            {
                Console.WriteLine("Value: " + l);
            }
            list1.Remove(4); // Pass object to remove
            Console.WriteLine("After Removal: ");
            foreach (int l in list1)
            {
                Console.WriteLine("Value: " + l);
            }
            list1.Add("abc");
            list1.Add('a');
            list1.Add(1.2f);
            foreach (object l in list1)
            {
                Console.WriteLine("Value: " + l);
            }
        }*/
    }
}
