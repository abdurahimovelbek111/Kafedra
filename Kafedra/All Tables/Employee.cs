using Kafedra.Context;
using Kafedra.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Windows.Forms;

namespace Kafedra.All_Tables
{
    public partial class EmployeeDB : Form
    {
        ApplicationDb db = new ApplicationDb();
        Employee employee = new Employee();

        public EmployeeDB()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        public void Read()
        {
            dataGridView1.DataSource = db.Employees.ToList<Employee>();
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Employee_Load(object sender, EventArgs e)
        {
            Read();

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (DirName.Text.Length != 0 && textBox1.Text.Length != 0 && textBox2.Text.Length != 0 && radioButton1.Text.Length != 0 && richTextBox1.Text.Length != 0 && textBox3.Text.Length != 0 && richTextBox2.Text.Length != 0 && dateTimePicker1.Text.Length != 0
                 || DirName.Text.Length != 0 && textBox1.Text.Length != 0 && textBox2.Text.Length != 0 && radioButton1.Text.Length != 0 && richTextBox1.Text.Length != 0 && textBox3.Text.Length != 0 && richTextBox2.Text.Length != 0 && dateTimePicker1.Text.Length != 0)
            {

                if (radioButton1.Checked.ToString() == "True")
                {
                        employee.first_name = DirName.Text;
                        employee.last_name = textBox1.Text;
                        employee.middle_name = textBox2.Text;

                        employee.gender = radioButton1.Checked;
                        employee.birthday = DateTime.Parse(dateTimePicker1.Text);
                        employee.address = richTextBox1.Text;
                        employee.phone = textBox3.Text;
                        employee.degree = richTextBox2.Text;
                        db.Employees.Add(employee);
                        db.SaveChanges();
                        MessageBox.Show("Ma'lumot qushildi!!!!!!");
                        Read();
                        textBox1.Text = "";
                    
                }
                if (radioButton2.Checked.ToString() == "True")
                {
                    employee.first_name = DirName.Text;
                    employee.last_name = textBox1.Text;
                    employee.middle_name = textBox2.Text;
                    employee.gender = radioButton2.Checked;
                    employee.birthday = DateTime.Parse(dateTimePicker1.Text);
                    employee.address = richTextBox1.Text;
                    employee.phone = textBox3.Text;
                    employee.degree = richTextBox2.Text;
                    db.Employees.Add(employee);
                    db.SaveChanges();
                    MessageBox.Show("Ma'lumot qushildi!!!!!!");
                    Read();
                    textBox1.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Iltimos qaytadan ko'rib chiqing ma'lumot to'liqligiga!!!!!!");
            }
        }
    }
}
