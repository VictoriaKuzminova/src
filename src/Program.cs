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

        public void WriteFile( Student[] students)
        {
            using (StreamWriter wr = new StreamWriter("data.txt", false, System.Text.Encoding.UTF8))
            {
                foreach (Student student in students)
                {
                    wr.WriteLine(student.Surname+";"+ student.Name+";"+ student.NumZachetka);
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

        public static void Input(Student[] students)
        {

           for(int i=0;i<students.Length;i++)
            {
                Console.WriteLine( students[i].Surname);
                Console.WriteLine(students[i].Name);
            }
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

            Student[] students = new Student[count];

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Ввод информации о СТУДЕНТЕ № {i + 1}");
                Console.Write("\t- введите фамилию: ");
                var Surname = Console.ReadLine();
                Console.Write("\t- введите имя: ");
                var Name = Console.ReadLine();
                var NumZachetka = 0;
                while (true)
                {
                    try
                    {
                        Console.Write("\t- введите номер зачетки: ");
                        NumZachetka = int.Parse(Console.ReadLine());
                        if ((NumZachetka < 1)) { throw new Exception(); }
                        break;
                    }
                    catch { }
                }
                students[i] = AddStudent(Surname, Name, NumZachetka);
            }
            
            
            DeansOffice deansOffice = new DeansOffice();

            deansOffice.students = students;

            /*Input(deansOffice.SortStudent(students));
            Console.ReadLine();*/

            deansOffice.WriteFile( deansOffice.SortStudent(students));


        }
    }
}
