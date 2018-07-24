using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapReduce
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }

        public Employee(int id, string name, int age, double salary)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
            this.Salary = salary;
        }
    }
}
