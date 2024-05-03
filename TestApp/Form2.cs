using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestApp.Employees;

namespace TestApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(Form1 form1)
        {
            InitializeComponent();
            Company company = form1.GetCompany();
            foreach (var employee in company.HRDepartment.GetEmployees())
            {
                listBoxHR.Items.Add(employee.GetName() + ", " + employee.GetAge() + " - " + employee.GetPosition());
            }
            foreach (var employee in company.DevelopmentDepartment.GetEmployees())
            {
                listBoxDevelopers.Items.Add(employee.GetName() + ", " + employee.GetAge() + " - " + employee.GetPosition());
            }
            foreach (var employee in company.ManagementDepartment.GetEmployees())
            {
                listBoxManager.Items.Add(employee.GetName() + ", " + employee.GetAge() + " - " + employee.GetPosition());
            }
        }
    }
}
