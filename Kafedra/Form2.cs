using Kafedra.All_Tables;
using Kafedra.Context;
using Kafedra.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kafedra
{
    public partial class Form2 : Form
    {
        ApplicationDb db = new ApplicationDb();
        Employee employee = new Employee();
        public Form2()
        {
            InitializeComponent();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void allTablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void directionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DirectionDb f = new DirectionDb();
            f.Show();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeDB f = new EmployeeDB();
            f.Show();
        }

        private void subjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SubjectDb f = new SubjectDb();
            f.Show();
        }

        private void shapeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShapeDb ff = new ShapeDb();
            ff.Show();
        }

        private void chairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChairDB f = new ChairDB();
            f.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            switch (comboBox1.Text)
            {
                case "Employees":dataGridView1.DataSource = db.Employees.ToList();break;
                case "Directions":dataGridView1.DataSource = db.Directions.ToList();break;
                case "Subjects": dataGridView1.DataSource = db.Subjects.ToList();break;
                case "Chairs": dataGridView1.DataSource = db.Chairs.ToList();break;
                default:
                    break;
            }
        }
    }
}
