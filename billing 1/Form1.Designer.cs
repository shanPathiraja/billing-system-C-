namespace billing_1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.txt_uname = new System.Windows.Forms.TextBox();
            this.txt_psswrd = new System.Windows.Forms.TextBox();
            this.btn_loging = new System.Windows.Forms.Button();
            this.database91DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database91DataSet = new billing_1.Database91DataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.database91DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database91DataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_uname
            // 
            this.txt_uname.Location = new System.Drawing.Point(114, 39);
            this.txt_uname.Name = "txt_uname";
            this.txt_uname.Size = new System.Drawing.Size(123, 20);
            this.txt_uname.TabIndex = 0;
            this.txt_uname.Text = "admin";
            this.txt_uname.TextChanged += new System.EventHandler(this.txt_uname_TextChanged);
            this.txt_uname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_uname_KeyDown);
            // 
            // txt_psswrd
            // 
            this.txt_psswrd.Location = new System.Drawing.Point(114, 61);
            this.txt_psswrd.Name = "txt_psswrd";
            this.txt_psswrd.PasswordChar = '*';
            this.txt_psswrd.Size = new System.Drawing.Size(123, 20);
            this.txt_psswrd.TabIndex = 0;
            this.txt_psswrd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_psswrd_KeyDown);
            // 
            // btn_loging
            // 
            this.btn_loging.Location = new System.Drawing.Point(111, 104);
            this.btn_loging.Name = "btn_loging";
            this.btn_loging.Size = new System.Drawing.Size(123, 21);
            this.btn_loging.TabIndex = 1;
            this.btn_loging.Text = "loging";
            this.btn_loging.UseVisualStyleBackColor = true;
            this.btn_loging.Click += new System.EventHandler(this.btn_loging_Click);
            // 
            // database91DataSetBindingSource
            // 
            this.database91DataSetBindingSource.DataSource = this.database91DataSet;
            this.database91DataSetBindingSource.Position = 0;
            // 
            // database91DataSet
            // 
            this.database91DataSet.DataSetName = "Database91DataSet";
            this.database91DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "user name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "password";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_loging);
            this.groupBox1.Controls.Add(this.txt_psswrd);
            this.groupBox1.Controls.Add(this.txt_uname);
            this.groupBox1.Location = new System.Drawing.Point(195, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 167);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loging";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::billing_1.Properties.Resources.SC_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(-3, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 66);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 181);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Loging";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.database91DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database91DataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_uname;
        private System.Windows.Forms.TextBox txt_psswrd;
        private System.Windows.Forms.Button btn_loging;
        private System.Windows.Forms.BindingSource database91DataSetBindingSource;
        private Database91DataSet database91DataSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

