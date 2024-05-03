using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.Deparment
{
    public class HRDepartment : Department
    {
        public HRDepartment() : base("HR отдел")
        {
        }

        public override string PerformTask()
        {
            return "Работа HR отдела";
        }

    }
}
