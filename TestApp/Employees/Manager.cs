using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.Employees
{
    internal class Manager : Employee
    {

        private double coeff;
        public Manager(string name, int age) : base(name, age, "Менеджер")
        {
            this.coeff = 1.6;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("Это дополнительная информация о менеджере");
        }

        public override double CalculateSalary()
        {
            return base.CalculateSalary() * coeff;
        }
    }
}
