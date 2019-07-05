using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.OleDb;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace billing_1
{
    

    public partial class Daly_sum_f : Form
    {
        int invrows;
        int p_len;
        int pre_page = 260;
        string p_font = "Arial";
        int p_f_size = 8;
        int p_line_space = 12;
        private OleDbConnection conection = new OleDbConnection();
        public Daly_sum_f()
        {
            InitializeComponent();
            conection.ConnectionString = variable.constring;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Daly_sum_f_Load(object sender, EventArgs e)
        {
            string t_day;
            t_day = DateTime.Today.ToString("dddd, MMMM d, yyyy");
            MessageBox.Show(t_day); 
            conection.Open();
            OleDbCommand f_order = new OleDbCommand();
            f_order.Connection = conection;
            // MessageBox.Show(in_no);
            string query = "SELECT ivoice_query_l1.[Product_Name] AS නම, ivoice_query_l1.[Standard_Cost] AS වියදම , ivoice_query_l1.[Price] AS විකුණු_මිල , ivoice_query_l1.[Sum Of quntity] AS සංඛ්‍යාව, [lv1gain]*[Sum Of quntity] AS ලාබය FROM ivoice_query_l1 WHERE (((ivoice_query_l1.[invoice_date By Day])='" + t_day + "'))";
            //OleDbDataReader f_order_reader = f_order.ExecuteReader();
            //string query = "select * from employee_data";
            f_order.CommandText = query;
            OleDbDataAdapter f_order_da = new OleDbDataAdapter(f_order);
            DataTable f_order_dt = new DataTable();
            f_order_da.Fill(f_order_dt);
            dgv_daly_sum.DataSource = f_order_dt;

            invrows = dgv_daly_sum.RowCount;


            double t_gain =0 ;
            double t_income = 0;

            for (int i = 0; i < invrows; i++)
            {

                t_gain = t_gain+ Convert.ToDouble(dgv_daly_sum.Rows[i].Cells[4].Value);
                t_income=t_income+ (Convert.ToDouble(dgv_daly_sum.Rows[i].Cells[3].Value)* Convert.ToDouble(dgv_daly_sum.Rows[i].Cells[2].Value));



            }
            txt_tdy_gain.Text = t_gain.ToString();
            txt_dly_incm.Text = t_income.ToString();






        }

        private void btn_prnt_dly_smmry_Click(object sender, EventArgs e)
        {



            p_len = pre_page + invrows * p_line_space;
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
                ec.Graphics.DrawString(dgv_daly_sum.Rows[i].Cells[3].Value.ToString(), new Font(p_font, p_f_size, FontStyle.Regular), Brushes.Black, y + 5, x);
                ec.Graphics.DrawString(dgv_daly_sum.Rows[i].Cells[0].Value.ToString(), new Font(p_font, p_f_size, FontStyle.Regular), Brushes.Black, y + 25, x);
               // ec.Graphics.DrawString(dgv_daly_sum.Rows[i].Cells[2].Value.ToString(), new Font(p_font, p_f_size, FontStyle.Regular), Brushes.Black, y + 85, x);
                //ec.Graphics.DrawString(dgv_invoice.Rows[i].Cells[3].Value.ToString(), new Font(p_font, p_f_size, FontStyle.Regular), Brushes.Black, y + 120, x);
                ec.Graphics.DrawString((dgv_daly_sum.Rows[i].Cells[4].Value.ToString()), new Font(p_font, p_f_size, FontStyle.Regular), Brushes.Black, y + 190, x, format);
                /* MessageBox.Show(i.ToString());
                 string cell = dgv_invoice.Rows[i].Cells[0].Value.ToString();
                 MessageBox.Show(cell);*/



            }
            



            ec.Graphics.DrawString("=================================================================================================================", new Font(p_font, p_f_size - 5, FontStyle.Regular), Brushes.Black, y, x + 15);
            ec.Graphics.DrawString(txt_dly_incm.Text.ToString(), new Font(p_font, p_f_size + 1, FontStyle.Regular), Brushes.Black, y + 190, x + 25, format);
            ec.Graphics.DrawString("අද දින ලැබීම්:", new Font(p_font, p_f_size + 1, FontStyle.Regular), Brushes.Black, y, x + 25);
            x = x + 20;
            ec.Graphics.DrawString("ලාබය:", new Font(p_font, p_f_size + 1, FontStyle.Regular), Brushes.Black, y, x + 25);
            ec.Graphics.DrawString(txt_tdy_gain.Text.ToString(), new Font(p_font, p_f_size + 1, FontStyle.Regular), Brushes.Black, y + 190, x + 25, format);
            x = x + 20;
           // ec.Graphics.DrawString("balance:", new Font(p_font, p_f_size + 1, FontStyle.Regular), Brushes.Black, y, x + 25);
           // ec.Graphics.DrawString(balance.ToString("0.00"), new Font(p_font, p_f_size + 1, FontStyle.Regular), Brushes.Black, y + 190, x + 25, format);

            ec.Graphics.DrawString("=================================================================================================================", new Font(p_font, p_f_size - 5, FontStyle.Regular), Brushes.Black, y, x + 40);
            //ec.Graphics.DrawString("THANK YOU COME AGAIN", new Font(p_font, p_f_size, FontStyle.Regular), Brushes.Black, y + 20, x + 55);


            ec.Graphics.DrawString("-------------------------- shan creation ----------------------------------------".ToString(), new Font(p_font, p_f_size - 2, FontStyle.Regular), Brushes.Black, 0, p_len - 20);
            ec.Graphics.DrawString("0716017460", new Font(p_font, p_f_size - 2, FontStyle.Regular), Brushes.Black, 80, p_len - 10);
        }


    }
}
