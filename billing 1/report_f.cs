using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace billing_1
{
    
    public partial class report_f : Form
    {
        string ctgry_id;
        private OleDbConnection conection = new OleDbConnection();
        public report_f()
        {
            InitializeComponent();
            conection.ConnectionString = variable.constring;
        }

        private void report_f_Load(object sender, EventArgs e)
        {
            string s_date = DateTime.Now.ToString();
            DateTime datevalue = (Convert.ToDateTime(s_date.ToString()));

            cmb_yp_sby.Text = datevalue.Year.ToString();
            cmb_yp_sbm.Text = datevalue.Year.ToString();
            string s_mounth="" ;
            switch(Convert.ToInt32(datevalue.Month))
                {
                case 1:
                    s_mounth = "Jan";
                    break;
                case 2:
                    s_mounth = "Feb";
                    break;
                case 3:
                    s_mounth = "Mar";
                    break;
                case 4:
                    s_mounth = "Apr";
                    break;
                case 5:
                    s_mounth = "May";
                    break;
                case 6:
                    s_mounth = "Jun";
                    break;
                case 7:
                    s_mounth = "Jul";
                    break;
                case 8:
                    s_mounth = "Aug";
                    break;
                case 9:
                    s_mounth = "Sep";
                    break;
                case 10:
                    s_mounth = "Oct";
                    break;
                case 11:
                    s_mounth = "Nov";
                    break;
                case 12:
                    s_mounth = "Dec";
                    break;
                    
            }

            cmb_mp_sbm.Text = s_mounth;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            dtp_r_f_date.Enabled = true;
            cmb_mp_sbm.Enabled = false;
            cmb_yp_sbm.Enabled = false;
            cmb_yp_sby.Enabled = false;
            btn_find_by_date.Visible = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            dtp_r_f_date.Enabled = false;
            cmb_mp_sbm.Enabled = true;
            cmb_yp_sbm.Enabled = true;
            cmb_yp_sby.Enabled = false;
            btn_find_by_date.Visible = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            dtp_r_f_date.Enabled = false;
            cmb_mp_sbm.Enabled = false;
            cmb_yp_sbm.Enabled = false;
            cmb_yp_sby.Enabled = true;
            btn_find_by_date.Visible = false;
        }

        private void cmb_mp_sbm_SelectedIndexChanged(object sender, EventArgs e)
        {
            string n_mounth = "";
            switch(cmb_mp_sbm.Text.ToString())
            {
                case "Jan":
                    n_mounth = "January";
                    break;
                case "Feb":
                    n_mounth = "February";
                    break;
                case "Mar":
                    n_mounth = "March";
                    break;
                case "Apr":
                    n_mounth = "April";
                    break;
                case "May":
                    n_mounth = "May";
                    break;
                case "Jun":
                    n_mounth = "June";
                    break;
                case "Jul":
                    n_mounth = "July";
                    break;
                case "Aug":
                    n_mounth = "August";
                    break;
                case "Sep":
                    n_mounth = "September";
                    break;
                case "Oct":
                    n_mounth = "October";
                    break;
                case "Nov":
                    n_mounth = "November";
                    break;
                case "Dec":
                    n_mounth = "December";
                    break;
            }
            string sbm_year = cmb_yp_sbm.Text.ToString();
            if (rb_sbm.Checked == true)
            {
                string s_year = cmb_yp_sby.Text.ToString();
                conection.Open();
                OleDbCommand f_order = new OleDbCommand();
                f_order.Connection = conection;
                // MessageBox.Show(in_no);
                string query = "SELECT DISTINCTROW Format$([invoice_data].[invoice_date],'mmmm yyyy') AS [invoice_date By Month], invoiced_items.product_no, Products.Product_Name, Sum(invoiced_items.quntity) AS [Sum Of quntity] FROM (invoiced_items INNER JOIN Products ON invoiced_items.[product_no] = Products.[Product_Code]) INNER JOIN invoice_data ON invoiced_items.[invoice_id] = invoice_data.[invoice_id] GROUP BY Format$([invoice_data].[invoice_date],'mmmm yyyy'), invoiced_items.product_no, Products.Product_Name, Year([invoice_data].[invoice_date])*12+DatePart('m',[invoice_data].[invoice_date])-1 HAVING (((Format$([invoice_data].[invoice_date],'mmmm yyyy'))='"+n_mounth+" "+sbm_year+"'))";
                //OleDbDataReader f_order_reader = f_order.ExecuteReader();
                //string query = "select * from employee_data";
                f_order.CommandText = query;
                OleDbDataAdapter f_order_da = new OleDbDataAdapter(f_order);
                DataTable f_order_dt = new DataTable();
                f_order_da.Fill(f_order_dt);
                dgv_rs_data.DataSource = f_order_dt;


                conection.Close();
            }



        }

        private void cmb_yp_sby_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rb_sby.Checked == true)
            {
                string s_year = cmb_yp_sby.Text.ToString();
                conection.Open();
                OleDbCommand f_order = new OleDbCommand();
                f_order.Connection = conection;
                // MessageBox.Show(in_no);
                string query = "SELECT DISTINCTROW Format$([invoice_data].[invoice_date],'yyyy') AS [invoice_date By Year], invoiced_items.product_no, Products.Product_Name, Sum(invoiced_items.quntity) AS [Sum Of quntity] FROM (invoiced_items INNER JOIN Products ON invoiced_items.[product_no] = Products.[Product_Code]) INNER JOIN invoice_data ON invoiced_items.[invoice_id] = invoice_data.[invoice_id] GROUP BY Format$([invoice_data].[invoice_date],'yyyy'), invoiced_items.product_no, Products.Product_Name, Year([invoice_data].[invoice_date]) HAVING (((Format$([invoice_data].[invoice_date],'yyyy'))=" + s_year + "))";
                //OleDbDataReader f_order_reader = f_order.ExecuteReader();
                //string query = "select * from employee_data";
                f_order.CommandText = query;
                OleDbDataAdapter f_order_da = new OleDbDataAdapter(f_order);
                DataTable f_order_dt = new DataTable();
                f_order_da.Fill(f_order_dt);
                dgv_rs_data.DataSource = f_order_dt;


                conection.Close();
            }
        }

        private void cmb_yp_sbm_SelectedIndexChanged(object sender, EventArgs e)
        {
            string n_mounth = "";
            switch (cmb_mp_sbm.Text.ToString())
            {
                case "Jan":
                    n_mounth = "January";
                    break;
                case "Feb":
                    n_mounth = "February";
                    break;
                case "Mar":
                    n_mounth = "March";
                    break;
                case "Apr":
                    n_mounth = "April";
                    break;
                case "May":
                    n_mounth = "May";
                    break;
                case "Jun":
                    n_mounth = "June";
                    break;
                case "Jul":
                    n_mounth = "July";
                    break;
                case "Aug":
                    n_mounth = "August";
                    break;
                case "Sep":
                    n_mounth = "September";
                    break;
                case "Oct":
                    n_mounth = "October";
                    break;
                case "Nov":
                    n_mounth = "November";
                    break;
                case "Dec":
                    n_mounth = "December";
                    break;
            }
            string sbm_year = cmb_yp_sbm.Text.ToString();
            if (rb_sbm.Checked == true)
            {
                string s_year = cmb_yp_sby.Text.ToString();
                conection.Open();
                OleDbCommand f_order = new OleDbCommand();
                f_order.Connection = conection;
                // MessageBox.Show(in_no);
                string query = "SELECT DISTINCTROW Format$([invoice_data].[invoice_date],'mmmm yyyy') AS [invoice_date By Month], invoiced_items.product_no, Products.Product_Name, Sum(invoiced_items.quntity) AS [Sum Of quntity] FROM (invoiced_items INNER JOIN Products ON invoiced_items.[product_no] = Products.[Product_Code]) INNER JOIN invoice_data ON invoiced_items.[invoice_id] = invoice_data.[invoice_id] GROUP BY Format$([invoice_data].[invoice_date],'mmmm yyyy'), invoiced_items.product_no, Products.Product_Name, Year([invoice_data].[invoice_date])*12+DatePart('m',[invoice_data].[invoice_date])-1 HAVING (((Format$([invoice_data].[invoice_date],'mmmm yyyy'))='" + n_mounth + " " + sbm_year + "'))";
                //OleDbDataReader f_order_reader = f_order.ExecuteReader();
                //string query = "select * from employee_data";
                f_order.CommandText = query;
                OleDbDataAdapter f_order_da = new OleDbDataAdapter(f_order);
                DataTable f_order_dt = new DataTable();
                f_order_da.Fill(f_order_dt);
                dgv_rs_data.DataSource = f_order_dt;


                conection.Close();
            }


        }

        private void btn_find_by_date_Click(object sender, EventArgs e)
        {
            string s_date = dtp_r_f_date.Text.ToString();
            MessageBox.Show(s_date);
             if (rb_sbd.Checked == true)
             {

                 conection.Open();
                 OleDbCommand f_order = new OleDbCommand();
                 f_order.Connection = conection;
                 // MessageBox.Show(in_no);
                 string query = "SELECT DISTINCTROW Format$([invoice_data].[invoice_date],'Long Date') AS [invoice_date By Day], invoiced_items.product_no, Products.Product_Name, Sum(invoiced_items.quntity) AS [Sum Of quntity] FROM (invoiced_items INNER JOIN Products ON invoiced_items.[product_no] = Products.[Product_Code]) INNER JOIN invoice_data ON invoiced_items.[invoice_id] = invoice_data.[invoice_id] GROUP BY Format$([invoice_data].[invoice_date],'Long Date'), invoiced_items.product_no, Products.Product_Name HAVING (((Format$([invoice_data].[invoice_date],'Long Date'))='"+s_date+"'))";
                 //OleDbDataReader f_order_reader = f_order.ExecuteReader();
                 //string query = "select * from employee_data";
                 f_order.CommandText = query;
                 OleDbDataAdapter f_order_da = new OleDbDataAdapter(f_order);
                 DataTable f_order_dt = new DataTable();
                 f_order_da.Fill(f_order_dt);
                 dgv_rs_data.DataSource = f_order_dt;


                 conection.Close();
             }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void rb_pc_smrz_CheckedChanged(object sender, EventArgs e)
        {
            btn_pc_f_smry.Enabled = true;
            cmb_f_b_ctgry.Enabled = false;
        }

        private void btn_pc_f_smry_Click(object sender, EventArgs e)
        {
            btn_pc_bst_ctgry.Enabled = true;
            btn_pc_l_s_ctgry.Enabled = true;

            conection.Open();
            OleDbCommand f_order = new OleDbCommand();
            f_order.Connection = conection;
            // MessageBox.Show(in_no);
            string query = "SELECT DISTINCTROW Format$([invoice_data].[invoice_date],'mmmm yyyy') AS [invoice_date By Month], catogory.catogory, Sum(invoiced_items.quntity) AS [Sum Of quntity] FROM (invoiced_items INNER JOIN invoice_data ON invoiced_items.[invoice_id] = invoice_data.[invoice_id]) INNER JOIN (catogory INNER JOIN Products ON catogory.[ID] = Products.[catogory_id]) ON invoiced_items.[product_no] = Products.[Product_Code] GROUP BY Format$([invoice_data].[invoice_date],'mmmm yyyy'), catogory.catogory, Year([invoice_data].[invoice_date])*12+DatePart('m',[invoice_data].[invoice_date])-1 HAVING (((Format$([invoice_data].[invoice_date],'mmmm yyyy'))='November 2018'))";
            //OleDbDataReader f_order_reader = f_order.ExecuteReader();
            //string query = "select * from employee_data";
            f_order.CommandText = query;
            OleDbDataAdapter f_order_da = new OleDbDataAdapter(f_order);
            DataTable f_order_dt = new DataTable();
            f_order_da.Fill(f_order_dt);
            dgv_rs_data.DataSource = f_order_dt;
            conection.Close();
        }

        private void btn_pc_bst_ctgry_Click(object sender, EventArgs e)
        {
            conection.Open();
            OleDbCommand f_order = new OleDbCommand();
            f_order.Connection = conection;
            // MessageBox.Show(in_no);
            string query = "SELECT DISTINCTROW Format$([invoice_data].[invoice_date],'mmmm yyyy') AS [invoice_date By Month], catogory.catogory, Sum(invoiced_items.quntity) AS [Sum Of quntity] FROM (invoiced_items INNER JOIN invoice_data ON invoiced_items.[invoice_id] = invoice_data.[invoice_id]) INNER JOIN (catogory INNER JOIN Products ON catogory.[ID] = Products.[catogory_id]) ON invoiced_items.[product_no] = Products.[Product_Code] GROUP BY Format$([invoice_data].[invoice_date],'mmmm yyyy'), catogory.catogory, Year([invoice_data].[invoice_date])*12+DatePart('m',[invoice_data].[invoice_date])-1 HAVING (((Format$([invoice_data].[invoice_date],'mmmm yyyy'))='November 2018')) ORDER BY Sum(invoiced_items.quntity) DESC";
            //OleDbDataReader f_order_reader = f_order.ExecuteReader();
            //string query = "select * from employee_data";
            f_order.CommandText = query;
            OleDbDataAdapter f_order_da = new OleDbDataAdapter(f_order);
            DataTable f_order_dt = new DataTable();
            f_order_da.Fill(f_order_dt);
            dgv_rs_data.DataSource = f_order_dt;
            conection.Close();
        }

        private void btn_pc_l_s_ctgry_Click(object sender, EventArgs e)
        {
            conection.Open();
            OleDbCommand f_order = new OleDbCommand();
            f_order.Connection = conection;
            // MessageBox.Show(in_no);
            string query = "SELECT DISTINCTROW Format$([invoice_data].[invoice_date],'mmmm yyyy') AS [invoice_date By Month], catogory.catogory, Sum(invoiced_items.quntity) AS [Sum Of quntity] FROM (invoiced_items INNER JOIN invoice_data ON invoiced_items.[invoice_id] = invoice_data.[invoice_id]) INNER JOIN (catogory INNER JOIN Products ON catogory.[ID] = Products.[catogory_id]) ON invoiced_items.[product_no] = Products.[Product_Code] GROUP BY Format$([invoice_data].[invoice_date],'mmmm yyyy'), catogory.catogory, Year([invoice_data].[invoice_date])*12+DatePart('m',[invoice_data].[invoice_date])-1 HAVING (((Format$([invoice_data].[invoice_date],'mmmm yyyy'))='November 2018')) ORDER BY Sum(invoiced_items.quntity)";
            //OleDbDataReader f_order_reader = f_order.ExecuteReader();
            //string query = "select * from employee_data";
            f_order.CommandText = query;
            OleDbDataAdapter f_order_da = new OleDbDataAdapter(f_order);
            DataTable f_order_dt = new DataTable();
            f_order_da.Fill(f_order_dt);
            dgv_rs_data.DataSource = f_order_dt;
            conection.Close();
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            btn_pc_bst_ctgry.Enabled = false;
            btn_pc_l_s_ctgry.Enabled = false;
            btn_pc_f_smry.Enabled = false;
            cmb_f_b_ctgry.Enabled = true;
            conection.Open();
            OleDbCommand eusrcmd = new OleDbCommand();
            eusrcmd.Connection = conection;
            string query = "select * from catogory";
            eusrcmd.CommandText = query;
            OleDbDataReader uread = eusrcmd.ExecuteReader();
            while (uread.Read())
            {
                cmb_f_b_ctgry.Items.Add(uread["catogory"]);
                
            }
            conection.Close();
        }

        private void cmb_f_b_ctgry_SelectedIndexChanged(object sender, EventArgs e)
        {
           
                conection.Open();
                OleDbCommand eusrcmd = new OleDbCommand();
                eusrcmd.Connection = conection;
                string query = "SELECT catogory.[ID] FROM catogory WHERE (((catogory.catogory)='"+cmb_f_b_ctgry.Text+"'))";
                eusrcmd.CommandText = query;
                OleDbDataReader uread = eusrcmd.ExecuteReader();
                while (uread.Read())
                {
                    ctgry_id = uread["ID"].ToString();
                    MessageBox.Show(ctgry_id);
                }
                conection.Close();
            conection.Open();
            OleDbCommand f_order = new OleDbCommand();
            f_order.Connection = conection;
            // MessageBox.Show(in_no);
            string query1 = "SELECT DISTINCTROW Format$([invoice_data].[invoice_date],'mmmm yyyy') AS [invoice_date By Month], Sum(invoiced_items.quntity) AS [Sum Of quntity] FROM (invoiced_items INNER JOIN invoice_data ON invoiced_items.[invoice_id] = invoice_data.[invoice_id]) INNER JOIN (catogory INNER JOIN Products ON catogory.[ID] = Products.[catogory_id]) ON invoiced_items.[product_no] = Products.[Product_Code] GROUP BY Format$([invoice_data].[invoice_date],'mmmm yyyy'), catogory.catogory, Year([invoice_data].[invoice_date])*12+DatePart('m',[invoice_data].[invoice_date])-1, catogory.ID HAVING (((catogory.ID)="+ctgry_id+")) ORDER BY Year([invoice_data].[invoice_date])*12+DatePart('m',[invoice_data].[invoice_date])-1 DESC";
            //OleDbDataReader f_order_reader = f_order.ExecuteReader();
            //string query = "select * from employee_data";
            f_order.CommandText = query1;
            OleDbDataAdapter f_order_da = new OleDbDataAdapter(f_order);
            DataTable f_order_dt = new DataTable();
            f_order_da.Fill(f_order_dt);
            dgv_rs_data.DataSource = f_order_dt;
            conection.Close();

        }
    }
}
