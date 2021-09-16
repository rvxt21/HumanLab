using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Addres add1 = new Addres("Kherson","Universitetska",12);
            Student studen1 = new Student("FCSPM",231,4, "Anastasia","K",18, add1);
            Console.WriteLine(studen1.getAllInformation());
            Addres add2 = new Addres("Kherson", "Molodizhna", 4);
            Teacher teacher1 = new Teacher(2, "Evgeniy", "Sergeev", 45, add2);
            Console.WriteLine(teacher1.InfoTeacherToString());
            Console.ReadLine();
        }
    }
}

