using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab03
{
    class Employee
    {
        // Fields
        private int id;
        private string name;
        private int age;
        private int salary;

        // Static counter
        private static int counter = 0;
        // Properties
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    name = "Unknown";
                else
                    name = value;
            }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        // Default Constructor
        public Employee() { counter++; }

        // Parameterized Constructor
        public Employee(int _id, string _name, int _age, int _salary)
        {
            id = _age;
            name =_name;
            age = _age;
            salary = _salary;
            counter++;
        }
        // diplay method
        public void Display()
        {
            Console.WriteLine($"ID: {id}, Name: {name}, Age: {age}, Salary: {salary}");
        }
        // Static method to get count
        public static int GetCount()
        {
            return counter;
        }
    }
}
