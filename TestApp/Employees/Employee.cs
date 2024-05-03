using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.Employees
{
    public class Employee
    {
        private string name;
        private int age;
        private string position;
        private double baseStuff;
        private int hours;
        

        public Employee(string name, int age, string position)
        {
            this.name = name;
            this.age = age;
            this.position = position;
            this.baseStuff = 2.5;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Имя: {name}, Возраст: {age}, Позиция: {position}");
        }

        public virtual double CalculateSalary()
        {
            return baseStuff * hours;
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public int GetAge()
        {
            return age;
        }

        public void SetAge(int age)
        {
            this.age = age;
        }

        public string GetPosition()
        {
            return position;
        }

        public void SetPosition(string position)
        {
            this.position = position;
        }

        public void SetHours(int hours)
        {
            this.hours = hours;
        }


    }
}
