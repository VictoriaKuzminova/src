using System;
using System.Collections.Generic;
using System.IO;
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
            var newStudent = students.OrderBy(x => x.Surname).ThenBy(x => x.Name).ToArray();

            return newStudent;
        }

        public void WriteFile(string file, Student[] students)
        {
            using (StreamWriter wr = new StreamWriter(File.Open(file, FileMode.Open)))
            {
                foreach (Student student in students)
                {
                    wr.Write(student.Surname);
                    wr.Write(student.Name);
                    wr.Write(student.NumZachetka);
                }
                Console.WriteLine("Информация успешно записана в файл!");
            }
        }
    }

    class Program
    {
        public static Student AddStudent(string surname, string name, int numZach)
        {
            Student student= new Student(surname, name, numZach);
            return student;
        }

        static void Main(string[] args)
        {
            int count = 0;
            while (true)
            {
                try
                {
                    Console.Write("Введите кол-во студентов для обработки из диапазона от 1 до 20: ");
                    count = int.Parse(Console.ReadLine());
                    if ((count < 1) || (count > 20)) { throw new Exception(); }
                    break;
                }
                catch { }
            }

            

        }
    }
}
