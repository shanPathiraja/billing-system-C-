using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Drawing.Printing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace billing_1
{
    public partial class ret_i_basket : Form
    {
        private OleDbConnection conection = new OleDbConnection();
        
        int p_len;
        int p_line_space = 12;
        string p_font = "Arial";
        int p_f_size = 8;
       
       
        int pre_page = 170;
       
        int ret_row;
        public ret_i_basket()
        {
            InitializeComponent();
            conection.ConnectionString = variable.constring;
        }

        private void ret_i_basket_Load(object sender, EventArgs e)
        {
            conection.Open();
            OleDbCommand f_order = new OleDbCommand();
            f_order.Connection = conection;
            // MessageBox.Show(in_no);
            string query = "SELECT retern_item.ID, retern_item.ret_date, retern_item.item_code, Products.Product_Name, retern_item.ret_quntity, retern_item.returned FROM retern_item INNER JOIN Products ON retern_item.item_code = Products.Product_Code WHERE (((retern_item.returned)=False)) ORDER BY retern_item.ret_date DESC";
            //OleDbDataReader f_order_reader = f_order.ExecuteReader();
            //string query = "select * from employee_data";
            f_order.CommandText = query;
            OleDbDataAdapter f_order_da = new OleDbDataAdapter(f_order);
            DataTable f_order_dt = new DataTable();
            f_order_da.Fill(f_order_dt);
            dgv_ret.DataSource = f_order_dt;
            ret_row = dgv_ret.RowCount;
            conection.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {for (int i = 0; i < ret_row-1; i++)
            {
                string ret_stu = dgv_ret.Rows[i].Cells[5].Value.ToString();
                //MessageBox.Show(ret_stu);
                if(ret_stu=="True")
                {
                    string ret_id = dgv_ret.Rows[i].Cells[0].Value.ToString();
                    conection.Open();
                    OleDbCommand edusrcmd = new OleDbCommand();
                    edusrcmd.Connection = conection;
                    string query = "update retern_item set returned=True where ID="+ ret_id;
                    //MessageBox.Show(query);
                    edusrcmd.CommandText = query;
                    edusrcmd.ExecuteNonQuery();
                    MessageBox.Show("mark as returned");
                    conection.Close();
                }
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Stoke_manage f2 = new Stoke_manage();
            f2.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            p_len = pre_page + ret_row * p_line_space;
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
            ec.Graphics.DrawString("Anuradhapura", new Font(p_font, p_f_size, FontStyle.Regular), Brushes.Black, y + 90, x + 10);
            ec.Graphics.DrawString("T.P:0716017460", new Font(p_font, p_f_size, FontStyle.Regular), Brushes.Black, y, x);
            ec.Graphics.DrawString("Retern List", new Font(p_font, p_f_size, FontStyle.Bold), Brushes.Black, y+60, x+25);

            x = x + 40;
            int cycle = ret_row - 1;
            ec.Graphics.DrawString("No", new Font(p_font, p_f_size, FontStyle.Regular), Brushes.Black, y+10, x);
            ec.Graphics.DrawString("Item", new Font(p_font, p_f_size, FontStyle.Regular), Brushes.Black, y + 30, x);
            ec.Graphics.DrawString("Quntity", new Font(p_font, p_f_size, FontStyle.Regular), Brushes.Black, y + 180, x, format);
            x = x + 5;
            ec.Graphics.DrawString("-----------------------------------------------------------------------------------------------------------------------", new Font(p_font, p_f_size, FontStyle.Regular), Brushes.Black, 0, x);

            for (int i = 0; i < cycle; i++)
            {
                x = x + p_line_space;
                ec.Graphics.DrawString((i+1).ToString(), new Font(p_font, p_f_size, FontStyle.Regular), Brushes.Black, y + 20, x,format);
                ec.Graphics.DrawString((dgv_ret.Rows[i].Cells[3].Value.ToString()), new Font(p_font, p_f_size, FontStyle.Regular), Brushes.Black, y + 30, x);
                ec.Graphics.DrawString((dgv_ret.Rows[i].Cells[4].Value.ToString()), new Font(p_font, p_f_size, FontStyle.Regular), Brushes.Black, y + 190, x, format);
               


            }
            




            ec.Graphics.DrawString("=================================================================================================================", new Font(p_font, p_f_size - 5, FontStyle.Regular), Brushes.Black, y, x + 15);
            

            ec.Graphics.DrawString("-------------------------- shan creation ----------------------------------------".ToString(), new Font(p_font, p_f_size - 2, FontStyle.Regular), Brushes.Black, 0, p_len - 20);
            ec.Graphics.DrawString("0716017460", new Font(p_font, p_f_size - 2, FontStyle.Regular), Brushes.Black, 80, p_len - 10);
        }
    }
}
