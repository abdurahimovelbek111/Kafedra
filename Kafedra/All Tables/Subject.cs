using Kafedra.Context;
using Kafedra.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kafedra.All_Tables
{
    public partial class SubjectDb : Form
    {
        ApplicationDb db = new ApplicationDb();
        Subject subject = new Subject();
        public SubjectDb()
        {
            InitializeComponent();
        }

        public void Read()
        {
            dataGridView1.DataSource = db.Subjects.ToList();
        }
        private void domainUpDown6_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void Subject_Load(object sender, EventArgs e)
        {
            Read();
            Result();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (DirName.Text.Length != 0 && textBox2.Text.Length != 0 && textBox3.Text.Length != 0 && textBox4.Text.Length != 0 && textBox5.Text.Length != 0 && textBox6.Text.Length != 0 && textBox7.Text.Length != 0 && textBox7.Text.Length != 0)
            {
                subject.name = DirName.Text;
                subject.all_hour = int.Parse(textBox1.Text);
                subject.lecture = int.Parse(textBox2.Text);
                subject.practice = int.Parse(textBox3.Text);
                subject.mustaqil_hour = int.Parse(textBox4.Text);
                subject.labor_mash = int.Parse(textBox5.Text);
                subject.seminar = int.Parse(textBox6.Text);
                subject.course_work = int.Parse(textBox7.Text);
                db.Subjects.Add(subject);
                db.SaveChanges();
                MessageBox.Show("Ma'lumot qushildi!!!!!!");
                Read();
                Result();
            }
            else
            {
                MessageBox.Show("Iltimos ma'lumot to'liqligini tekshiring!!!!");
            }
        }
        public void Result()
        {
            textBox9.Text = db.Subjects.Sum(x => x.all_hour).ToString();
            textBox10.Text = db.Subjects.Sum(x => x.lecture).ToString();
            textBox11.Text = db.Subjects.Sum(x => x.practice).ToString();
            textBox12.Text = db.Subjects.Sum(x => x.mustaqil_hour).ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            switch (comboBox2.Text)
            {
                case "Name": dataGridView1.DataSource = db.Subjects.Where(x => x.name.Contains(textBox4.Text)).ToList(); break;
                case " All_hour": dataGridView1.DataSource = db.Subjects.Where(x => x.all_hour.ToString().Contains(textBox4.Text)).ToList(); break;
                case "Lecture": dataGridView1.DataSource = db.Subjects.Where(x => x.lecture.ToString().Contains(textBox4.Text)).ToList(); break;
                case "Practice": dataGridView1.DataSource = db.Subjects.Where(x => x.practice.ToString().Contains(textBox4.Text)).ToList(); break;
                case "Mustaqil_hour": dataGridView1.DataSource = db.Subjects.Where(x => x.mustaqil_hour.ToString().Contains(textBox4.Text)).ToList(); break;
                case "Labor_mash": dataGridView1.DataSource = db.Subjects.Where(x => x.labor_mash.ToString().Contains(textBox4.Text)).ToList(); break;
                case "Seminar": dataGridView1.DataSource = db.Subjects.Where(x => x.seminar.ToString().Contains(textBox4.Text)).ToList(); break;
                case "Course_work": dataGridView1.DataSource = db.Subjects.Where(x => x.course_work.ToString().Contains(textBox4.Text)).ToList(); break;
                default:
                    break;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < -1)
                return;
            if (dataGridView1.CurrentRow.Index != -1)
            {
                subject.id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
                subject = db.Subjects.Where(x => x.id == subject.id).FirstOrDefault();
                DirName.Text = subject.name;
                textBox1.Text = subject.all_hour.ToString();
                textBox2.Text = subject.lecture.ToString();
                textBox3.Text = subject.practice.ToString();
                textBox4.Text = subject.mustaqil_hour.ToString();
                textBox5.Text = subject.labor_mash.ToString();
                textBox6.Text = subject.seminar.ToString();
                textBox7.Text = subject.course_work.ToString();
                textBox8.Text = subject.course_work.ToString();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            subject.name = DirName.Text.Trim();
            subject.all_hour = int.Parse(textBox1.Text.Trim());
            subject.lecture = int.Parse(textBox2.Text.Trim());
            subject.practice = int.Parse(textBox3.Text.Trim());
            subject.mustaqil_hour = int.Parse(textBox4.Text.Trim());
            subject.labor_mash = int.Parse(textBox5.Text.Trim()); 
            subject.seminar = int.Parse(textBox6.Text.Trim());
            subject.course_work = int.Parse(textBox7.Text.Trim());
            if (subject.id == 0)
                db.Subjects.Add(subject);
            else
                db.Entry(subject).State = EntityState.Modified;
            db.SaveChanges();
            MessageBox.Show("Malimot yangilandii");
            Read();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Haqiqatanam malimotni uchirmoqchimisiz", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var entity = db.Entry(subject);
                db.Subjects.Attach(subject);
                db.Subjects.Remove(subject);
                db.SaveChanges();
                MessageBox.Show("Students jadvalidan ma'limot uchirilmoqda");
                MessageBox.Show("Malimot uchirildii");
                Read();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
