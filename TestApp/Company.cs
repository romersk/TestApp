using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp.Deparment;
using TestApp.Employees;

namespace TestApp
{
    public class Company
    {
        private DevelopmentDepartment developmentDepartment;
        private HRDepartment hrDepartment;
        private ManagementDepartment managementDepartment;

        public Company()
        {
            this.developmentDepartment = new DevelopmentDepartment();
            this.hrDepartment = new HRDepartment();
            this.managementDepartment = new ManagementDepartment();
        }

        public DevelopmentDepartment DevelopmentDepartment { get {  return developmentDepartment; } }
        public HRDepartment HRDepartment { get { return hrDepartment; } }
        public ManagementDepartment ManagementDepartment { get { return managementDepartment; } }
    }
}
