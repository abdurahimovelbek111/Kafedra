﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kafedra.Models
{
    public class Chair
    {
        public int id { get; set; }
        //[Key]
        //[StringLength(300)]
        public string name { get; set; }
    }
}