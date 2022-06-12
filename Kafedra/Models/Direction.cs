using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kafedra.Models
{
    public class Direction
    {
        public int id { get; set; }
       
        [StringLength(300)]
        public string name { get; set; }
      
        [StringLength(200)]
        public string code { get; set; }
  
        [StringLength(50)]
        public string language { get; set; }
       
        [StringLength(500)]
        public string type { get; set; }

        public int course { get; set; }
        public int semistir { get; set; }
        Shape shape_id { get; set; }
        Chair chair_id { get; set; }
    }
}
