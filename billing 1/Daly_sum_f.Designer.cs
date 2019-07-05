namespace billing_1
{
    partial class Daly_sum_f
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_daly_sum = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_tdy_gain = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_prnt_dly_smmry = new System.Windows.Forms.Button();
            this.txt_dly_incm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_daly_sum)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Thistle;
            this.label1.Location = new System.Drawing.Point(101, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "අද දින විකුණුම්";
            // 
            // dgv_daly_sum
            // 
            this.dgv_daly_sum.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_daly_sum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_daly_sum.Location = new System.Drawing.Point(447, 11);
            this.dgv_daly_sum.Name = "dgv_daly_sum";
            this.dgv_daly_sum.Size = new System.Drawing.Size(666, 452);
            this.dgv_daly_sum.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(21, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 100);
            this.button1.TabIndex = 2;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_tdy_gain
            // 
            this.txt_tdy_gain.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tdy_gain.Location = new System.Drawing.Point(170, 159);
            this.txt_tdy_gain.Name = "txt_tdy_gain";
            this.txt_tdy_gain.Size = new System.Drawing.Size(244, 30);
            this.txt_tdy_gain.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "අද දින ලාබය";
            // 
            // btn_prnt_dly_smmry
            // 
            this.btn_prnt_dly_smmry.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prnt_dly_smmry.Location = new System.Drawing.Point(202, 356);
            this.btn_prnt_dly_smmry.Name = "btn_prnt_dly_smmry";
            this.btn_prnt_dly_smmry.Size = new System.Drawing.Size(203, 93);
            this.btn_prnt_dly_smmry.TabIndex = 7;
            this.btn_prnt_dly_smmry.Text = "Print daly summery";
            this.btn_prnt_dly_smmry.UseVisualStyleBackColor = true;
            this.btn_prnt_dly_smmry.Click += new System.EventHandler(this.btn_prnt_dly_smmry_Click);
            // 
            // txt_dly_incm
            // 
            this.txt_dly_incm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dly_incm.Location = new System.Drawing.Point(170, 221);
            this.txt_dly_incm.Name = "txt_dly_incm";
            this.txt_dly_incm.Size = new System.Drawing.Size(244, 30);
            this.txt_dly_incm.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "අද දින ලැබීම්";
            // 
            // Daly_sum_f
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::billing_1.Properties.Resources._619823;
            this.ClientSize = new System.Drawing.Size(1135, 492);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_dly_incm);
            this.Controls.Add(this.btn_prnt_dly_smmry);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_tdy_gain);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv_daly_sum);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Daly_sum_f";
            this.Text = "Daly_sum_f";
            this.Load += new System.EventHandler(this.Daly_sum_f_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_daly_sum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_daly_sum;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_tdy_gain;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_prnt_dly_smmry;
        private System.Windows.Forms.TextBox txt_dly_incm;
        private System.Windows.Forms.Label label3;
    }
}