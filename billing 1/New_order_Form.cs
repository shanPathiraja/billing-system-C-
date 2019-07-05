using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.OleDb;
using System.Drawing.Printing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;

namespace billing_1
{
    public partial class New_order_Form : Form
    {
        int order_id;
        string p_code;
        string p_name;
        string p_price;
        double sub_price=0;
        double total_price=0;
        int invrows;
        int p_len;
        int p_line_space = 12;
        string p_font = "Arial";
        int p_f_size = 8;
        int i_count=0;
        double balance=0;
        double cash_recv=0;
        int pre_page = 260;
        double f_cash=0;

        private OleDbConnection conection = new OleDbConnection();
        public New_order_Form()
        {
            InitializeComponent();
            conection.ConnectionString = variable.constring;
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_norder_add_Click(object sender, EventArgs e)
        {

           //get data from product table
                conection.Open();
                OleDbCommand additemcmd = new OleDbCommand();
                additemcmd.Connection = conection;

                additemcmd.CommandText = "select * from Products where Product_Code='" + txt_norder_icode.Text+ "'";
                OleDbDataReader addiread = additemcmd.ExecuteReader();
                while (addiread.Read())
                {
                     p_name = addiread["Product_Name"].ToString();
                     p_code = addiread["Product_Code"].ToString();
                     p_price = addiread["Price"].ToString();

                }
                conection.Close();
            //----------------------------------------------------------------------------------------------------------------------------------------
            sub_price = (Convert.ToDouble(p_price) * Convert.ToDouble(txt_norder_iqunty.Text));//genarate sub price

            // add items to invoiced item table
                conection.Open();
                OleDbCommand initemcmd = new OleDbCommand();
                initemcmd.Connection = conection;
                initemcmd.CommandText = "insert into invoiced_items (invoice_id, product_no,quntity,sub_price) values('" + order_id.ToString() + "','" + p_code +"','"+ txt_norder_iqunty.Text+"','"+sub_price.ToString()+ "')";
                initemcmd.ExecuteNonQuery();
                conection.Close();
           
            string sub_price_cul = sub_price.ToString("0.00");
          

            i_count++;
            string[] row = new string[] {i_count.ToString(), p_name, txt_norder_iqunty.Text , p_price , sub_price_cul };
            dgv_invoice.Rows.Add(row);
            

            total_price = total_price + sub_price;
            double t_p = total_price - variable.fwd_cash;
           // MessageBox.Show(t_p.ToString());
            txt_total.Text = (t_p.ToString()).ToString();
            variable.fwd_cash = 0;

           // MessageBox.Show("item invoiced");

            
           
        
        }

        private void New_order_Form_Load(object sender, EventArgs e)
        {
            
            try
            {
                conection.Open();
                OleDbCommand maxinvcmd = new OleDbCommand("SELECT DISTINCTROW Max([invoice_data].[invoice_id]) AS [Max] FROM invoice_data", conection);

                String max = maxinvcmd.ExecuteScalar().ToString();
                order_id = Convert.ToInt32(max);

                order_id++;

                conection.Close();
            }
            catch
            {
                MessageBox.Show("error" + e);
            }
            
            // datagrid viwe column config
            dgv_invoice.ColumnCount = 5;
            dgv_invoice.Columns[0].Name = "NO";
            dgv_invoice.Columns[1].Name = "item Name";
            dgv_invoice.Columns[2].Name = "quntity";
            dgv_invoice.Columns[3].Name = "unit price";
            dgv_invoice.Columns[4].Name = "sub price";
            if(variable.fwd_cash>0)
            {
                MessageBox.Show(variable.fwd_cash.ToString());
                string[] row = new string[] { "*","retuned cash" , " ", " ", "-"+variable.fwd_cash.ToString("0.00") };
                dgv_invoice.Rows.Add(row);
                //f_cash = Convert.ToDouble(variable.fwd_cash);
            }


        }

        private void btn_prnt_invoice_Click(object sender, EventArgs e)
        {

            conection.Open();
            OleDbCommand initemcmd = new OleDbCommand();
            initemcmd.Connection = conection;
            initemcmd.CommandText = "insert into invoice_data (invoice_id, invoice_date, sum_price, cash_recive, sale_person) values('" + order_id.ToString() + "','" + DateTime.Today + "','" + txt_total.Text.ToString() + "','" + txt_csh_rcv.Text.ToString() + "','" + variable.usr_name + "')";
            initemcmd.ExecuteNonQuery();
            conection.Close();

            // manage page size
            invrows = dgv_invoice.RowCount;
             p_len = pre_page + invrows *p_line_space ;
            MessageBox.Show(invrows.ToString());

            
                PrintDocument pd = new PrintDocument();
                pd.DefaultPageSettings.PaperSize = new PaperSize("Recipt", 200, p_len);
                pd.PrintPage += new PrintPageEventHandler(this.pd_printpage);
                pd.Print();
           
                


            
        }
            public void pd_printpage(object sender, PrintPageEventArgs ec)
        {
            StringFormat format = new StringFormat(StringFormatFlags.DirectionRightToLeft);
            
            int y = 5;
            Bitmap bmp = Properties.Resources.SC_Logo;
            Image newImage = bmp;
            ec.Graphics.DrawImage(newImage, 5, 25, newImage.Width, newImage.Height);
            int x = 90;
            ec.Graphics.DrawString("Nochchiyagama", new Font(p_font, p_f_size, FontStyle.Regular), Brushes.Black, y + 90, x);
            ec.Graphics.DrawString("Anuradhapura", new Font(p_font, p_f_size, FontStyle.Regular), Brushes.Black, y + 90, x+10);
            ec.Graphics.DrawString("T.P:0716017460", new Font(p_font, p_f_size, FontStyle.Regular), Brushes.Black, y , x);
            x = x + 15;
            ec.Graphics.DrawString("Sale person:"+variable.usr_name, new Font(p_font, p_f_size, FontStyle.Regular), Brushes.Black, y, x+10);
            ec.Graphics.DrawString(DateTime.Now.ToString(), new Font(p_font, p_f_size-2, FontStyle.Regular), Brushes.Black, y, x+25);
            //ec.Graphics.DrawString("E.mail:Shanb11170@gmail.com", new Font(p_font, p_f_size, FontStyle.Regular), Brushes.Black, y , x + 10);
            x = x + 40;
            int cycle = invrows - 1;
            ec.Graphics.DrawString("no", new Font(p_font, p_f_size, FontStyle.Regular), Brushes.Black, y+3, x);
            ec.Graphics.DrawString("Item", new Font(p_font, p_f_size, FontStyle.Regular), Brushes.Black, y+25, x);
            ec.Graphics.DrawString("qun", new Font(p_font, p_f_size, FontStyle.Regular), Brushes.Black,y+ 80, x);
            //ec.Graphics.DrawString("u_p", new Font(p_font, p_f_size, FontStyle.Regular), Brushes.Black, y+120, x);
            ec.Graphics.DrawString("s_p", new Font(p_font, p_f_size, FontStyle.Regular), Brushes.Black, y+180, x,format);
            x = x + 5;
            ec.Graphics.DrawString("-----------------------------------------------------------------------------------------------------------------------", new Font(p_font, p_f_size, FontStyle.Regular), Brushes.Black, 0, x);

            for (int i=0; i<cycle;i++)
            {
                x = x + p_line_space;
                ec.Graphics.DrawString(dgv_invoice.Rows[i].Cells[0].Value.ToString(), new Font(p_font, p_f_size, FontStyle.Regular), Brushes.Black,y+ 5, x);
                ec.Graphics.DrawString(dgv_invoice.Rows[i].Cells[1].Value.ToString(), new Font(p_font, p_f_size, FontStyle.Regular), Brushes.Black, y + 25, x);
                ec.Graphics.DrawString(dgv_invoice.Rows[i].Cells[2].Value.ToString(), new Font(p_font, p_f_size, FontStyle.Regular), Brushes.Black, y + 85, x);
                //ec.Graphics.DrawString(dgv_invoice.Rows[i].Cells[3].Value.ToString(), new Font(p_font, p_f_size, FontStyle.Regular), Brushes.Black, y + 120, x);
                ec.Graphics.DrawString((dgv_invoice.Rows[i].Cells[4].Value.ToString()), new Font(p_font, p_f_size, FontStyle.Regular), Brushes.Black, y + 190, x,format);
                /* MessageBox.Show(i.ToString());
                 string cell = dgv_invoice.Rows[i].Cells[0].Value.ToString();
                 MessageBox.Show(cell);*/



            }
            cash_recv = (Convert.ToDouble(txt_csh_rcv.Text));
          
            
                MessageBox.Show("Please enter Cash amount");
            
            
                balance = cash_recv - Convert.ToDouble(txt_total.Text);
           
            double tx_total = Convert.ToDouble(txt_total.Text);




            ec.Graphics.DrawString("=================================================================================================================", new Font(p_font, p_f_size - 5, FontStyle.Regular), Brushes.Black, y , x + 15);
            ec.Graphics.DrawString(tx_total.ToString("0.00"), new Font(p_font, p_f_size +1, FontStyle.Regular), Brushes.Black, y+190, x+25,format);
            ec.Graphics.DrawString("total price:", new Font(p_font, p_f_size + 1, FontStyle.Regular), Brushes.Black, y , x + 25 );
            x = x + 20;
            ec.Graphics.DrawString("cash resived:", new Font(p_font, p_f_size + 1, FontStyle.Regular), Brushes.Black, y, x + 25);
            ec.Graphics.DrawString(cash_recv.ToString("0.00"), new Font(p_font, p_f_size + 1, FontStyle.Regular), Brushes.Black, y+190, x + 25,format);
            x = x + 20;
            ec.Graphics.DrawString("balance:", new Font(p_font, p_f_size + 1, FontStyle.Regular), Brushes.Black, y, x + 25);
            ec.Graphics.DrawString(balance.ToString("0.00"), new Font(p_font, p_f_size + 1, FontStyle.Regular), Brushes.Black, y+190, x + 25, format);

            ec.Graphics.DrawString("=================================================================================================================", new Font(p_font, p_f_size - 5, FontStyle.Regular), Brushes.Black, y , x + 40);
            ec.Graphics.DrawString("THANK YOU COME AGAIN", new Font(p_font, p_f_size, FontStyle.Regular), Brushes.Black, y+20 , x + 55);


            ec.Graphics.DrawString("-------------------------- shan creation ----------------------------------------".ToString(), new Font(p_font, p_f_size-2, FontStyle.Regular), Brushes.Black, 0,p_len-20 );
            ec.Graphics.DrawString("0716017460", new Font(p_font, p_f_size - 2, FontStyle.Regular), Brushes.Black, 80, p_len - 10);
        }

    

        private void btn_delete_data_invoice_Click(object sender, EventArgs e)
        {
            
            
            
        }

        private void txt_norder_icode_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void txt_norder_icode_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode ==Keys.Enter)
            {
                txt_norder_iqunty.Focus();
            }
        }

        private void txt_norder_iqunty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //get data from product table
                conection.Open();
                OleDbCommand additemcmd = new OleDbCommand();
                additemcmd.Connection = conection;

                additemcmd.CommandText = "select * from Products where Product_Code='" + txt_norder_icode.Text + "'";
                OleDbDataReader addiread = additemcmd.ExecuteReader();
                while (addiread.Read())
                {
                    p_name = addiread["Product_Name"].ToString();
                    p_code = addiread["Product_Code"].ToString();
                    p_price = addiread["Price"].ToString();

                }
                conection.Close();
                //----------------------------------------------------------------------------------------------------------------------------------------
                sub_price = (Convert.ToDouble(p_price) * Convert.ToDouble(txt_norder_iqunty.Text));//genarate sub price

                // add items to invoiced item table
                conection.Open();
                OleDbCommand initemcmd = new OleDbCommand();
                initemcmd.Connection = conection;
                initemcmd.CommandText = "insert into invoiced_items (invoice_id, product_no,quntity,sub_price) values('" + order_id.ToString() + "','" + p_code + "','" + txt_norder_iqunty.Text + "','" + sub_price.ToString() + "')";
                initemcmd.ExecuteNonQuery();
                conection.Close();

                string sub_price_cul = sub_price.ToString("0.00");


                i_count++;
                string[] row = new string[] { i_count.ToString(), p_name, txt_norder_iqunty.Text, p_price, sub_price_cul };
                dgv_invoice.Rows.Add(row);

                total_price = total_price + sub_price;
                double t_p = total_price - variable.fwd_cash;
                //MessageBox.Show(t_p.ToString());
                txt_total.Text = (t_p.ToString()).ToString();
                variable.fwd_cash = 0;

                // MessageBox.Show("item invoiced");
                txt_norder_iqunty.Clear();
                txt_norder_icode.Clear();
                txt_norder_icode.Focus();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            return_invoice r_in_f = new return_invoice();
            this.Close();
            r_in_f.ShowDialog();
        }

        private void txt_balance_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txt_csh_rcv_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
