using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Student:Human
    {
        private int group;
        public Student(int group,string name,int age,Addres add,Mark avarage):base(name,age,add,avarage)
        {
            this.group = group;
            
        }
        public int Group { get { return group; } set { group = value; } }
        
        public string getAllInformation()
        {
            return base.GetInfo() + group.ToString();
        }
    }
}
