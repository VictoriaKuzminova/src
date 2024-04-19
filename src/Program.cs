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


    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
