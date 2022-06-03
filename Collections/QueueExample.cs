using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    // Queue : First IN First Out Data Structure
    class Order
    {
        public string custName;
        public string[] ProductNames;
        public double TotalPrice;

        public Order(string custName, string [] ProductNames, double TotalPrice)
        {
            this.custName = custName;
            this.ProductNames = ProductNames;
            this.TotalPrice = TotalPrice;
        }
    }
    internal class QueueExample
    {
        Queue<Order> orders;

        public QueueExample()
        {
            orders = new Queue<Order>();
        }
        void AddIntoQueue()
        {
            orders.Enqueue(new Order("cust1", new string[] { "Chocolates", "Bread", "Eggs" }, 100));
            orders.Enqueue(new Order("cust2", new string[] { "Apple", "Orange", "Eggs" }, 150));
            orders.Enqueue(new Order("cust3", new string[] { "Notebook", "Pencil", "Eggs" }, 500));
            orders.Enqueue(new Order("cust4", new string[] { "Tomatoes", "Garlic", "Eggs" }, 45));

            Console.WriteLine(orders.Count); // 4

        }
        void RemoveOrder()
        {
            orders.Dequeue();
            Console.WriteLine(orders.Count); // remainind orders inside Queue
        }
        double GetOrderTotalPrice(string name)
        {
            double tp = 0;
            // Search in the Queue.
            foreach(Order order in orders)
            {
                if(order.custName == name)
                {
                    tp = order.TotalPrice;
                    Console.WriteLine(tp);
                }

            }
            return tp;
        }
        
        public void GetAllOrdersInfo()
        {
            foreach(Order o in orders)
            {
                Console.WriteLine("Customer Name : " + o.custName);
                Console.WriteLine("Total Price : " + o.TotalPrice);
                Console.WriteLine();
                for (int i = 0; i < o.ProductNames.Length; i++)
                {
                    Console.Write(" ***Product #  : " + (i+1) + "  " +  o.ProductNames[i]);
                }
                Console.WriteLine();
            }
        }
        /*public static void Main(string [] args)
        {
            //string[] s1 = new string[5] {...};

            //Queue<Order> orders = new Queue<Order>();

            QueueExample qObj = new QueueExample();
            qObj.AddIntoQueue();

            qObj.GetAllOrdersInfo();

            //qObj.GetOrderTotalPrice("cust4");
            
        }*/
    }
}
