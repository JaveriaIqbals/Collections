using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    // HashTable : is non-generic collection
    // Not type - safe
    internal class HashtableExample
    {
        /*public static void Main(string [] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "abc");
            ht.Add(2, "def");
            ht.Add(3, 123);
            ht.Add(4, 12.34f);
            Console.WriteLine("Total values are : " + ht.Count);

            foreach(object key in ht.Keys)
            {
                Console.WriteLine(ht[key]); // search with key
            }

            ht = new Hashtable()
            {
                {1, "abc"},
                {2, "def"}
            };
            
            Console.WriteLine("Total values are : " + ht.Count);
            

           


            Queue<int> queue = new Queue<int>(); // FIFO
            queue.Enqueue(1); // this is type safe
            queue.Enqueue(2);

            Queue queue1 = new Queue(); // not type safe
            queue1.Enqueue(1);
            queue1.Enqueue("abc");
            

            // PhoneBook App =>  Name : Phone#
            Hashtable phoneBookDir = new Hashtable();
            string name = "";
            string phoneNumber = ""; // long int => (int64)
            char choice = ' ';
            
            while (choice != 'Q')
            {
                // Take input from User 
                Console.WriteLine("Enter your choice : A or B or Q");
                Console.WriteLine("Enter A : To Add Number in PhoneBook App");
                Console.WriteLine("Enter B : To Search Number in PhoneBook App");
                Console.WriteLine("Enter Q : To Quit from PhoneBook App");
                choice = Convert.ToChar(Console.ReadLine());

                if (choice == 'A')
                {
                    Console.WriteLine("Enter Name : ");
                    name = Console.ReadLine();
                    Console.WriteLine("Enter Phone Number : ");
                    phoneNumber = Console.ReadLine();
                    phoneBookDir.Add(name, phoneNumber);

                }
                else if (choice == 'B')
                {
                    Console.WriteLine("Enter Name to find the Phone number : ");
                    name = Console.ReadLine();
                    // search now
                    if (phoneBookDir[name] != null)
                    {
                        phoneNumber = (string)phoneBookDir[name];
                        Console.WriteLine("Phone Number for " + name + "is: " + phoneNumber);
                    }
                    else
                    {
                        Console.WriteLine("This Name does not exist in Phonebook Directory");
                    }

                }
                //else if (choice == 'Q')
                //{
                  //  Console.WriteLine("Exit the App");
                    //break;
                //}

            }// end of while loop

            Console.WriteLine("Exit the App");

        }*/
    }
}
