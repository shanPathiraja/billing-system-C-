using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Drawing.Printing;
using System.Text;
using System.Data.OleDb;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace billing_1
{
    public partial class m_order_f : Form

    {

       
        
        
        
        
        double total_price;
        int invrows;
        int p_len;
        int p_line_space = 12;
        string p_font = "Arial";
        int p_f_size = 8;
        
        double balance = 0;
        double cash_recv = 0;
        int pre_page = 260;
        private OleDbConnection conection = new OleDbConnection();

        public m_order_f()
        {
            InitializeComponent();
            conection.ConnectionString = variable.constring;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton2.Checked == true)
            { dtp_mo_fi.Enabled = true;
                lb_mo_recipt.Visible = true;
                txt_mo_fi_rno.Enabled = false;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked ==true)
            {
                dtp_mo_fi.Enabled = false;
                lb_mo_recipt.Visible = false;
                txt_mo_fi_rno.Enabled = true;
            }
        }

        private void btn_back_home_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void btn_mo_fi_find_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked==true)
            {
                string in_no = txt_mo_fi_rno.Text.ToString();
                
                    conection.Open();
                    OleDbCommand f_order = new OleDbCommand();
                    f_order.Connection = conection;
               // MessageBox.Show(in_no);
                string query = "SELECT  Invoice_query.Product_Name, Invoice_query.quntity, Invoice_query.sub_price FROM Invoice_query WHERE(((Invoice_query.invoice_id) = "+in_no+")) ";
                //OleDbDataReader f_order_reader = f_order.ExecuteReader();
                //string query = "select * from employee_data";
                f_order.CommandText = query;
                    OleDbDataAdapter f_order_da = new OleDbDataAdapter(f_order);
                    DataTable f_order_dt = new DataTable();
                    f_order_da.Fill(f_order_dt);
                dgv_forder.DataSource = f_order_dt;
                   

                    conection.Close();


                conection.Open();
                OleDbCommand eusrcmd = new OleDbCommand();
                eusrcmd.Connection = conection;

                eusrcmd.CommandText = "SELECT invoice_data.invoice_id, invoice_data.sum_price,invoice_data.invoice_date, invoice_data.cash_recive FROM invoice_data WHERE (((invoice_data.invoice_id)=" + in_no + "))";
                OleDbDataReader uread = eusrcmd.ExecuteReader();
                while (uread.Read())
                {
                    txt_mo_totalprice.Text = uread["sum_price"].ToString();
                    txt_mo_cash_rcv.Text = uread["cash_recive"].ToString();
                    dtp_mo_fi.Text = uread["invoice_date"].ToString();
                }
                conection.Close();
                btn_mo_p_in.Visible = true;

            }
            else if(radioButton2.Checked==true)
            {
               
                lb_mo_recipt.Items.Clear();
                dtp_mo_fi.Format = DateTimePickerFormat.Custom;
                dtp_mo_fi.CustomFormat = "M/d/yyyy ";
                string dtp1 = dtp_mo_fi.Text.ToString();

                try
                {
                    conection.Open();
                    OleDbCommand eusrcmd = new OleDbCommand();
                    eusrcmd.Connection = conection;
                    string query = "SELECT invoice_data.invoice_date, invoice_data.invoice_id FROM invoice_data WHERE (((invoice_data.invoice_date)=#"+dtp1+"#));";
                    eusrcmd.CommandText = query;
                    OleDbDataReader uread = eusrcmd.ExecuteReader();
                    while (uread.Read())
                    {
                        lb_mo_recipt.Items.Add("Invoice NO:"+uread["invoice_id"]);
                        
                    }
                    conection.Close();

                }
                catch
                {
                    MessageBox.Show("error");
                }

                // MessageBox.Show(dtp1);
                /* */
            }
        }

        private void lb_mo_recipt_SelectedIndexChanged(object sender, EventArgs e)
        {
            string c_item = lb_mo_recipt.SelectedItem.ToString();
            string N_s = string.Empty;
            for(int i=0; i<c_item.Length;i++)
            {
                if (char.IsDigit(c_item[i]))
                {
                    N_s += c_item[i];
                }
            }
            txt_mo_fi_rno.Text = N_s;
            conection.Open();
            OleDbCommand f_order = new OleDbCommand();
            f_order.Connection = conection;
            // MessageBox.Show(in_no);
            string query = "SELECT  Invoice_query.Product_Name, Invoice_query.quntity, Invoice_query.sub_price FROM Invoice_query WHERE(((Invoice_query.invoice_id) =" + N_s + "))";
            //OleDbDataReader f_order_reader = f_order.ExecuteReader();
            //string query = "select * from employee_data";
            f_order.CommandText = query;
            OleDbDataAdapter f_order_da = new OleDbDataAdapter(f_order);
            DataTable f_order_dt = new DataTable();
            f_order_da.Fill(f_order_dt);
            dgv_forder.DataSource = f_order_dt;
            conection.Close();


            conection.Open();
            OleDbCommand eusrcmd = new OleDbCommand();
            eusrcmd.Connection = conection;
             
            eusrcmd.CommandText = "SELECT invoice_data.invoice_id, invoice_data.sum_price, invoice_data.cash_recive FROM invoice_data WHERE (((invoice_data.invoice_id)=" + N_s+"))";
            OleDbDataReader uread = eusrcmd.ExecuteReader();
            while (uread.Read())
            {
                txt_mo_totalprice.Text = uread["sum_price"].ToString();
                txt_mo_cash_rcv.Text = uread["cash_recive"].ToString();
            }
            conection.Close();
            btn_mo_p_in.Visible = true;
        }

        private void btn_mo_p_in_Click(object sender, EventArgs e)
        {
            // manage page size
            invrows = dgv_forder.RowCount;
            p_len = pre_page + invrows * p_line_space;
            MessageBox.Show(invrows.ToString());


            PrintDocument pd = new PrintDocument();
            pd.DefaultPageSettings.PaperSize = new PaperSize("Recipt", 200, p_len);
            pd.PrintPage += new PrintPageEventHandler(this.pd_printpage);
            pd.Print();

        }
        private void pd_printpage(object sender, PrintPageEventArgs ec)
        {
            StringFormat format = new StringFormat(StringFormatFlags.DirectionRightToLeft);

            int y = 5;
            Bitmap bmp = Properties.Resources.SC_Logo;
            Image newImage = bmp;
            ec.Graphics.DrawImage(newImage, 5, 25, newImage.Width, newImage.Height);
            int x = 90;
            ec.Graphics.DrawString("Nochchiyagama", new Font(p_font, p_f_size, FontStyle.Regular), Brushes.Black, y + 90, x);
            ec.Graphics.DrawString("Anuradhapura", new Font(p_font, p_f_size, FontStyle.Regular), Brushes.Black, y + 90, x + 10);
            ec.Graphics.DrawString("T.P:0716017460", new Font(p_font, p_f_size, FontStyle.Regular), Brushes.Black, y, x);
            x = x + 15;
            ec.Graphics.DrawString("Sale person:" + variable.usr_name, new Font(p_font, p_f_size, FontStyle.Regular), Brushes.Black, y, x + 10);
            ec.Graphics.DrawString(DateTime.Now.ToString(), new Font(p_font, p_f_size-2, FontStyle.Regular), Brushes.Black, y, x + 25);
            //ec.Graphics.DrawString("E.mail:Shanb11170@gmail.com", new Font(p_font, p_f_size, FontStyle.Regular), Brushes.Black, y , x + 10);
            x = x + 40;
            int cycle = invrows - 1;
            ec.Graphics.DrawString("no", new Font(p_font, p_f_size, FontStyle.Regular), Brushes.Black, y + 3, x);
            ec.Graphics.DrawString("Item", new Font(p_font, p_f_size, FontStyle.Regular), Brushes.Black, y + 25, x);
            ec.Graphics.DrawString("qun", new Font(p_font, p_f_size, FontStyle.Regular), Brushes.Black, y + 80, x);
            //ec.Graphics.DrawString("u_p", new Font(p_font, p_f_size, FontStyle.Regular), Brushes.Black, y+120, x);
            ec.Graphics.DrawString("s_p", new Font(p_font, p_f_size, FontStyle.Regular), Brushes.Black, y + 180, x, format);
            x = x + 5;
            ec.Graphics.DrawString("-----------------------------------------------------------------------------------------------------------------------", new Font(p_font, p_f_size, FontStyle.Regular), Brushes.Black, 0, x);

            for (int i = 0; i < cycle; i++)
            {
                x = x + p_line_space;
                ec.Graphics.DrawString(i.ToString(), new Font(p_font, p_f_size, FontStyle.Regular), Brushes.Black, y + 5, x);
                ec.Graphics.DrawString(dgv_forder.Rows[i].Cells[0].Value.ToString(), new Font(p_font, p_f_size, FontStyle.Regular), Brushes.Black, y + 25, x);
                ec.Graphics.DrawString(dgv_forder.Rows[i].Cells[1].Value.ToString(), new Font(p_font, p_f_size, FontStyle.Regular), Brushes.Black, y + 85, x);
                //ec.Graphics.DrawString(dgv_invoice.Rows[i].Cells[3].Value.ToString(), new Font(p_font, p_f_size, FontStyle.Regular), Brushes.Black, y + 120, x);
                ec.Graphics.DrawString((dgv_forder.Rows[i].Cells[2].Value.ToString()), new Font(p_font, p_f_size, FontStyle.Regular), Brushes.Black, y + 190, x, format);
                /* MessageBox.Show(i.ToString());
                 string cell = dgv_invoice.Rows[i].Cells[0].Value.ToString();
                 MessageBox.Show(cell);*/



            }
            cash_recv = (Convert.ToDouble(txt_mo_cash_rcv.Text));


            MessageBox.Show("Please enter Cash amount");
            total_price = Convert.ToDouble(txt_mo_totalprice.Text);

            balance = cash_recv - total_price;



            ec.Graphics.DrawString("=================================================================================================================", new Font(p_font, p_f_size - 5, FontStyle.Regular), Brushes.Black, y, x + 15);
            ec.Graphics.DrawString(total_price.ToString("0.00"), new Font(p_font, p_f_size + 1, FontStyle.Regular), Brushes.Black, y + 190, x + 25, format);
            ec.Graphics.DrawString("total price:", new Font(p_font, p_f_size + 1, FontStyle.Regular), Brushes.Black, y, x + 25);
            x = x + 20;
            ec.Graphics.DrawString("cash resived:", new Font(p_font, p_f_size + 1, FontStyle.Regular), Brushes.Black, y, x + 25);
            ec.Graphics.DrawString(cash_recv.ToString("0.00"), new Font(p_font, p_f_size + 1, FontStyle.Regular), Brushes.Black, y + 190, x + 25, format);
            x = x + 20;
            ec.Graphics.DrawString("balance:", new Font(p_font, p_f_size + 1, FontStyle.Regular), Brushes.Black, y, x + 25);
            ec.Graphics.DrawString(balance.ToString("0.00"), new Font(p_font, p_f_size + 1, FontStyle.Regular), Brushes.Black, y + 190, x + 25, format);

            ec.Graphics.DrawString("=================================================================================================================", new Font(p_font, p_f_size - 5, FontStyle.Regular), Brushes.Black, y, x + 40);
            ec.Graphics.DrawString("THANK YOU COME AGAIN", new Font(p_font, p_f_size, FontStyle.Regular), Brushes.Black, y + 20, x + 55);


            ec.Graphics.DrawString("-------------------------- shan creation ----------------------------------------".ToString(), new Font(p_font, p_f_size - 2, FontStyle.Regular), Brushes.Black, 0, p_len - 20);
            ec.Graphics.DrawString("0716017460", new Font(p_font, p_f_size - 2, FontStyle.Regular), Brushes.Black, 80, p_len - 10);
        }

        private void m_order_f_Load(object sender, EventArgs e)
        {

        }
    }
}
