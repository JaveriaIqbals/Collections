using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class DictionaryExample
    {
        // Dictionary : based on key and value pairs. key is unique, values can be duplicated.
        // No order of items.
        /*public static void Main(string [] args)
        {
            IDictionary<int, string> names = new Dictionary<int, string>();
            names.Add(1, "Brendan");
            names.Add(2, "Kyle");
            names.Add(3, "Noah");
            names.Add(4, "Thomas");

            foreach(object obj in names)
            {
                Console.Write(obj);
            }
            foreach(KeyValuePair<int, string> kvp in names)
            {
                Console.WriteLine("Key : " + kvp.Key);
                Console.WriteLine("Value : " + kvp.Value);
            }

            Dictionary<string, string> listOfCities = new Dictionary<string, string>()
            {
                {"USA", "Chicago, Portland, Seattle, Austin, Houston, SFO" },
                {"Germany", "Saarbrucken, Frankfurt, Dresden" }
            };
            
            foreach (KeyValuePair<string, string> kvp in listOfCities)
            {
                Console.WriteLine("Key :  {0} , Value : {1}" , kvp.Key, kvp.Value);
              
            }

            // Search with a KEY?
            Console.WriteLine(listOfCities["USA"]);
            // Update the value?
            listOfCities["USA"] = "Chicago, Portland, Seattle, Austin, Houston, SFO, Arizona, Newyork";
            Console.WriteLine(listOfCities["USA"]);
        }*/
    }
}
