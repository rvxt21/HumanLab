using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Human
    {

            protected string name;
            protected int age;
            protected Addres addres;
            protected Mark avarage;

            public Human(string name, int age, Addres addres, Mark avarage)
            {
                this.name = name;
                this.age = age;
                this.addres = addres;
                this.avarage = avarage;
            }

            public Addres Addres { get { return addres; } set { addres = value; } }
            public Mark Avarage { get { return avarage; } set { avarage = value; } }
            public string GetInfo()
            {
                return ($"Name:{name}\nAge:{age}\nAddres:{addres.Street}\nAvarage:{avarage}");
            }

            public String Name { get { return name; } set { name = value; } }
    }
}

