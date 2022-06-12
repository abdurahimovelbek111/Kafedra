using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kafedra.Models
{
    public class Subject_Employee
    {
        public int id { get; set; }
        public Subject subject_id { get; set; }
        public Employee employee_id { get; set; }
    }
}
