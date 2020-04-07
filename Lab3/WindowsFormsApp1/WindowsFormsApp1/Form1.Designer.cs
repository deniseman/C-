namespace WindowsFormsApp1
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
            System.Windows.Forms.Label Oras;
            this.listBox_Univ = new System.Windows.Forms.ListBox();
            this.listBox_Fac = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addFac = new System.Windows.Forms.Button();
            this.delFac = new System.Windows.Forms.Button();
            this.deleteUniv = new System.Windows.Forms.Button();
            this.updateUniv = new System.Windows.Forms.Button();
            this.addUniv = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox_CodeUniv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_City = new System.Windows.Forms.TextBox();
            Oras = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Oras
            // 
            Oras.AutoSize = true;
            Oras.Location = new System.Drawing.Point(416, 25);
            Oras.Name = "Oras";
            Oras.Size = new System.Drawing.Size(29, 13);
            Oras.TabIndex = 2;
            Oras.Text = "Oras";
            // 
            // listBox_Univ
            // 
            this.listBox_Univ.FormattingEnabled = true;
            this.listBox_Univ.Location = new System.Drawing.Point(6, 19);
            this.listBox_Univ.Name = "listBox_Univ";
            this.listBox_Univ.Size = new System.Drawing.Size(133, 121);
            this.listBox_Univ.TabIndex = 0;
            this.listBox_Univ.SelectedIndexChanged += new System.EventHandler(this.listbox_Univ_SelectedIndexChanged);
            // 
            // listBox_Fac
            // 
            this.listBox_Fac.FormattingEnabled = true;
            this.listBox_Fac.Location = new System.Drawing.Point(145, 19);
            this.listBox_Fac.Name = "listBox_Fac";
            this.listBox_Fac.Size = new System.Drawing.Size(120, 121);
            this.listBox_Fac.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addFac);
            this.groupBox1.Controls.Add(this.delFac);
            this.groupBox1.Controls.Add(this.deleteUniv);
            this.groupBox1.Controls.Add(this.updateUniv);
            this.groupBox1.Controls.Add(this.addUniv);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.textBox_CodeUniv);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_City);
            this.groupBox1.Controls.Add(Oras);
            this.groupBox1.Controls.Add(this.listBox_Univ);
            this.groupBox1.Controls.Add(this.listBox_Fac);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(558, 357);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Exemplu BD";
            // 
            // addFac
            // 
            this.addFac.Location = new System.Drawing.Point(397, 276);
            this.addFac.Name = "addFac";
            this.addFac.Size = new System.Drawing.Size(99, 23);
            this.addFac.TabIndex = 11;
            this.addFac.Text = "Add Faculty";
            this.addFac.UseVisualStyleBackColor = true;
            this.addFac.Click += new System.EventHandler(this.addFac_Click);
            // 
            // delFac
            // 
            this.delFac.Location = new System.Drawing.Point(397, 328);
            this.delFac.Name = "delFac";
            this.delFac.Size = new System.Drawing.Size(99, 23);
            this.delFac.TabIndex = 10;
            this.delFac.Text = "Delete Faculty";
            this.delFac.UseVisualStyleBackColor = true;
            this.delFac.Click += new System.EventHandler(this.delFac_Click);
            // 
            // deleteUniv
            // 
            this.deleteUniv.Location = new System.Drawing.Point(283, 117);
            this.deleteUniv.Name = "deleteUniv";
            this.deleteUniv.Size = new System.Drawing.Size(99, 23);
            this.deleteUniv.TabIndex = 9;
            this.deleteUniv.Text = "Delete University";
            this.deleteUniv.UseVisualStyleBackColor = true;
            this.deleteUniv.Click += new System.EventHandler(this.button3_Click);
            // 
            // updateUniv
            // 
            this.updateUniv.Location = new System.Drawing.Point(282, 68);
            this.updateUniv.Name = "updateUniv";
            this.updateUniv.Size = new System.Drawing.Size(100, 23);
            this.updateUniv.TabIndex = 8;
            this.updateUniv.Text = "Update University";
            this.updateUniv.UseVisualStyleBackColor = true;
            this.updateUniv.Click += new System.EventHandler(this.updateUniv_Click);
            // 
            // addUniv
            // 
            this.addUniv.Location = new System.Drawing.Point(282, 19);
            this.addUniv.Name = "addUniv";
            this.addUniv.Size = new System.Drawing.Size(100, 23);
            this.addUniv.TabIndex = 7;
            this.addUniv.Text = "Add University";
            this.addUniv.UseVisualStyleBackColor = true;
            this.addUniv.Click += new System.EventHandler(this.addUniv_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 146);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(362, 205);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBox_CodeUniv
            // 
            this.textBox_CodeUniv.Location = new System.Drawing.Point(451, 71);
            this.textBox_CodeUniv.Name = "textBox_CodeUniv";
            this.textBox_CodeUniv.ReadOnly = true;
            this.textBox_CodeUniv.Size = new System.Drawing.Size(100, 20);
            this.textBox_CodeUniv.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(394, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cod Univ";
            // 
            // textBox_City
            // 
            this.textBox_City.AccessibleName = "";
            this.textBox_City.Location = new System.Drawing.Point(451, 22);
            this.textBox_City.Name = "textBox_City";
            this.textBox_City.ReadOnly = true;
            this.textBox_City.Size = new System.Drawing.Size(100, 20);
            this.textBox_City.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 381);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Univ;
        private System.Windows.Forms.ListBox listBox_Fac;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_CodeUniv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_City;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button deleteUniv;
        private System.Windows.Forms.Button updateUniv;
        private System.Windows.Forms.Button addUniv;
        private System.Windows.Forms.Button addFac;
        private System.Windows.Forms.Button delFac;
    }
}

