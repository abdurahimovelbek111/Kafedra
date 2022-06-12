using Kafedra.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kafedra.Context
{
    public class ApplicationDb:DbContext
    {
        public ApplicationDb()
           : base("name=kafedra")
        {

        }
        public virtual DbSet<Chair> Chairs { get; set; }
        public virtual DbSet<Chair_Employee> Chair_Employees { get; set; }
        public virtual DbSet<Direction> Directions { get; set; }
        public virtual DbSet<Direction_Subject> Direction_Subjects { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Shape> Shapes { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<Models.Subject_Employee> GetSubject_Employees { get; set; }
    }
}
