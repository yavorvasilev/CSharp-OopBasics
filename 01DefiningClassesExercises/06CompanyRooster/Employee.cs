namespace _06CompanyRooster
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Employee
    {
        public Employee(string name, decimal salary, string position, string department)
        {
            this.name = name;
            this.salary = salary;
            this.position = position;
            this.department = department;
            this.age = -1;
            this.email = "n/a";
        }

        public string name;
        public decimal salary;
        public string position;
        public string department;
        public string email;
        public int age;
    }
}
