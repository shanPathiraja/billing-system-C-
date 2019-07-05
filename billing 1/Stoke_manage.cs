using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace billing_1
{
    public partial class Stoke_manage : Form
    {
        public Stoke_manage()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            c_stoke_f f_stoke = new c_stoke_f();
            f_stoke.ShowDialog();
        }

        private void btn_u_d_stoke_Click(object sender, EventArgs e)
        {
            u_stoke_f u_stoke = new u_stoke_f();
            u_stoke.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dmg_i_f d_f = new dmg_i_f();
            d_f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ret_i_basket r_b = new ret_i_basket();
            r_b.Show();

        }
    }
}
