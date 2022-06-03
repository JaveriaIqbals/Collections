using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Customer
    {
        public int id;
        public string name;
        public string email;

        public Customer(int id, string name, string email)
        {
            this.id = id;
            this.name = name;
            this.email = email;
        }
        public Customer()
        {
            this.id =0;
            this.name = "";
            this.email = "";
        }
    }
    class TestCustomer
    {
        /*public static void Main(string [] args)
        {
            List<Customer> custList = new List<Customer>()
            {
                // no names of objects: annonymous objects
                new Customer(1, "def", "def@gmail.com"),
                new Customer(2, "ghi", "ghi@gmail.com")
            };
            
            Customer customer = new Customer(3, "abc", "abc@gmail.com");
            
            custList.Add(customer);
            foreach(Customer cust in custList)
            {
               Console.WriteLine("Customer Id : " + cust.id + "   Name : " + cust.name + "   Email:  " + cust.email);
            }

        }*/
    }
}
