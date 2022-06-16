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
using System.Data.SqlClient;
namespace Kafedra.All_Tables
{
    public partial class ShapeDb : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-HUC7BS4;Initial Catalog=KafedraDb; Integrated Security=true;");
        SqlCommand command;
        public ShapeDb()
        {
            InitializeComponent();
        }

        private void Shape_Load(object sender, EventArgs e)
        {
            command = new SqlCommand("select *from Shapes", con);
            command.ExecuteReader();
            con.Open();
            DataTable data = new DataTable();
            dataGridView1.DataSource = data;
        }
       
        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
