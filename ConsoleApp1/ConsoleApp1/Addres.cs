using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Addres
    {
        private string city;
        private string street;
        private int house;

        public Addres(string city, string street, int house)
        {
            this.city = city;
            this.street = street;
            this.house = house;
        }
        public Addres()
        {
            Console.WriteLine("Enter city:");
            city = Console.ReadLine();
            Console.WriteLine("Enter street:");
            street = Console.ReadLine();
            Console.WriteLine("Enter house:");
            house = Convert.ToInt32(Console.ReadLine());
        }
        public string City { get { return city; } set { city = value; } }
        public string Street { get { return street; } set { street = value; } }
        public int House{get { return house; } set { house = value; } }
        public void GetInfoAddres()
        {
            Console.WriteLine($"City:{city}\nStreet{street}\nHouse{house}");
        }
        public string AddresToString()
        {
            return (city + " " + street+" "+house.ToString()); 
        }
    }
}
