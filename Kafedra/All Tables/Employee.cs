using Kafedra.Context;
using Kafedra.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
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
                string g;
                if (radioButton1.Checked == true)
                {
                    g = "True";
                }
                else
                {
                    g = "False";
                }

                employee.first_name = DirName.Text;
                    employee.last_name = textBox1.Text;
                    employee.middle_name = textBox2.Text;

                    employee.gender = bool.Parse(g);
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
            else
            {
                MessageBox.Show("Iltimos qaytadan ko'rib chiqing ma'lumot to'liqligiga!!!!!!");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            switch (comboBox2.Text)
            {
                case "First Name": dataGridView1.DataSource = db.Employees.Where(x => x.first_name.Contains(textBox4.Text)).ToList(); break;
                case "Last Name": dataGridView1.DataSource = db.Employees.Where(x => x.last_name.Contains(textBox4.Text)).ToList(); break;
                case "Middil Name": dataGridView1.DataSource = db.Employees.Where(x => x.middle_name.Contains(textBox4.Text)).ToList(); break;
                // case "Gender": dataGridView1.DataSource = db.Employees.Where(x => x.gender.Equals(textBox4.Text)).ToList();  break;
                // case "Birthday": dataGridView1.DataSource = db.Employees.Where(x => x.birthday.Equals(DateTime.Parse(textBox4.Text))).ToList(); break;
                case "Location": dataGridView1.DataSource = db.Employees.Where(x => x.address.Contains(textBox4.Text)).ToList(); break;
                case "Phone": dataGridView1.DataSource = db.Employees.Where(x => x.phone.Contains(textBox4.Text)).ToList(); break;
                case "Degree": dataGridView1.DataSource = db.Employees.Where(x => x.degree.Contains(textBox4.Text)).ToList(); break;
                default:
                    break;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            Read();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < -1)
                return;
            if (dataGridView1.CurrentRow.Index != -1)
            {
                employee.id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
                employee = db.Employees.Where(x => x.id == employee.id).FirstOrDefault();
                DirName.Text = employee.first_name;
                textBox1.Text = employee.last_name;
                textBox2.Text = employee.middle_name;
                if(bool.Parse(db.Employees.Where(x => x.middle_name.Contains("o'g'li")).ToString()) ==true)
                {
                    radioButton1.Checked = true;
                }
                if (bool.Parse(db.Employees.Where(x => x.middle_name.Contains("qizi")).ToString()) == true)
                {
                    radioButton2.Checked = false;
                }
                dateTimePicker1.Text =employee.birthday.ToString();
                richTextBox1.Text = employee.address;
                textBox3.Text = employee.phone;
                richTextBox2.Text = employee.degree;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            employee.first_name = DirName.Text.Trim();
            employee.last_name = textBox1.Text.Trim();
            employee.middle_name = textBox2.Text.Trim();

            //employee.gender =bool.Parse(radioButton1.Text.ToString().Trim());
            employee.birthday = DateTime.Parse(dateTimePicker1.Text.Trim());
            employee.address = richTextBox1.Text.Trim();
            employee.phone = textBox3.Text.Trim();
            employee.degree = richTextBox2.Text.Trim();
            if (employee.id == 0)
                db.Employees.Add(employee);
            else
                db.Entry(employee).State = EntityState.Modified;
            db.SaveChanges();
            MessageBox.Show("Malimot yangilandii");
            Read();
        }
    }
}

