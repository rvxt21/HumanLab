using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Student:Human
    {
        private string faculty;
        private int group;
        private float avarageMark;
        public Student(string faculty,int group,float avarageMark,string name,string surname,int age,Addres add):base(name,surname,age,add)
        {
            this.faculty = faculty;
            this.group = group;
            this.avarageMark = avarageMark;
        }
        public string Faculty {  get { return faculty; } set { faculty = value; } }
        public int Group { get { return group; } set { group = value; } }
        public float AvarageMark { get { return avarageMark; } set { avarageMark = value; } }
        public string getAllInformation()
        {
             return ($"Faculty:{faculty}\nGroup:{group.ToString()}\nAvarage mark:{avarageMark.ToString()}\n{base.GetInfo()}");
        }
    }
}
