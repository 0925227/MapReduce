using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapReduce
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] Employees = new Employee[]
            {
                new Employee(1, "John Doe", 40, 3000),
                new Employee(2, "Naam 2", 28, 2500),
                new Employee(3, "Naam 3", 35, 2800),
                new Employee(4, "Naam 4", 24, 2000)
            };

            //foreach (var item in Employees)
            //{
            //    Console.WriteLine(item.Id);
            //    Console.WriteLine(item.Name);
            //    Console.WriteLine(item.Age);
            //    Console.WriteLine(item.Salary);
            //}


            var data = MapReduce.Map(Employees,
                employee =>
                {
                    return new
                    {
                        Name = employee.Name,
                        Age = employee.Age
                    };
                });

            //foreach (var item in data)
            //{
            //    Console.WriteLine(item.Name);
            //    Console.WriteLine(item.Age);
            //}


            var filter = MapReduce.Where(Employees, e => e.Salary > 2500);
            var data2 = MapReduce.Map(filter,
                employee =>
                {
                    return new
                    {
                        Name = employee.Name,
                        Age = employee.Age
                    };
                });

            //foreach (var item in data2)
            //{
            //    Console.WriteLine(item.Name);
            //    Console.WriteLine(item.Age);
            //}
        }
    }
}
