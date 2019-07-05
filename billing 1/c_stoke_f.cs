using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace billing_1
{
    public partial class c_stoke_f : Form
    {
        private OleDbConnection conection = new OleDbConnection();
        public c_stoke_f()
        {
            InitializeComponent();
            conection.ConnectionString = variable.constring;
        }

        private void c_stoke_f_Load(object sender, EventArgs e)
        {
            conection.Open();
            OleDbCommand c_stoke = new OleDbCommand();
            c_stoke.Connection = conection;
            // MessageBox.Show(in_no);
            string query = "select * from stoke_data_Query";
            //OleDbDataReader f_order_reader = f_order.ExecuteReader();
            //string query = "select * from employee_data";
            c_stoke.CommandText = query;
            OleDbDataAdapter f_order_da = new OleDbDataAdapter(c_stoke);
            DataTable f_order_dt = new DataTable();
            f_order_da.Fill(f_order_dt);
            dgv_c_stoke.DataSource = f_order_dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
