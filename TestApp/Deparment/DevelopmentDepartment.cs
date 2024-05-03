using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.Deparment
{
    public class DevelopmentDepartment : Department
    {
        public DevelopmentDepartment() : base("Отдел разработки")
        {
        }

        public override string PerformTask()
        {
            return "Работа отдела разработки";
        }

    }
}
