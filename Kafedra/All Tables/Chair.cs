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
    public partial class ChairDB : Form
    {
        ApplicationDb db = new ApplicationDb();
        Chair s = new Chair();
        public ChairDB()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Visible == true)
            {
                Read();
            }
        }      
        public void Read()
        {
            dataGridView1.DataSource = db.Chairs.OrderBy(x => x.name).ToList<Chair>();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(textBox1.Visible==false)
            {
                dataGridView1.DataSource = db.Chairs.Where(x => x.name.Contains(textBox2.Text)).ToList();
            }
            if(textBox2.Visible==false)
            {
                dataGridView1.DataSource = db.Chairs.Where(x => x.name.Contains(textBox1.Text)).ToList();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Haqiqatanam malimotni uchirmoqchimisiz", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var entity = db.Entry(s);
                db.Chairs.Attach(s);
                db.Chairs.Remove(s);
                db.SaveChanges();
                MessageBox.Show("Students jadvalidan ma'limot uchirilmoqda");
                MessageBox.Show("Malimot uchirildii");
                textBox1.Text = "";
                Read();
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(textBox1.Visible==true)
            {
                textBox2.Visible = false;
                if (e.RowIndex < -1)
                    return;
                if (dataGridView1.CurrentRow.Index != -1)
                {
                    s.id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
                    s = db.Chairs.Where(x => x.id == s.id).FirstOrDefault();
                    textBox1.Text = s.name;
                }
            }
            if(textBox2.Visible==true)
            {
                textBox1.Visible = false;
                if (e.RowIndex < -1)
                    return;
                if (dataGridView1.CurrentRow.Index != -1)
                {
                    s.id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
                    s = db.Chairs.Where(x => x.id == s.id).FirstOrDefault();
                    textBox2.Text = s.name;
                }
            }
             
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
           if(textBox2.Visible==true)
            {
                textBox1.Visible = false;
                s.name = textBox2.Text.Trim();
                if (s.id == 0)
                    db.Chairs.Add(s);
                else
                    db.Entry(s).State = EntityState.Modified;
                db.SaveChanges();
                MessageBox.Show("Malimot yangilandii");
                Read();
                textBox2.Text = "";
            }
            if (textBox1.Visible == true)
            {
                textBox2.Visible = false;
                s.name = textBox1.Text.Trim();
                if (s.id == 0)
                    db.Chairs.Add(s);
                else
                    db.Entry(s).State = EntityState.Modified;
                db.SaveChanges();
                MessageBox.Show("Malimot yangilandii");
                Read();
                textBox1.Text = "";
            }
        }

        private void ChairDB_Load(object sender, EventArgs e)
        {
            Read();
            textBox2.Text = "";
            textBox2.Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           if(textBox1.Visible==true && textBox2.Visible==false)
            {
                if (textBox1.Text.Length != 0)
                {
                    s.name = textBox1.Text;
                    db.Chairs.Add(s);
                    db.SaveChanges();
                    MessageBox.Show("Ma'lumot qushildi!!!!!!");
                    Read();
                    textBox1.Text = "";
                }
            }
           if(textBox2.Visible==true && textBox1.Visible==false)
            {
                if (textBox2.Text.Length != 0)
                {
                    s.name = textBox2.Text;
                    db.Chairs.Add(s);
                    db.SaveChanges();
                    MessageBox.Show("Ma'lumot qushildi!!!!!!");
                    Read();
                    textBox1.Text = "";
                }
            }         
            else
            {
                MessageBox.Show("Iltimos TextBox ga ma'lumot kiriting!!");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           if(textBox2.Visible==true)
            {
                Read();
            }
        }
    }
}

