using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.Employees
{
    internal class Developer : Employee
    {
        private double coeff;
        public Developer(string name, int age) : base(name, age, "Разработчик")
        {
            this.coeff = 2.0;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("Additional information for Manager");
        }

        public override double CalculateSalary()
        {
            return base.CalculateSalary() * coeff;
        }
    }
}
