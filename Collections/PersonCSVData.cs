using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Person
    {
        public int ssn;  
        public string name;
        public int age;
        
        public Person(int ssn, string name, int age)
        {
            this.ssn = ssn;
            this.name = name;
            this.age = age;
        }
        public Person()
        {
            this.ssn = 0;
            this.name = "";
            this.age = 0;   
        }

    }


    internal class PersonCSVData
    {
        public static List<Person> LoadData(string filename)
        {
            List<Person> personList = new List<Person>();

            // I will read line by line, and then I will skip commas
            var lines = File.ReadAllLines(filename).ToList();

            // Remove Header
            lines.RemoveAt(0);

            //Person pObj;
            foreach (var line in lines)
            {
                string[] temp = line.Split(','); // 101  abc  10
                Person pObj = new Person();
                pObj.ssn = int.Parse(temp[0]); // string to int conversion
                pObj.name = temp[1];
                pObj.age = int.Parse(temp[2]);
                personList.Add(pObj);
            }    
            return personList;
        }
        public static void StoreData(List<Person> list)
        {
            string[] rows = new string [list.Count+1]; // make it 5 including header data
            rows[0] = "SSN, NAME, AGE";

            //List<string> lines = new List<string>();
            //lines.Add("SSN, NAME, AGE");
            int i = 1;
            foreach (Person person in list)
            {
                rows[i] = person.ssn + "," + person.name + "," + person.age;
                i++;
                //lines.Add($"{person.ssn}, {person.name}, {person.age}");
            }
            
            File.WriteAllLines("new.csv", rows); // filename , string []
        }
        public static void ReadWrite()
        {
            List<Person> personList = LoadData("Book1.csv");
            foreach(var person in personList)
            {
                Console.WriteLine($"{person.ssn}, {person.name}, {person.age}");
            }

            // Writing into the file 
            StoreData(personList);

        }
        public static void Main(string [] args)
        {
            // ssn, name, age
            // 1001, abc, 20

            ReadWrite();

        }
    }
}
