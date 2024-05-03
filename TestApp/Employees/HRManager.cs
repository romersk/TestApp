using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.Employees
{
    internal class HRManager : Employee
    {
        private double coeff;
        public HRManager(string name, int age) : base(name, age, "HR Менеджер")
        {
            this.coeff = 1.5;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("Это новая информация о HR Менеджере");
        }

        public override double CalculateSalary()
        {
            return base.CalculateSalary() * coeff;
        }
    }
}
