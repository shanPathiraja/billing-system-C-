namespace billing_1
{
    partial class New_order_Form
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
            this.dgv_invoice = new System.Windows.Forms.DataGridView();
            this.txt_norder_icode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_norder_iqunty = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_norder_add = new System.Windows.Forms.Button();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.btn_prnt_invoice = new System.Windows.Forms.Button();
            this.btn_delete_data_invoice = new System.Windows.Forms.Button();
            this.txt_csh_rcv = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_balance = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_invoice)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_invoice
            // 
            this.dgv_invoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_invoice.Location = new System.Drawing.Point(566, 12);
            this.dgv_invoice.Name = "dgv_invoice";
            this.dgv_invoice.Size = new System.Drawing.Size(594, 509);
            this.dgv_invoice.TabIndex = 0;
            // 
            // txt_norder_icode
            // 
            this.txt_norder_icode.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_norder_icode.Location = new System.Drawing.Point(206, 88);
            this.txt_norder_icode.Name = "txt_norder_icode";
            this.txt_norder_icode.Size = new System.Drawing.Size(342, 38);
            this.txt_norder_icode.TabIndex = 1;
            this.txt_norder_icode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_norder_icode_KeyDown);
            this.txt_norder_icode.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txt_norder_icode_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Item Code";
            // 
            // txt_norder_iqunty
            // 
            this.txt_norder_iqunty.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_norder_iqunty.Location = new System.Drawing.Point(206, 154);
            this.txt_norder_iqunty.Name = "txt_norder_iqunty";
            this.txt_norder_iqunty.Size = new System.Drawing.Size(342, 38);
            this.txt_norder_iqunty.TabIndex = 3;
            this.txt_norder_iqunty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_norder_iqunty_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Quntity";
            // 
            // btn_norder_add
            // 
            this.btn_norder_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_norder_add.Location = new System.Drawing.Point(206, 220);
            this.btn_norder_add.Name = "btn_norder_add";
            this.btn_norder_add.Size = new System.Drawing.Size(160, 70);
            this.btn_norder_add.TabIndex = 5;
            this.btn_norder_add.Text = "Add";
            this.btn_norder_add.UseVisualStyleBackColor = true;
            this.btn_norder_add.Click += new System.EventHandler(this.btn_norder_add_Click);
            // 
            // txt_total
            // 
            this.txt_total.Enabled = false;
            this.txt_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total.Location = new System.Drawing.Point(749, 550);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(154, 38);
            this.txt_total.TabIndex = 6;
            // 
            // btn_prnt_invoice
            // 
            this.btn_prnt_invoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prnt_invoice.Location = new System.Drawing.Point(939, 550);
            this.btn_prnt_invoice.Name = "btn_prnt_invoice";
            this.btn_prnt_invoice.Size = new System.Drawing.Size(230, 70);
            this.btn_prnt_invoice.TabIndex = 7;
            this.btn_prnt_invoice.Text = "Print invoice";
            this.btn_prnt_invoice.UseVisualStyleBackColor = true;
            this.btn_prnt_invoice.Click += new System.EventHandler(this.btn_prnt_invoice_Click);
            // 
            // btn_delete_data_invoice
            // 
            this.btn_delete_data_invoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete_data_invoice.Location = new System.Drawing.Point(386, 220);
            this.btn_delete_data_invoice.Name = "btn_delete_data_invoice";
            this.btn_delete_data_invoice.Size = new System.Drawing.Size(160, 70);
            this.btn_delete_data_invoice.TabIndex = 8;
            this.btn_delete_data_invoice.Text = "Delete";
            this.btn_delete_data_invoice.UseVisualStyleBackColor = true;
            this.btn_delete_data_invoice.Click += new System.EventHandler(this.btn_delete_data_invoice_Click);
            // 
            // txt_csh_rcv
            // 
            this.txt_csh_rcv.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_csh_rcv.Location = new System.Drawing.Point(749, 594);
            this.txt_csh_rcv.Name = "txt_csh_rcv";
            this.txt_csh_rcv.Size = new System.Drawing.Size(154, 38);
            this.txt_csh_rcv.TabIndex = 9;
            this.txt_csh_rcv.Text = "0";
            this.txt_csh_rcv.TextChanged += new System.EventHandler(this.txt_csh_rcv_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(35, 550);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 70);
            this.button1.TabIndex = 10;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(206, 550);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(250, 70);
            this.button2.TabIndex = 11;
            this.button2.Text = "Return invoice";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_balance
            // 
            this.txt_balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_balance.Location = new System.Drawing.Point(287, 420);
            this.txt_balance.Name = "txt_balance";
            this.txt_balance.Size = new System.Drawing.Size(152, 38);
            this.txt_balance.TabIndex = 12;
            this.txt_balance.Visible = false;
            this.txt_balance.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_balance_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(574, 550);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 31);
            this.label3.TabIndex = 13;
            this.label3.Text = "Total ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(574, 594);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 31);
            this.label4.TabIndex = 14;
            this.label4.Text = "Cash recive";
            // 
            // New_order_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::billing_1.Properties.Resources.Home_background;
            this.ClientSize = new System.Drawing.Size(1234, 661);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_balance);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_csh_rcv);
            this.Controls.Add(this.btn_delete_data_invoice);
            this.Controls.Add(this.btn_prnt_invoice);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.btn_norder_add);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_norder_iqunty);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_norder_icode);
            this.Controls.Add(this.dgv_invoice);
            this.Name = "New_order_Form";
            this.Text = "New_order_Form";
            this.Load += new System.EventHandler(this.New_order_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_invoice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_invoice;
        private System.Windows.Forms.TextBox txt_norder_icode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_norder_iqunty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_norder_add;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Button btn_prnt_invoice;
        private System.Windows.Forms.Button btn_delete_data_invoice;
        private System.Windows.Forms.TextBox txt_csh_rcv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_balance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}