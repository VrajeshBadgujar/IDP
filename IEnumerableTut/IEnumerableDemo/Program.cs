using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableDemo
{
   public class Student
    {
        public int id { get; set; }
        public string name { get; set; }
        public int standard { get; set; }
    }

    public class School : IEnumerable
    {
        List<Student> students = new List<Student>();

        public void Add(Student s)
        {
            students.Add(s);
        }

        public IEnumerator GetEnumerator()
        {
            //return ((IEnumerable)students).GetEnumerator();
            return students.GetEnumerator();
        }
    }


    internal class Program
    {

        static void Main(string[] args)
        { 
            
          Student s1 = new Student();  
            s1.id = 1;
            s1.name = "Ali";
            s1.standard = 12;

            Student s2 = new Student();
            s2.id = 2;
            s2.name = "Vrajesh";
            s2.standard = 10;

            List<Student> students = new List<Student>();
            students.Add(s1);
            students.Add(s2);

            foreach (Student s in students)
            {
                //Console.WriteLine(s.id +" "+s.name+" "+s.standard);
            }

            
            School school = new School();   
            school.Add(s1);
            school.Add(s2);

            foreach (Student s in school)
            {
                Console.WriteLine(s.id + " " + s.name + " " + s.standard);
            }

        }
    }
}
