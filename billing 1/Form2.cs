using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Timers;

using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace billing_1
{
    public partial class Form2 : Form
    {
        
        
   
        public Form2()
        {
            InitializeComponent();
          
        }

        

        private void btn_Musr_Click(object sender, EventArgs e)
        {if (variable.usr_priv == "admin")
            {
                this.Hide();
                M_user f_musr = new M_user();
                f_musr.ShowDialog();
            }
        else
            {
                MessageBox.Show("you are not Authrised to access this feathure");
            }
        }
       

        private void btn_mprdct_Click_1(object sender, EventArgs e)
        {
            if (variable.usr_priv == "admin")
            {
                this.Hide();
            manage_product_form f_mprdct = new manage_product_form();
            f_mprdct.ShowDialog();
            }
            else
            {
                MessageBox.Show("you are not Authrised to access this feathure");
            }
        }

        private void btn_neworder_Click(object sender, EventArgs e)
        {
            this.Hide();
            New_order_Form f_order = new New_order_Form();
            f_order.ShowDialog();
        }

        private void btn_mng_order_Click(object sender, EventArgs e)
        {
            this.Hide();
            m_order_f f_morder = new m_order_f();
            f_morder.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            report_f f_report = new report_f();
            f_report.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Stoke_manage f_stoke = new Stoke_manage();
            f_stoke.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Daly_sum_f f_daly = new Daly_sum_f();
            f_daly.ShowDialog();
        }
     
        private void btn_neworder_MouseEnter(object sender, EventArgs e)
        {
            btn_neworder.BackColor = Color.Lime;
            btn_neworder.Width = 400;
            btn_neworder.Height = 200;
            btn_neworder.BringToFront();
            btn_neworder.Left -= 25;
            btn_neworder.Top -= 25;
        }

        private void btn_neworder_MouseLeave(object sender, EventArgs e)
        {
            btn_neworder.BackColor = Color.SpringGreen;
            btn_neworder.Width = 320;
            btn_neworder.Height = 150;
            btn_neworder.Left += 25;
            btn_neworder.Top += 25;
        }

        private void btn_mng_order_MouseEnter(object sender, EventArgs e)
        {
            btn_mng_order.BackColor = Color.Lime;
            btn_mng_order.Width = 400;
            btn_mng_order.Height = 200;
            btn_mng_order.BringToFront();
            btn_mng_order.Left -= 25;
            btn_mng_order.Top -= 25;
        }

        private void btn_mng_order_MouseLeave(object sender, EventArgs e)
        {
            btn_mng_order.BackColor = Color.SpringGreen;
            btn_mng_order.Width = 320;
            btn_mng_order.Height = 150;
            btn_mng_order.Left += 25;
            btn_mng_order.Top += 25;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Lime;
            button1.Width = 400;
            button1.Height = 200;
            button1.BringToFront();
            button1.Left -= 25;
            button1.Top -= 25;
        }

        private void btn_Musr_MouseEnter(object sender, EventArgs e)
        {
            btn_Musr.BackColor = Color.Lime;
            btn_Musr.Width = 400;
            btn_Musr.Height = 200;
            btn_Musr.BringToFront();
            btn_Musr.Left -= 25;
            btn_Musr.Top -= 25;
        }

        private void btn_Musr_MouseLeave(object sender, EventArgs e)
        {
            btn_Musr.BackColor = Color.SpringGreen;
            btn_Musr.Width = 320;
            btn_Musr.Height = 150;
            btn_Musr.Left += 25;
            btn_Musr.Top += 25;
        }

        private void btn_mprdct_MouseEnter(object sender, EventArgs e)
        {
            btn_mprdct.BackColor = Color.Lime;
            btn_mprdct.Width = 400;
            btn_mprdct.Height = 200;
            btn_mprdct.BringToFront();
            btn_mprdct.Left -= 25;
            btn_mprdct.Top -= 25;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.SpringGreen;
            button1.Width = 320;
            button1.Height = 150;
            button1.Left += 25;
            button1.Top += 25;
        }

        private void btn_mprdct_MouseLeave(object sender, EventArgs e)
        {
            btn_mprdct.BackColor = Color.SpringGreen;
            btn_mprdct.Width = 320;
            btn_mprdct.Height = 150;
            btn_mprdct.Left += 25;
            btn_mprdct.Top += 25;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.Lime;
            button2.Width = 400;
            button2.Height = 200;
            button2.BringToFront();
            button2.Left -= 25;
            button2.Top -= 25;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.SpringGreen;
            button2.Width = 320;
            button2.Height = 150;
            button2.Left += 25;
            button2.Top += 25;
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.BackColor = Color.Lime;
            button4.Width = 400;
            button4.Height = 200;
            button4.BringToFront();
            button4.Left -= 25;
            button4.Top -= 25;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.SpringGreen;
            button4.Width = 320;
            button4.Height = 150;
            button4.Left += 25;
            button4.Top += 25;

        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            button5.BackColor = Color.Lime;
            button5.Width = 400;
            button5.Height = 200;
            button5.BringToFront();
            button5.Left -= 25;
            button5.Top -= 25;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.BackColor = Color.SpringGreen;
            button5.Width = 320;
            button5.Height = 150;
            button5.Left += 25;
            button5.Top += 25;

        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackColor = Color.Lime;
            button3.Width = 400;
            button3.Height = 200;
            button3.BringToFront();
            button3.Left -= 25;
            button3.Top -= 25;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.SpringGreen;
            button3.Width = 320;
            button3.Height = 150;
            button3.Left += 25;
            button3.Top += 25;
        }
    }

        
    }

