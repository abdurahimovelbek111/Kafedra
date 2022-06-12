using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kafedra.Models
{
    public class Direction_Subject
    {
        public int id { get; set; }
        public Direction direction_id { get; set; }
        public Subject Subject_id { get; set; }
    }
}
