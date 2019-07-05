using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.OleDb;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace billing_1
{
    public partial class manage_product_form : Form
    {
        string a_p_ctgry;
        string a_p_sup;
        private OleDbConnection conection = new OleDbConnection();
        public manage_product_form()
        {
            InitializeComponent();
            conection.ConnectionString = variable.constring;

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btn_mprdct_add_Click(object sender, EventArgs e)
        {
            conection.Open();
            OleDbCommand addusrcmd = new OleDbCommand();
            addusrcmd.Connection = conection;
            addusrcmd.CommandText = "insert into Products (Product_Code,Product_Name,Standard_Cost,Price,catogory_id,suplier_id) values('" + txt_prdct_code.Text + "','" + txt_prdct_name.Text + "','" +txt_prdct_cost.Text + "','" + txt_prdct_price.Text+ "','" + a_p_ctgry+ "','"+ a_p_sup+"')";
            addusrcmd.ExecuteNonQuery();
            MessageBox.Show("product is added");
            conection.Close();
        }

        private void btn_mprdct_clr_Click(object sender, EventArgs e)
        {
            //txt_prdct_sup.Clear();
            txt_prdct_price.Clear();
            txt_prdct_name.Clear();
            //txt_prdct_ctgry.Clear();
            txt_prdct_cost.Clear();
            txt_prdct_code.Clear();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            conection.Open();
            OleDbCommand eprdct = new OleDbCommand();
            eprdct.Connection = conection;
            string query = "select * from Products where Product_Code ='"+txt_eprdct_code.Text+"'";
            conection.Close();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void manage_product_form_Load(object sender, EventArgs e)
        {
            conection.Open();
            OleDbCommand eusrcmd = new OleDbCommand();
            eusrcmd.Connection = conection;
            string query = "select * from catogory";
            eusrcmd.CommandText = query;
            OleDbDataReader uread = eusrcmd.ExecuteReader();
            while (uread.Read())
            {
                cmb_p_ctgry.Items.Add(uread["catogory"]);

            }
            conection.Close();

            conection.Open();
            OleDbCommand s_cat = new OleDbCommand();
            s_cat.Connection = conection;
            
            s_cat.CommandText = "SELECT * FROM suplier";
            OleDbDataReader uread1 = s_cat.ExecuteReader();
            while (uread1.Read())
            {
                cmb_ap_sup.Items.Add(uread1["compny_name"]);
                cmb_e_sup_sup.Items.Add(uread1["compny_name"]);

            }
            conection.Close();
        }

        private void cmb_p_ctgry_SelectedIndexChanged(object sender, EventArgs e)
        {
            conection.Open();
            OleDbCommand eusrcmd = new OleDbCommand();
            eusrcmd.Connection = conection;
            string query = "SELECT catogory.[ID] FROM catogory WHERE (((catogory.catogory)='" + cmb_p_ctgry.Text + "'))";
            eusrcmd.CommandText = query;
            OleDbDataReader uread = eusrcmd.ExecuteReader();
            while (uread.Read())
            {
                a_p_ctgry = uread["ID"].ToString();
                MessageBox.Show(a_p_ctgry);
            }
            conection.Close();
        }

        private void cmb_ap_sup_SelectedIndexChanged(object sender, EventArgs e)
        {
            conection.Open();
            OleDbCommand eusrcmd = new OleDbCommand();
            eusrcmd.Connection = conection;
            string query = "SELECT suplier.[ID] FROM suplier WHERE (((suplier.compny_name)='" + cmb_ap_sup.Text + "'))";
            eusrcmd.CommandText = query;
            OleDbDataReader uread = eusrcmd.ExecuteReader();
            while (uread.Read())
            {
                a_p_sup = uread["ID"].ToString();
                MessageBox.Show(a_p_sup);
            }
            conection.Close();
        }

        private void cmb_e_sup_sup_SelectedIndexChanged(object sender, EventArgs e)
        {
            


        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btn_e_sup_save_Click(object sender, EventArgs e)
        {
            conection.Open();
            OleDbCommand edusrcmd = new OleDbCommand();
            edusrcmd.Connection = conection;
            string query = "update suplier set compny_name='" + txt_com_name.Text + "',  suplier_phone='" + txt_sup_p_no.Text + "',  suplier_email='" + txt_sup_e_mail.Text + "',  sale_persons='" + txt_e_sup_sal_p_name.Text + "', address='" + rtb_e_sup_address.Text + "'  where ID =" + a_p_sup;
            MessageBox.Show(query);
            edusrcmd.CommandText = query;
            edusrcmd.ExecuteNonQuery();
            MessageBox.Show("Suplier  details is updated");
            conection.Close();
            btn_e_sup_save.Enabled = false;
        }

        private void cmb_e_sup_sup_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            conection.Open();
            OleDbCommand eusrcmd = new OleDbCommand();
            eusrcmd.Connection = conection;
            string query = "SELECT suplier.[ID] FROM suplier WHERE (((suplier.compny_name)='" + cmb_e_sup_sup.Text + "'))";
            eusrcmd.CommandText = query;
            OleDbDataReader uread = eusrcmd.ExecuteReader();
            while (uread.Read())
            {
                a_p_sup = uread["ID"].ToString();
                MessageBox.Show(a_p_sup);
            }
            conection.Close();
            conection.Open();
            OleDbCommand s_cat = new OleDbCommand();
            s_cat.Connection = conection;

            s_cat.CommandText = "SELECT * FROM suplier where ID=" + a_p_sup;
            OleDbDataReader uread1 = s_cat.ExecuteReader();
            while (uread1.Read())
            {
                txt_com_name.Text = uread1["compny_name"].ToString();
                txt_sup_p_no.Text = uread1["suplier_phone"].ToString();
                txt_sup_e_mail.Text = uread1["suplier_email"].ToString();
                txt_e_sup_sal_p_name.Text = uread1["sale_persons"].ToString();
                rtb_e_sup_address.Text = uread1["address"].ToString();

            }
            conection.Close();
            btn_e_sup_save.Enabled = true;

        }
    }
}
