using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src
{
    public class Student
    {
        public string Surname;
        public string Name;
        public int NumZachetka;

        public Student(string surname, string name, int numZachetka)
        {
            Surname = surname;
            Name = name;
            NumZachetka = numZachetka;
        }
    }

    public class DeansOffice
    {
        public Student[] students;

        public Student[] SortStudent(Student[] students)
        {
            var newStudent = students.OrderBy(x => x.Surname).ThenBy(x=>x.Name).ToArray();

            return newStudent;
        }



    }


    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
