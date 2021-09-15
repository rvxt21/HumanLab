using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Addres add1 = new Addres("Kherson","Universitetska",12);
            Mark mark1 = new Mark(4);
            Student studen1 = new Student(231, "Anastasia", 18, add1,mark1);
            Console.WriteLine(studen1.getAllInformation());
            Console.ReadLine();
        }
    }
}

