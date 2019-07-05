namespace billing_1
{
    partial class return_invoice
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
            this.txt_r_invo_code = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_r_invoice = new System.Windows.Forms.DataGridView();
            this.txt_r_i_no = new System.Windows.Forms.TextBox();
            this.txt_re_quntity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_r_item = new System.Windows.Forms.Button();
            this.btn_m_back = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_avlbl_quntity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_prnt_invoice = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_r_invoice)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_r_invo_code
            // 
            this.txt_r_invo_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_r_invo_code.Location = new System.Drawing.Point(236, 78);
            this.txt_r_invo_code.Name = "txt_r_invo_code";
            this.txt_r_invo_code.Size = new System.Drawing.Size(142, 30);
            this.txt_r_invo_code.TabIndex = 0;
            this.txt_r_invo_code.TextChanged += new System.EventHandler(this.txt_r_invo_code_TextChanged);
            this.txt_r_invo_code.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_r_invo_code_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter invoice number";
            // 
            // dgv_r_invoice
            // 
            this.dgv_r_invoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_r_invoice.Location = new System.Drawing.Point(463, 12);
            this.dgv_r_invoice.Name = "dgv_r_invoice";
            this.dgv_r_invoice.Size = new System.Drawing.Size(440, 494);
            this.dgv_r_invoice.TabIndex = 2;
            this.dgv_r_invoice.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_r_invoice_CellContentClick);
            // 
            // txt_r_i_no
            // 
            this.txt_r_i_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_r_i_no.Location = new System.Drawing.Point(235, 114);
            this.txt_r_i_no.Name = "txt_r_i_no";
            this.txt_r_i_no.Size = new System.Drawing.Size(142, 30);
            this.txt_r_i_no.TabIndex = 3;
            // 
            // txt_re_quntity
            // 
            this.txt_re_quntity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_re_quntity.Location = new System.Drawing.Point(235, 186);
            this.txt_re_quntity.Name = "txt_re_quntity";
            this.txt_re_quntity.Size = new System.Drawing.Size(142, 30);
            this.txt_re_quntity.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Retened quntity";
            // 
            // btn_r_item
            // 
            this.btn_r_item.Enabled = false;
            this.btn_r_item.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_r_item.Location = new System.Drawing.Point(73, 269);
            this.btn_r_item.Name = "btn_r_item";
            this.btn_r_item.Size = new System.Drawing.Size(143, 73);
            this.btn_r_item.TabIndex = 6;
            this.btn_r_item.Text = "Return a Item";
            this.btn_r_item.UseVisualStyleBackColor = true;
            this.btn_r_item.Click += new System.EventHandler(this.btn_r_item_Click);
            // 
            // btn_m_back
            // 
            this.btn_m_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_m_back.Location = new System.Drawing.Point(236, 269);
            this.btn_m_back.Name = "btn_m_back";
            this.btn_m_back.Size = new System.Drawing.Size(143, 72);
            this.btn_m_back.TabIndex = 7;
            this.btn_m_back.Text = "Mouny Back";
            this.btn_m_back.UseVisualStyleBackColor = true;
            this.btn_m_back.Click += new System.EventHandler(this.btn_m_back_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Item Number";
            // 
            // txt_avlbl_quntity
            // 
            this.txt_avlbl_quntity.Enabled = false;
            this.txt_avlbl_quntity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_avlbl_quntity.Location = new System.Drawing.Point(236, 150);
            this.txt_avlbl_quntity.Name = "txt_avlbl_quntity";
            this.txt_avlbl_quntity.Size = new System.Drawing.Size(143, 30);
            this.txt_avlbl_quntity.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Available quntity";
            // 
            // btn_prnt_invoice
            // 
            this.btn_prnt_invoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prnt_invoice.Location = new System.Drawing.Point(1116, 512);
            this.btn_prnt_invoice.Name = "btn_prnt_invoice";
            this.btn_prnt_invoice.Size = new System.Drawing.Size(158, 55);
            this.btn_prnt_invoice.TabIndex = 11;
            this.btn_prnt_invoice.Text = "Print";
            this.btn_prnt_invoice.UseVisualStyleBackColor = true;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(27, 515);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(85, 51);
            this.btn_back.TabIndex = 12;
            this.btn_back.Text = "button1";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // return_invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 588);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_prnt_invoice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_avlbl_quntity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_m_back);
            this.Controls.Add(this.btn_r_item);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_re_quntity);
            this.Controls.Add(this.txt_r_i_no);
            this.Controls.Add(this.dgv_r_invoice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_r_invo_code);
            this.Name = "return_invoice";
            this.Text = "return_invoice";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_r_invoice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_r_invo_code;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_r_invoice;
        private System.Windows.Forms.TextBox txt_r_i_no;
        private System.Windows.Forms.TextBox txt_re_quntity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_r_item;
        private System.Windows.Forms.Button btn_m_back;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_avlbl_quntity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_prnt_invoice;
        private System.Windows.Forms.Button btn_back;
    }
}