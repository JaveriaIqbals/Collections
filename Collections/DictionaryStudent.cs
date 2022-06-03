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
    internal class DictionaryStudent
    {
        public static void Main(string [] args)
        {
            Dictionary<int, Student> studentDictionary = new Dictionary<int, Student>();
            Student[] students =
            {
                new Student("ABC" , 1, new string [] {"Science", "Arts" }, "Science"),
                new Student("DEF" , 2, new string [] {"Maths", "Woodwork" }, "Maths")
            };

            foreach(Student s in students)
            {
                // Key and Value pair : studentID and Value is student object
                studentDictionary.Add(s.studentID, s); 
            }

            /*Student s1 = studentDictionary[0];
            Console.WriteLine(s1.studentID);
            Console.WriteLine(s1.name);
            Console.WriteLine(s1.major);
            string [] subjects = s1.subjects;
            foreach(string subject in subjects)
                Console.WriteLine(subject);
            */
            Console.WriteLine(studentDictionary[1].name);
            Console.WriteLine(studentDictionary[1].studentID);
            Console.WriteLine(studentDictionary[1].major);
            string[] subjects = studentDictionary[1].subjects;
            foreach (string subject in subjects)
                Console.WriteLine(subject);
            
        }
    }
}
