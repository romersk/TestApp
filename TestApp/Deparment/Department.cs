using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp.Employees;

namespace TestApp.Deparment
{
    public abstract class Department
    {
        private string Name;
        private List<Employee> Employees;

        public Department(string name)
        {
            Name = name;
            Employees = new List<Employee>();
        }

        public abstract string PerformTask();

        public void DeleteEmployee(Employee employee)
        {
            Employees.Remove(employee);
        }

        public void AddEmployee(Employee employee) { Employees.Add(employee); }

        public List<Employee>  GetEmployees() { return Employees; }
    }
}
