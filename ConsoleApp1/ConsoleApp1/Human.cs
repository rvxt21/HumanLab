using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Human
    {

            protected string name;
            protected string surname;
            protected int age;
            protected Addres addres;
           

            public Human(string name,string surname, int age, Addres addres)
            {
                this.name = name;
                this.surname = surname;
                this.age = age;
                this.addres = addres;
                
            }

            public Addres Addres { get { return addres; } set { addres = value; } }
            
            public string GetInfo()
            {
                return ($"Name:{name}\nSurname:{surname}\nAge:{age}\n\tAddres:{addres.AddresToString()}\n");
            }

            public string Name { get { return name; } set { name = value; } }
            public string Surname {  get { return surname; } set { surname = value; } }
            public int Age { get { return age; } set { age = value; } }
    }
}

