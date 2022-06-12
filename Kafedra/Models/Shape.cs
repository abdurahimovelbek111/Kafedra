using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kafedra.Models
{
    public class Shape
    {
        public int id { get; set; }        
        [StringLength(200)]
        public string name { get; set; }
    }
}
