namespace billing_1
{
    partial class c_stoke_f
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
            this.dgv_c_stoke = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_c_stoke)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_c_stoke
            // 
            this.dgv_c_stoke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_c_stoke.Location = new System.Drawing.Point(275, 12);
            this.dgv_c_stoke.Name = "dgv_c_stoke";
            this.dgv_c_stoke.Size = new System.Drawing.Size(695, 590);
            this.dgv_c_stoke.TabIndex = 0;
            this.dgv_c_stoke.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // c_stoke_f
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 581);
            this.Controls.Add(this.dgv_c_stoke);
            this.Name = "c_stoke_f";
            this.Text = "c_stoke_f";
            this.Load += new System.EventHandler(this.c_stoke_f_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_c_stoke)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_c_stoke;
    }
}