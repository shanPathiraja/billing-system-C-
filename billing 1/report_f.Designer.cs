namespace billing_1
{
    partial class report_f
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
            this.dgv_rs_data = new System.Windows.Forms.DataGridView();
            this.btn_back = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_pc_bst_ctgry = new System.Windows.Forms.Button();
            this.cmb_f_b_ctgry = new System.Windows.Forms.ComboBox();
            this.btn_pc_f_smry = new System.Windows.Forms.Button();
            this.btn_pc_l_s_ctgry = new System.Windows.Forms.Button();
            this.rb_pc_smrz = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rb_sbd = new System.Windows.Forms.RadioButton();
            this.rb_sbm = new System.Windows.Forms.RadioButton();
            this.rb_sby = new System.Windows.Forms.RadioButton();
            this.dtp_r_f_date = new System.Windows.Forms.DateTimePicker();
            this.cmb_mp_sbm = new System.Windows.Forms.ComboBox();
            this.cmb_yp_sbm = new System.Windows.Forms.ComboBox();
            this.cmb_yp_sby = new System.Windows.Forms.ComboBox();
            this.btn_find_by_date = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rs_data)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_rs_data
            // 
            this.dgv_rs_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_rs_data.Location = new System.Drawing.Point(337, 31);
            this.dgv_rs_data.Name = "dgv_rs_data";
            this.dgv_rs_data.Size = new System.Drawing.Size(489, 331);
            this.dgv_rs_data.TabIndex = 1;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(36, 368);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 2;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.radioButton2);
            this.tabPage2.Controls.Add(this.rb_pc_smrz);
            this.tabPage2.Controls.Add(this.btn_pc_l_s_ctgry);
            this.tabPage2.Controls.Add(this.btn_pc_f_smry);
            this.tabPage2.Controls.Add(this.cmb_f_b_ctgry);
            this.tabPage2.Controls.Add(this.btn_pc_bst_ctgry);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(287, 305);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Product catogery";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_pc_bst_ctgry
            // 
            this.btn_pc_bst_ctgry.Enabled = false;
            this.btn_pc_bst_ctgry.Location = new System.Drawing.Point(6, 72);
            this.btn_pc_bst_ctgry.Name = "btn_pc_bst_ctgry";
            this.btn_pc_bst_ctgry.Size = new System.Drawing.Size(275, 39);
            this.btn_pc_bst_ctgry.TabIndex = 0;
            this.btn_pc_bst_ctgry.Text = "Best saling catogery";
            this.btn_pc_bst_ctgry.UseVisualStyleBackColor = true;
            this.btn_pc_bst_ctgry.Click += new System.EventHandler(this.btn_pc_bst_ctgry_Click);
            // 
            // cmb_f_b_ctgry
            // 
            this.cmb_f_b_ctgry.Enabled = false;
            this.cmb_f_b_ctgry.FormattingEnabled = true;
            this.cmb_f_b_ctgry.Location = new System.Drawing.Point(6, 205);
            this.cmb_f_b_ctgry.Name = "cmb_f_b_ctgry";
            this.cmb_f_b_ctgry.Size = new System.Drawing.Size(275, 21);
            this.cmb_f_b_ctgry.TabIndex = 1;
            this.cmb_f_b_ctgry.SelectedIndexChanged += new System.EventHandler(this.cmb_f_b_ctgry_SelectedIndexChanged);
            // 
            // btn_pc_f_smry
            // 
            this.btn_pc_f_smry.Enabled = false;
            this.btn_pc_f_smry.Location = new System.Drawing.Point(6, 35);
            this.btn_pc_f_smry.Name = "btn_pc_f_smry";
            this.btn_pc_f_smry.Size = new System.Drawing.Size(275, 31);
            this.btn_pc_f_smry.TabIndex = 2;
            this.btn_pc_f_smry.Text = "Get summery";
            this.btn_pc_f_smry.UseVisualStyleBackColor = true;
            this.btn_pc_f_smry.Click += new System.EventHandler(this.btn_pc_f_smry_Click);
            // 
            // btn_pc_l_s_ctgry
            // 
            this.btn_pc_l_s_ctgry.Enabled = false;
            this.btn_pc_l_s_ctgry.Location = new System.Drawing.Point(6, 117);
            this.btn_pc_l_s_ctgry.Name = "btn_pc_l_s_ctgry";
            this.btn_pc_l_s_ctgry.Size = new System.Drawing.Size(275, 33);
            this.btn_pc_l_s_ctgry.TabIndex = 3;
            this.btn_pc_l_s_ctgry.Text = "Low saling catogory";
            this.btn_pc_l_s_ctgry.UseVisualStyleBackColor = true;
            this.btn_pc_l_s_ctgry.Click += new System.EventHandler(this.btn_pc_l_s_ctgry_Click);
            // 
            // rb_pc_smrz
            // 
            this.rb_pc_smrz.AutoSize = true;
            this.rb_pc_smrz.Location = new System.Drawing.Point(6, 12);
            this.rb_pc_smrz.Name = "rb_pc_smrz";
            this.rb_pc_smrz.Size = new System.Drawing.Size(68, 17);
            this.rb_pc_smrz.TabIndex = 4;
            this.rb_pc_smrz.TabStop = true;
            this.rb_pc_smrz.Text = "Sumerize";
            this.rb_pc_smrz.UseVisualStyleBackColor = true;
            this.rb_pc_smrz.CheckedChanged += new System.EventHandler(this.rb_pc_smrz_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 182);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(103, 17);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Find by catogory";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged_1);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_find_by_date);
            this.tabPage1.Controls.Add(this.cmb_yp_sby);
            this.tabPage1.Controls.Add(this.cmb_yp_sbm);
            this.tabPage1.Controls.Add(this.cmb_mp_sbm);
            this.tabPage1.Controls.Add(this.dtp_r_f_date);
            this.tabPage1.Controls.Add(this.rb_sby);
            this.tabPage1.Controls.Add(this.rb_sbm);
            this.tabPage1.Controls.Add(this.rb_sbd);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(287, 305);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Search by date";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // rb_sbd
            // 
            this.rb_sbd.AutoSize = true;
            this.rb_sbd.Checked = true;
            this.rb_sbd.Location = new System.Drawing.Point(6, 32);
            this.rb_sbd.Name = "rb_sbd";
            this.rb_sbd.Size = new System.Drawing.Size(93, 17);
            this.rb_sbd.TabIndex = 0;
            this.rb_sbd.TabStop = true;
            this.rb_sbd.Text = "Select by date";
            this.rb_sbd.UseVisualStyleBackColor = true;
            this.rb_sbd.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rb_sbm
            // 
            this.rb_sbm.AutoSize = true;
            this.rb_sbm.Location = new System.Drawing.Point(6, 72);
            this.rb_sbm.Name = "rb_sbm";
            this.rb_sbm.Size = new System.Drawing.Size(99, 17);
            this.rb_sbm.TabIndex = 1;
            this.rb_sbm.Text = "select by mount";
            this.rb_sbm.UseVisualStyleBackColor = true;
            this.rb_sbm.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rb_sby
            // 
            this.rb_sby.AutoSize = true;
            this.rb_sby.Location = new System.Drawing.Point(6, 111);
            this.rb_sby.Name = "rb_sby";
            this.rb_sby.Size = new System.Drawing.Size(92, 17);
            this.rb_sby.TabIndex = 2;
            this.rb_sby.Text = "Select by year";
            this.rb_sby.UseVisualStyleBackColor = true;
            this.rb_sby.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // dtp_r_f_date
            // 
            this.dtp_r_f_date.Enabled = false;
            this.dtp_r_f_date.Location = new System.Drawing.Point(116, 32);
            this.dtp_r_f_date.Name = "dtp_r_f_date";
            this.dtp_r_f_date.Size = new System.Drawing.Size(167, 20);
            this.dtp_r_f_date.TabIndex = 3;
            this.dtp_r_f_date.Value = new System.DateTime(2018, 11, 3, 0, 0, 0, 0);
            // 
            // cmb_mp_sbm
            // 
            this.cmb_mp_sbm.Enabled = false;
            this.cmb_mp_sbm.FormattingEnabled = true;
            this.cmb_mp_sbm.Items.AddRange(new object[] {
            "Jan",
            "Feb",
            "Mar",
            "Apr",
            "May",
            "Jun",
            "Jul",
            "Aug",
            "Sep",
            "Oct",
            "Nov",
            "Dec"});
            this.cmb_mp_sbm.Location = new System.Drawing.Point(116, 72);
            this.cmb_mp_sbm.Name = "cmb_mp_sbm";
            this.cmb_mp_sbm.Size = new System.Drawing.Size(68, 21);
            this.cmb_mp_sbm.TabIndex = 4;
            this.cmb_mp_sbm.SelectedIndexChanged += new System.EventHandler(this.cmb_mp_sbm_SelectedIndexChanged);
            // 
            // cmb_yp_sbm
            // 
            this.cmb_yp_sbm.Enabled = false;
            this.cmb_yp_sbm.FormattingEnabled = true;
            this.cmb_yp_sbm.Items.AddRange(new object[] {
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025"});
            this.cmb_yp_sbm.Location = new System.Drawing.Point(190, 72);
            this.cmb_yp_sbm.Name = "cmb_yp_sbm";
            this.cmb_yp_sbm.Size = new System.Drawing.Size(83, 21);
            this.cmb_yp_sbm.TabIndex = 5;
            this.cmb_yp_sbm.SelectedIndexChanged += new System.EventHandler(this.cmb_yp_sbm_SelectedIndexChanged);
            // 
            // cmb_yp_sby
            // 
            this.cmb_yp_sby.Enabled = false;
            this.cmb_yp_sby.FormattingEnabled = true;
            this.cmb_yp_sby.Items.AddRange(new object[] {
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025"});
            this.cmb_yp_sby.Location = new System.Drawing.Point(116, 111);
            this.cmb_yp_sby.Name = "cmb_yp_sby";
            this.cmb_yp_sby.Size = new System.Drawing.Size(85, 21);
            this.cmb_yp_sby.TabIndex = 6;
            this.cmb_yp_sby.SelectedIndexChanged += new System.EventHandler(this.cmb_yp_sby_SelectedIndexChanged);
            // 
            // btn_find_by_date
            // 
            this.btn_find_by_date.Location = new System.Drawing.Point(116, 64);
            this.btn_find_by_date.Name = "btn_find_by_date";
            this.btn_find_by_date.Size = new System.Drawing.Size(157, 68);
            this.btn_find_by_date.TabIndex = 7;
            this.btn_find_by_date.Text = "Find";
            this.btn_find_by_date.UseVisualStyleBackColor = true;
            this.btn_find_by_date.Visible = false;
            this.btn_find_by_date.Click += new System.EventHandler(this.btn_find_by_date_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(36, 31);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(295, 331);
            this.tabControl1.TabIndex = 0;
            // 
            // report_f
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 403);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.dgv_rs_data);
            this.Controls.Add(this.tabControl1);
            this.Name = "report_f";
            this.Text = "report_f";
            this.Load += new System.EventHandler(this.report_f_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rs_data)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_rs_data;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton rb_pc_smrz;
        private System.Windows.Forms.Button btn_pc_l_s_ctgry;
        private System.Windows.Forms.Button btn_pc_f_smry;
        private System.Windows.Forms.ComboBox cmb_f_b_ctgry;
        private System.Windows.Forms.Button btn_pc_bst_ctgry;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_find_by_date;
        private System.Windows.Forms.ComboBox cmb_yp_sby;
        private System.Windows.Forms.ComboBox cmb_yp_sbm;
        private System.Windows.Forms.ComboBox cmb_mp_sbm;
        private System.Windows.Forms.DateTimePicker dtp_r_f_date;
        private System.Windows.Forms.RadioButton rb_sby;
        private System.Windows.Forms.RadioButton rb_sbm;
        private System.Windows.Forms.RadioButton rb_sbd;
        private System.Windows.Forms.TabControl tabControl1;
    }
}