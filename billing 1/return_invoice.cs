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
    public partial class return_invoice : Form
    {
        int s_row_indx;
        string invoice_ref_id;
        string invoiced_quntity;
        string invoiced_price;
        

        private OleDbConnection conection = new OleDbConnection();
        public return_invoice()
        {
            
            InitializeComponent();
            conection.ConnectionString = variable.constring;
        }

        private void txt_r_invo_code_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_r_invo_code_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                conection.Open();
                OleDbCommand f_order = new OleDbCommand();
                f_order.Connection = conection;
                // MessageBox.Show(in_no);
                string query = "SELECT invoiced_items.product_no, Products.Product_Name, invoiced_items.quntity, invoiced_items.sub_price, invoiced_items.ID FROM invoiced_items INNER JOIN Products ON invoiced_items.[product_no] = Products.[Product_Code] WHERE (((invoiced_items.invoice_id)=" + txt_r_invo_code.Text+"));";
                //OleDbDataReader f_order_reader = f_order.ExecuteReader();
                //string query = "select * from employee_data";
                f_order.CommandText = query;
                OleDbDataAdapter f_order_da = new OleDbDataAdapter(f_order);
                DataTable f_order_dt = new DataTable();
                f_order_da.Fill(f_order_dt);
                dgv_r_invoice.DataSource = f_order_dt;
                conection.Close();
            }
        }

        private void dgv_r_invoice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show("r s");
            if(dgv_r_invoice.SelectedCells.Count>0)
            {
                 s_row_indx = dgv_r_invoice.SelectedCells[0].RowIndex;
               // MessageBox.Show(s_row_indx.ToString());
            }

            txt_r_i_no.Text = dgv_r_invoice.Rows[s_row_indx].Cells[0].Value.ToString();
            invoice_ref_id = dgv_r_invoice.Rows[s_row_indx].Cells[4].Value.ToString();
            invoiced_quntity = dgv_r_invoice.Rows[s_row_indx].Cells[2].Value.ToString();
            invoiced_price = dgv_r_invoice.Rows[s_row_indx].Cells[3].Value.ToString();
            txt_re_quntity.Focus();


            conection.Open();
            OleDbCommand eusrcmd = new OleDbCommand();
            eusrcmd.Connection = conection;
            string query = "select * from stoke_data where item_code ='" + txt_r_i_no.Text + "'";
            eusrcmd.CommandText = query;
            OleDbDataReader uread = eusrcmd.ExecuteReader();
            while (uread.Read())
            {
                txt_avlbl_quntity.Text = uread["left_stoke"].ToString();
            }
            conection.Close();
            if(Convert.ToInt32(txt_avlbl_quntity.Text)>0)
            {
                btn_r_item.Enabled = true;
                
            }
            
        }

        private void btn_r_item_Click(object sender, EventArgs e)
        {

            if ((Convert.ToInt32(txt_avlbl_quntity.Text)) > (Convert.ToInt32(txt_re_quntity.Text)))
                {
                int n_lft_stoke = (Convert.ToInt32(txt_avlbl_quntity.Text) - Convert.ToInt32(txt_re_quntity.Text));
                 

                conection.Open();
                OleDbCommand rmusrcmd = new OleDbCommand();
                rmusrcmd.Connection = conection;
                rmusrcmd.CommandText = "update stoke_data set left_stoke='" + n_lft_stoke.ToString() + "'where item_code ='" + txt_r_i_no.Text + "'";
                rmusrcmd.ExecuteNonQuery();
                // MessageBox.Show("user is removed");
                conection.Close();
                ret_item(txt_r_i_no.Text.ToString(), txt_re_quntity.Text.ToString());
            }

            else
            {
                MessageBox.Show("Insaficent Stoke");
                btn_r_item.Enabled = false;
                
            }





        }
        public void m_back(string inc_id, string P_num, string inv_re_id, string i_qunt, string s_price)
        {
           
            

        }

        private void btn_m_back_Click(object sender, EventArgs e)
        { string s_price= null;
            double n_price;

            conection.Open();
            OleDbCommand d_f_ivo_i = new OleDbCommand();
            d_f_ivo_i.Connection = conection;
            d_f_ivo_i.CommandText = "delete from invoiced_items where ID=" + Convert.ToInt32(invoice_ref_id) + "";
            d_f_ivo_i.ExecuteNonQuery();
            //MessageBox.Show("user is removed");
            conection.Close();

            conection.Open();
            OleDbCommand eusrcmd = new OleDbCommand();
            eusrcmd.Connection = conection;
            string query = "SELECT invoice_data.[sum_price] FROM invoice_data WHERE (((invoice_data.[invoice_id])="+ txt_r_invo_code.Text+ "));";
            eusrcmd.CommandText = query;
            OleDbDataReader uread = eusrcmd.ExecuteReader();
            while (uread.Read())
            {
                s_price = uread["sum_price"].ToString();
            }
            conection.Close();

            n_price = (Convert.ToDouble(s_price)) - (Convert.ToDouble(invoiced_price));
            string M_price = n_price.ToString();
            variable.fwd_cash = Convert.ToDouble(invoiced_price);

            //MessageBox.Show(M_price +"  " +txt_r_invo_code.Text.ToString());

            conection.Open();
            OleDbCommand up_ivo_data = new OleDbCommand();
            up_ivo_data.Connection = conection;
            up_ivo_data.CommandText = "update invoice_data set sum_price =" + M_price+ " where invoice_id =" + txt_r_invo_code.Text.ToString();
            up_ivo_data.ExecuteNonQuery();
            //MessageBox.Show("user is removed");
            conection.Close();
            ret_item(txt_r_i_no.Text.ToString(), txt_re_quntity.Text.ToString());
            btn_m_back.Enabled = false;
        }




        public void ret_item(string i_code, string i_qun)
        {
            conection.Open();
            OleDbCommand addusrcmd = new OleDbCommand();
            addusrcmd.Connection = conection;
            addusrcmd.CommandText = "insert into retern_item (item_code,ret_date,ret_quntity) values('" + i_code + "','" + DateTime.Today + "','" + i_qun +  "')";
            addusrcmd.ExecuteNonQuery();
            //MessageBox.Show("user is added");
            conection.Close();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            New_order_Form order = new New_order_Form();
            this.Close();
            order.ShowDialog();
        }
    }
}
