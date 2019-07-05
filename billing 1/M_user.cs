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
    public partial class M_user : Form
    {
        private OleDbConnection conection = new OleDbConnection();
        public M_user()
        {
            InitializeComponent();
            conection.ConnectionString = variable.constring;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_name.Clear();
            txt_pwd.Clear();
            txt_rpwd.Clear();
            txt_uname.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_pwd.Text == txt_rpwd.Text)
            {
                conection.Open();
                OleDbCommand addusrcmd = new OleDbCommand();
                addusrcmd.Connection = conection;
                addusrcmd.CommandText = "insert into employee_data (emp_name,usr_name,psswrd,usr_privilage,p_no,address) values('" + txt_name.Text+"','"+txt_uname.Text+"','"+txt_pwd.Text+ "','" +comboBox1.Text+"','"+txt_ausr_phone.Text+"','"+rtb_ausr_address.Text+"')";
                addusrcmd.ExecuteNonQuery();
                MessageBox.Show("user is added");
                conection.Close();
            }
            else { MessageBox.Show("password not match!"); }
        }

        private void btn_rmusr_Click(object sender, EventArgs e)
        {
            conection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = conection;
            command.CommandText = "select * from employee_data where usr_name='" + txr_mu_ru_au.Text + "' and psswrd='" + txt_mu_ru_apwd.Text + "'and usr_privilage='admin'";
            OleDbDataReader reder = command.ExecuteReader();
            int count = 0;
            while (reder.Read())
            {
                count++;

            }
            conection.Close();
            if (count==1)
            {
                conection.Open();
                OleDbCommand rmusrcmd = new OleDbCommand();
                rmusrcmd.Connection = conection;
                rmusrcmd.CommandText = "delete from employee_data where usr_name='"+ combo_eusr.Text+"'";
                rmusrcmd.ExecuteNonQuery();
                MessageBox.Show("user is removed");
                conection.Close();
            }
            else
            {
                MessageBox.Show("invailde admin details");
            }
        }

        private void M_user_Load(object sender, EventArgs e)
        {
            lbl_globle_uname.Text = "you are loging as:"+variable.usr_name+ "      privilage as:"+variable.usr_priv;
            try
            {
                conection.Open();
                OleDbCommand eusrcmd = new OleDbCommand();
                eusrcmd.Connection = conection;
                string query = "select * from employee_data";
                eusrcmd.CommandText = query;
                OleDbDataReader uread = eusrcmd.ExecuteReader();
                while (uread.Read())
                {
                    combo_eusr.Items.Add(uread["usr_name"]);
                    combo_usrd.Items.Add(uread["usr_name"]);
                    comb_edusr.Items.Add(uread["usr_name"]);
                }
                conection.Close();
            }
            catch
            {
                MessageBox.Show("error");
            }
        }

        private void combo_eusr_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                conection.Open();
                OleDbCommand eusrcmd = new OleDbCommand();
                eusrcmd.Connection = conection;
                string query = "select * from employee_data where usr_name ='" + combo_eusr.Text+"'";
                eusrcmd.CommandText = query;
                OleDbDataReader uread = eusrcmd.ExecuteReader();
                while (uread.Read())
                {
                    txt_rmuname.Text = uread["emp_name"].ToString();
                }
                conection.Close();
            }
            catch
            {
                MessageBox.Show("error");
            }
        }

        private void combo_usrd_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                conection.Open();
                OleDbCommand eusrcmd = new OleDbCommand();
                eusrcmd.Connection = conection;
                string query = "select * from employee_data where usr_name ='" + combo_usrd.Text + "'";
                eusrcmd.CommandText = query;
                OleDbDataReader uread = eusrcmd.ExecuteReader();
                while (uread.Read())
                {
                    lbl_ud_name.Text = uread["emp_name"].ToString();
                    lbl_ud_pri.Text = uread["usr_privilage"].ToString();
                    lbl_ud_phone.Text = uread["p_no"].ToString();
                    lbl_ud_address.Text = uread["address"].ToString();
                }
                conection.Close();
            }
            catch
            {
                MessageBox.Show("error");
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void comb_edusr_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                conection.Open();
                OleDbCommand eusrcmd = new OleDbCommand();
                eusrcmd.Connection = conection;
                string query = "select * from employee_data where usr_name ='" + comb_edusr.Text + "'";
                eusrcmd.CommandText = query;
                OleDbDataReader uread = eusrcmd.ExecuteReader();
                while (uread.Read())
                {
                    txt_edusr_name.Text = uread["emp_name"].ToString();
                    txt_edusr_priv.Text = uread["usr_privilage"].ToString();
                    txt_edusr_phone.Text = uread["p_no"].ToString();
                    rtb_edusr_address.Text = uread["address"].ToString();
                }
                conection.Close();
            }
            catch
            {
                MessageBox.Show("error");
            }
        }

        private void btn_edusr_save_Click(object sender, EventArgs e)
        {
            if (txt_edusr_pwd.Text == txt_edusr_rpwd.Text)
            {
                conection.Open();
                OleDbCommand edusrcmd = new OleDbCommand();
                edusrcmd.Connection = conection;
                string query = "update employee_data set emp_name='" + txt_edusr_name.Text + "',  psswrd='" + txt_edusr_pwd.Text + "',  usr_privilage='" + cmb_edusr_pri.Text + "',  p_no='" + txt_edusr_phone.Text +"', address='" + rtb_edusr_address.Text + "'  where usr_name ='" + comb_edusr.Text + "'";
                MessageBox.Show(query);
                edusrcmd.CommandText = query;
                edusrcmd.ExecuteNonQuery();
                MessageBox.Show("user details is updated");
                conection.Close();
            }
            else { MessageBox.Show("password not match!"); }
        }
    }
    }
    

