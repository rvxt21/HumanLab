using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Teacher:Human
    {

        private int maxNumOfStudent;
        private List<Student> ThisTeacherStudent;
        public Teacher(int maxNumOfStudent,string name, string surname, int age, Addres addres) : base(name, surname, age, addres)
        {
            this.maxNumOfStudent = maxNumOfStudent;
            ThisTeacherStudent = new List<Student>(maxNumOfStudent);
        }
       public int GetmaxNumOfStudent()
        {
            return this.maxNumOfStudent;
        }
        public void SetmaxNumOfStudent(int maxNum)
        {
            this.maxNumOfStudent = maxNum;
        }
        public List<Student> GetThisTeacherStudent()
        {
            return this.ThisTeacherStudent;
        }
        public void SetThisTeacherStudent(List<Student> students)
        {
            this.ThisTeacherStudent = students;
        }
        public void AddThisTeacherStudent(Student student)
        {
            if (ThisTeacherStudent.Count == maxNumOfStudent)
            {
                Console.WriteLine("Count of students wrong");
            }
            else
            {
                ThisTeacherStudent.Add(student);
            }
        }
        public string InfoTeacherToString()
        {
            return($"{base.GetInfo()}\nNum of students:{maxNumOfStudent}");
        }
    }
}
