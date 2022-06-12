using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kafedra.Models
{
    public class Employee
    {
        public int id { get; set; }
        //[Key]
        //[StringLength(30)]
        public string first_name { get; set; }
        //[Key]
        //[StringLength(50)]
        public string last_name { get; set; }
        //[Key]
        //[StringLength(50)]
        public string middle_name { get; set; }

        public bool gender { get; set; }
        public DateTime birthday { get; set; }
        //[Key]
        //[StringLength(500)]
        public string address { get; set; }
        //[Key]
        //[StringLength(13)]
        public string phone { get; set; }
        //[Key]
        //[StringLength(30)]
        public string degree { get; set; }

    }
}
