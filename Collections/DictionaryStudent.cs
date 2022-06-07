using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Student
    {
        public string name;
        public int studentID;
        public string[] subjects;
        public string major;
        
        public Student(string name, int id, string [] subjects, string major)
        {
            this.name = name;
            this.studentID = id;
            this.subjects = subjects;
            this.major = major;
        }
        public string GetMajor(int stdID)
        {
            // It should search for that stdID in the Dictionary, and then return major
            return this.major;
        }

    }

    // Dictionary is a generic a data structure
    // Type Safe as well
    internal class DictionaryStudent
    {
        /*public static void Main(string [] args)
        {
            Dictionary<int, Student> studentDictionary = new Dictionary<int, Student>();
            Student[] students =
            {
                new Student("ABC" , 1, new string [] {"Science", "Arts" }, "Science"),
                new Student("DEF" , 2, new string [] {"Maths", "Woodwork" }, "Maths"),
                new Student("GHI" , 3, new string [] {"Science", "Computer" }, "Fine Arts"),
                new Student("JKL" , 4, new string [] {"Maths", "Chemistry" }, "Physics")
            };

            foreach(Student s in students)
            {
                // Key and Value pair : studentID and Value is student object
                studentDictionary.Add(s.studentID, s); 
            }

            Student s1 = studentDictionary[0];
            Console.WriteLine(s1.studentID);
            Console.WriteLine(s1.name);
            Console.WriteLine(s1.major);
            string [] subjects = s1.subjects;
            foreach(string subject in subjects)
                Console.WriteLine(subject);
            

            // Search a Student according to the Key value.
            Console.WriteLine(studentDictionary[1].name);
            Console.WriteLine(studentDictionary[1].studentID);
            Console.WriteLine(studentDictionary[1].major);
            string[] subjects = studentDictionary[1].subjects;
            foreach (string subject in subjects)
                Console.WriteLine(subject);

            // If a student is existing or not
            int key = 2;
            if(studentDictionary.ContainsKey(key)) // check for TRUE
            {
                Student s = studentDictionary[key];
                Console.WriteLine(s.name);
                Console.WriteLine(s.major);
            }

            // Fetching <key, value> from Student Dictionary
            // KeyValuePair<int, Student> kvp = studentDictionary.ElementAt(0); // 1st record
            var kvp =  studentDictionary.ElementAt(0);
            Console.WriteLine(kvp.Key);
            Console.WriteLine(kvp.Value.name);
            Console.WriteLine(kvp.Value.major);

            // Print all Student Records
            Student temp;
            for (int i = 1; i <= studentDictionary.Count; i++)
            {
                temp = studentDictionary[i]; //?
                Console.WriteLine("Name : " + temp.name);
                Console.WriteLine("Major : " + temp.major);
                Console.WriteLine("Subjects Taken : ");
                foreach(string s in temp.subjects)
                {
                    Console.Write(s + "  ,  ");
                }
                
                // How to remove a student from Dictionary?

            }
        }*/
    }
}
