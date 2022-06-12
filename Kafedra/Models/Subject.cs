using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kafedra.Models
{
    public class Subject
    {
        public int id { get; set; }
        //[Key]
        //[StringLength(200)]
        public string name { get; set; }
        public int all_hour { get; set; }
        public int lecture { get; set; }
        public int practice { get; set; }
        public int mustaqil_hour { get; set; }
        public int labor_mash { get; set; }
        public int seminar { get; set; }
        public int course_work { get; set; }
    }
}
