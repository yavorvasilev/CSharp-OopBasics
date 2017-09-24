namespace _06CompanyRooster
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartingProgram
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var emplyees = new List<Employee>();

            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine().Split();
                var employee = new Employee(tokens[0], decimal.Parse(tokens[1]), tokens[2], tokens[3]);

                if (tokens.Length == 5)
                {
                    int age;
                    if (int.TryParse(tokens[4], out age))
                    {
                        var email = "n/a";
                        employee.email = email;
                        employee.age = age;
                    }
                    else
                    {
                        var email = tokens[4];
                        employee.email = email;
                        employee.age = -1;
                    }

                }
                else if (tokens.Length == 6)
                {
                    var email = tokens[4];
                    var age = int.Parse(tokens[5]);
                    employee.email = email;
                    employee.age = age;
                }


                emplyees.Add(employee);
            }

            var res = emplyees.GroupBy(e => e.department)
                .Select(e => new
                {
                    Department = e.Key,
                    Average = e.Average(emp => emp.salary),
                    Employees = e.OrderByDescending(emp => emp.salary)
                })
                .OrderByDescending(a => a.Average)
                .FirstOrDefault();

            Console.WriteLine(  );

            Console.WriteLine($"Highest Average Salary: {res.Department}");

            foreach (var employee in res.Employees)
            {
                Console.WriteLine($"{employee.name} {employee.salary:F2} {employee.email} {employee.age}");
            }
            Console.WriteLine();
        }
    }
}
