using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace billing_1
{
    class variable
    {
        public static string usr_name;
        public static string usr_priv;
        public static String clocation = System.IO.Directory.GetCurrentDirectory();
        public static string constring = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + clocation + "/data/Database91.accdb;";
        public static double fwd_cash = 0;
    }


    public partial class Form1 : Form
    {
        
        private OleDbConnection conection = new OleDbConnection();
        public Form1()
        {
           

            InitializeComponent();

            conection.ConnectionString = variable.constring;
    }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            

            txt_uname.Focus();

        }

        private void btn_loging_Click(object sender, EventArgs e)
        {

            MessageBox.Show(variable.clocation);
            conection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = conection;
            command.CommandText = "select * from employee_data where usr_name='" + txt_uname.Text + "' and psswrd='" + txt_psswrd.Text + "'";
             OleDbDataReader reder = command.ExecuteReader();
            int count = 0;
            while(reder.Read())
            {
                variable.usr_priv = reder["usr_privilage"].ToString(); 
                 count++;

            }
            if (count==1)
            {
                variable.usr_name = txt_uname.Text.ToString();
                MessageBox.Show("loging sucessfull");
                conection.Close();
                conection.Dispose();
                this.Hide();
                Form2 f2 = new Form2();
                f2.ShowDialog();
                

            }
            else if (count>1)
            {
                MessageBox.Show("there is " + count + " account found");

            }
            else
            {
                MessageBox.Show("wrong user name or password");
            }
           
            conection.Close();
        }

        private void txt_uname_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                txt_psswrd.Focus();
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {

        }

        private void txt_uname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_psswrd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_loging.Focus();
            }
        }
    }
   
}
