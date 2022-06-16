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
    public partial class DirectionDb : Form
    {
        ApplicationDb db = new ApplicationDb();
        Direction direction = new Direction();
        public DirectionDb()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DirName.Text.Length != 0 && textBox1.Text.Length != 0 && comboBox1.Text.Length != 0 && comboBox2.Text.Length != 0 && comboBox3.Text.Length != 0 && comboBox4.Text.Length != 0)
            {
                direction.name = DirName.Text;
                direction.code = textBox1.Text;
                direction.language = comboBox1.Text;
                direction.type = comboBox2.Text;
                direction.course = int.Parse(comboBox3.Text);
                direction.semistir = int.Parse(comboBox4.Text);
                db.Directions.Add(direction);
                db.SaveChanges();
                MessageBox.Show("Ma'lumot qushildi!!!!!!");
                Read();
            }
            else
            {
                MessageBox.Show("Iltimos ma'lumot to'liqligini tekshiring!!!!");
            }

        }

        private void Direction_Load(object sender, EventArgs e)
        {
            Read();
        }
        public void Read()
        {
            dataGridView1.DataSource = db.Directions.ToList<Direction>();
        }

        private void button4_Click(object sender, EventArgs e)
        {

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
                direction.id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
                direction = db.Directions.Where(x => x.id == direction.id).FirstOrDefault();
                DirName.Text = direction.name;
                textBox1.Text = direction.code;
                comboBox1.Text = direction.language;
                comboBox2.Text = direction.type.ToString();
                comboBox3.Text = direction.course.ToString();
                comboBox4.Text = direction.semistir.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            direction.name = DirName.Text.Trim();
            direction.code= textBox1.Text.Trim();
            direction.language= comboBox1.Text.Trim();
            direction.type= comboBox2.Text.ToString().Trim();
            direction.course =int.Parse(comboBox3.Text.Trim());
            direction.semistir=int.Parse(comboBox4.Text.ToString().Trim());
            if (direction.id == 0)
                db.Directions.Add(direction);
            else
                db.Entry(direction).State = EntityState.Modified;
            db.SaveChanges();
            MessageBox.Show("Malimot yangilandii");
            Read();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Haqiqatanam malimotni uchirmoqchimisiz", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var entity = db.Entry(direction);
                db.Directions.Attach(direction);
                db.Directions.Remove(direction);
                db.SaveChanges();
                MessageBox.Show("Students jadvalidan ma'limot uchirilmoqda");
                MessageBox.Show("Malimot uchirildii");              
                Read();
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            switch (comboBox5.Text)
            {
                case "Name":dataGridView1.DataSource = db.Directions.Where(x => x.name.Contains(textBox5.Text)).ToList();break;
                case "Code": dataGridView1.DataSource = db.Directions.Where(x => x.code.Contains(textBox5.Text)).ToList();break;
                case "Language": dataGridView1.DataSource = db.Directions.Where(x => x.language.Contains(textBox5.Text)).ToList();break;
                case "Type": dataGridView1.DataSource = db.Directions.Where(x => x.type.Contains(textBox5.Text)).ToList();break;
                case "Course": dataGridView1.DataSource = db.Directions.Where(x => x.course.ToString().Contains(textBox5.Text)).ToList();break;
                case "Semistir": dataGridView1.DataSource = db.Directions.Where(x => x.semistir.ToString().Contains(textBox5.Text)).ToList();break;
                default:
                    break;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            Read();
        }
    }
}
