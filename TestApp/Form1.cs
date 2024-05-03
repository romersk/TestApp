using TestApp.Deparment;
using TestApp.Employees;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TestApp
{
    public partial class Form1 : Form
    {
        private Dictionary<string, Employee> em = new Dictionary<string, Employee>();
        private Company company;
        public Form1()
        {
            InitializeComponent();
            position.Items.AddRange(new string[] { "HR ��������", "�����������", "��������" });
            company = new Company();
        }

        public Company GetCompany()
        {
            return company;
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            string name = nameAdd.Text;
            string age = ageAdd.Text;
            if (name.Length > 0 && position.SelectedIndex > -1 && age.Length > 0)
            {
                Employee? employee = null;
                switch (position.SelectedItem.ToString())
                {
                    case "�����������":
                        {
                            employee = new Developer(name, Convert.ToInt32(age));
                            company.DevelopmentDepartment.AddEmployee(employee);
                            break;
                        }
                    case "��������":
                        {
                            employee = new Manager(name, Convert.ToInt32(age));
                            company.ManagementDepartment.AddEmployee(employee);
                            break;
                        }
                    case "HR ��������":
                        {
                            employee = new HRManager(name, Convert.ToInt32(age));
                            company.HRDepartment.AddEmployee(employee);
                            break;
                        }
                }

                em.Add(name, employee);
                refreshListBox();
                nameAdd.Clear();
                ageAdd.Clear();
                position.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("������� �� ��� ������");
            }
        }

        private void refreshListBox()
        {
            list.Items.Clear();
            foreach (var employee in em.Values)
            {
                list.Items.Add(employee.GetName() + ", " + employee.GetAge() + " - " + employee.GetPosition());
            }
        }

        private void ageNum(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void hoursNum(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            string name = nameCalc.Text;
            string hours = hoursCald.Text;
            if (name.Length > 0 && hours.Length > 0)
            {
                if (em.ContainsKey(name))
                {
                    Employee employee;
                    em.TryGetValue(name, out employee);
                    if (employee != null)
                    {
                        employee.SetHours(Convert.ToInt32(hours));
                        MessageBox.Show("�������� ���������� " + employee.GetName() + " - " + employee.CalculateSalary() + "$");
                        nameCalc.Clear();
                        hoursCald.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("������ ������������ ���");
                }
            }
            else
            {
                MessageBox.Show("������� �� ��� ������");
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string name = nameDelete.Text;
            if (name.Length > 0)
            {
                if (em.ContainsKey(name))
                {
                    Employee employee;
                    em.TryGetValue(name, out employee);
                    if (employee != null)
                    {
                        switch (employee.GetPosition())
                        {
                            case "�����������":
                                {
                                    company.DevelopmentDepartment.DeleteEmployee(employee);
                                    break;
                                }
                            case "��������":
                                {
                                    company.ManagementDepartment.DeleteEmployee(employee);
                                    break;
                                }
                            case "HR ��������":
                                {
                                    company.HRDepartment.DeleteEmployee(employee);
                                    break;
                                }
                        }
                    }
                    em.Remove(name);
                    refreshListBox();
                    nameDelete.Clear();
                }
                else
                {
                    MessageBox.Show("������ ������������ ���");
                }
            }
            else
            {
                MessageBox.Show("������� �� ��� ������");
            }
        }

        public void button4_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2(this);
            newForm.ShowDialog();
        }
    }
}
