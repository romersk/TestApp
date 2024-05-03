using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.Deparment
{
    public class ManagementDepartment : Department
    {
        public ManagementDepartment() : base("Отдел менеджмента")
        {
        }

        public override string PerformTask()
        {
            return "Работа отдела менеджмента";
        }
    }
}
