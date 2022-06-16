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
           Read();            
        }
        public void Read()
        {
            dataGridView1.DataSource = db.Chairs.ToList<Chair>();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Chairs.Where(x => x.name.Contains(textBox1.Text)).ToList();
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
            if (e.RowIndex < -1)
                return;
            if (dataGridView1.CurrentRow.Index != -1)
            {
                s.id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
                s = db.Chairs.Where(x => x.id == s.id).FirstOrDefault();
                textBox1.Text = s.name;
            }             
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            s.name= textBox1.Text;
            if (s.id == 0)
                db.Chairs.Add(s);
            else
                db.Entry(s).State = EntityState.Modified;
                db.SaveChanges();
            MessageBox.Show("Malimot yangilandii");
            Read();
           // textBox1.Text = "";
        }

        private void ChairDB_Load(object sender, EventArgs e)
        {
            Read();
        }

        private void btnAdd_Click(object sender, EventArgs e)
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
            else
            {
                MessageBox.Show("Iltimos Ma'lumot to'ldirilganiga ishoch hosil qiling!!!!");
            }
        }       
    }
}

