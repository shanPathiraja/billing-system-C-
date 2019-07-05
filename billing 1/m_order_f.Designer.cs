namespace billing_1
{
    partial class m_order_f
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_mo_p_in = new System.Windows.Forms.Button();
            this.lb_mo_recipt = new System.Windows.Forms.ListBox();
            this.btn_mo_fi_find = new System.Windows.Forms.Button();
            this.dtp_mo_fi = new System.Windows.Forms.DateTimePicker();
            this.txt_mo_fi_rno = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgv_forder = new System.Windows.Forms.DataGridView();
            this.btn_back_home = new System.Windows.Forms.Button();
            this.txt_mo_totalprice = new System.Windows.Forms.TextBox();
            this.txt_mo_cash_rcv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_forder)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(372, 304);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_mo_p_in);
            this.tabPage1.Controls.Add(this.lb_mo_recipt);
            this.tabPage1.Controls.Add(this.btn_mo_fi_find);
            this.tabPage1.Controls.Add(this.dtp_mo_fi);
            this.tabPage1.Controls.Add(this.txt_mo_fi_rno);
            this.tabPage1.Controls.Add(this.radioButton2);
            this.tabPage1.Controls.Add(this.radioButton1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(364, 278);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Find invoice";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_mo_p_in
            // 
            this.btn_mo_p_in.Location = new System.Drawing.Point(58, 180);
            this.btn_mo_p_in.Name = "btn_mo_p_in";
            this.btn_mo_p_in.Size = new System.Drawing.Size(125, 60);
            this.btn_mo_p_in.TabIndex = 5;
            this.btn_mo_p_in.Text = "Print Invoice";
            this.btn_mo_p_in.UseVisualStyleBackColor = true;
            this.btn_mo_p_in.Visible = false;
            this.btn_mo_p_in.Click += new System.EventHandler(this.btn_mo_p_in_Click);
            // 
            // lb_mo_recipt
            // 
            this.lb_mo_recipt.FormattingEnabled = true;
            this.lb_mo_recipt.Location = new System.Drawing.Point(189, 101);
            this.lb_mo_recipt.Name = "lb_mo_recipt";
            this.lb_mo_recipt.Size = new System.Drawing.Size(159, 160);
            this.lb_mo_recipt.TabIndex = 5;
            this.lb_mo_recipt.Visible = false;
            this.lb_mo_recipt.SelectedIndexChanged += new System.EventHandler(this.lb_mo_recipt_SelectedIndexChanged);
            // 
            // btn_mo_fi_find
            // 
            this.btn_mo_fi_find.Location = new System.Drawing.Point(58, 101);
            this.btn_mo_fi_find.Name = "btn_mo_fi_find";
            this.btn_mo_fi_find.Size = new System.Drawing.Size(125, 58);
            this.btn_mo_fi_find.TabIndex = 4;
            this.btn_mo_fi_find.Text = "find";
            this.btn_mo_fi_find.UseVisualStyleBackColor = true;
            this.btn_mo_fi_find.Click += new System.EventHandler(this.btn_mo_fi_find_Click);
            // 
            // dtp_mo_fi
            // 
            this.dtp_mo_fi.Enabled = false;
            this.dtp_mo_fi.Location = new System.Drawing.Point(164, 59);
            this.dtp_mo_fi.Name = "dtp_mo_fi";
            this.dtp_mo_fi.Size = new System.Drawing.Size(184, 20);
            this.dtp_mo_fi.TabIndex = 3;
            // 
            // txt_mo_fi_rno
            // 
            this.txt_mo_fi_rno.Enabled = false;
            this.txt_mo_fi_rno.Location = new System.Drawing.Point(164, 26);
            this.txt_mo_fi_rno.Name = "txt_mo_fi_rno";
            this.txt_mo_fi_rno.Size = new System.Drawing.Size(184, 20);
            this.txt_mo_fi_rno.TabIndex = 2;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(24, 59);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(88, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "find with date";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(24, 26);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(134, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Find with recipt number";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(364, 278);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgv_forder
            // 
            this.dgv_forder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_forder.Location = new System.Drawing.Point(480, 2);
            this.dgv_forder.Name = "dgv_forder";
            this.dgv_forder.Size = new System.Drawing.Size(412, 339);
            this.dgv_forder.TabIndex = 1;
            // 
            // btn_back_home
            // 
            this.btn_back_home.Location = new System.Drawing.Point(12, 384);
            this.btn_back_home.Name = "btn_back_home";
            this.btn_back_home.Size = new System.Drawing.Size(75, 23);
            this.btn_back_home.TabIndex = 2;
            this.btn_back_home.Text = "Back";
            this.btn_back_home.UseVisualStyleBackColor = true;
            this.btn_back_home.Click += new System.EventHandler(this.btn_back_home_Click);
            // 
            // txt_mo_totalprice
            // 
            this.txt_mo_totalprice.Enabled = false;
            this.txt_mo_totalprice.Location = new System.Drawing.Point(770, 347);
            this.txt_mo_totalprice.Name = "txt_mo_totalprice";
            this.txt_mo_totalprice.Size = new System.Drawing.Size(122, 20);
            this.txt_mo_totalprice.TabIndex = 3;
            // 
            // txt_mo_cash_rcv
            // 
            this.txt_mo_cash_rcv.Enabled = false;
            this.txt_mo_cash_rcv.Location = new System.Drawing.Point(770, 384);
            this.txt_mo_cash_rcv.Name = "txt_mo_cash_rcv";
            this.txt_mo_cash_rcv.Size = new System.Drawing.Size(122, 20);
            this.txt_mo_cash_rcv.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(695, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Total price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(695, 387);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cash recive";
            // 
            // m_order_f
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 437);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_mo_cash_rcv);
            this.Controls.Add(this.txt_mo_totalprice);
            this.Controls.Add(this.btn_back_home);
            this.Controls.Add(this.dgv_forder);
            this.Controls.Add(this.tabControl1);
            this.Name = "m_order_f";
            this.Text = "m_order_f";
            this.Load += new System.EventHandler(this.m_order_f_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_forder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox lb_mo_recipt;
        private System.Windows.Forms.Button btn_mo_fi_find;
        private System.Windows.Forms.DateTimePicker dtp_mo_fi;
        private System.Windows.Forms.TextBox txt_mo_fi_rno;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgv_forder;
        private System.Windows.Forms.Button btn_back_home;
        private System.Windows.Forms.TextBox txt_mo_totalprice;
        private System.Windows.Forms.TextBox txt_mo_cash_rcv;
        private System.Windows.Forms.Button btn_mo_p_in;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}