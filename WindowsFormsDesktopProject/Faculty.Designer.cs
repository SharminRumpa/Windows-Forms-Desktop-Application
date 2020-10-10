namespace WindowsFormsDesktopProject
{
    partial class Faculty
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.InsertF = new System.Windows.Forms.Button();
            this.updateF = new System.Windows.Forms.Button();
            this.delectF = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Faculty Id :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(317, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Faculty Name :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(317, 125);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(163, 20);
            this.textBox2.TabIndex = 3;
            // 
            // InsertF
            // 
            this.InsertF.Location = new System.Drawing.Point(151, 186);
            this.InsertF.Name = "InsertF";
            this.InsertF.Size = new System.Drawing.Size(112, 23);
            this.InsertF.TabIndex = 4;
            this.InsertF.Text = "Insert";
            this.InsertF.UseVisualStyleBackColor = true;
            this.InsertF.Click += new System.EventHandler(this.InsertF_Click);
            // 
            // updateF
            // 
            this.updateF.Location = new System.Drawing.Point(305, 186);
            this.updateF.Name = "updateF";
            this.updateF.Size = new System.Drawing.Size(122, 23);
            this.updateF.TabIndex = 5;
            this.updateF.Text = "Update";
            this.updateF.UseVisualStyleBackColor = true;
            this.updateF.Click += new System.EventHandler(this.updateF_Click);
            // 
            // delectF
            // 
            this.delectF.Location = new System.Drawing.Point(467, 186);
            this.delectF.Name = "delectF";
            this.delectF.Size = new System.Drawing.Size(137, 23);
            this.delectF.TabIndex = 6;
            this.delectF.Text = "Delect";
            this.delectF.UseVisualStyleBackColor = true;
            this.delectF.Click += new System.EventHandler(this.delectF_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(62, 236);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(617, 165);
            this.dataGridView1.TabIndex = 7;
            // 
            // Faculty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.delectF);
            this.Controls.Add(this.updateF);
            this.Controls.Add(this.InsertF);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Faculty";
            this.Text = "Faculty";
            this.Load += new System.EventHandler(this.Faculty_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button InsertF;
        private System.Windows.Forms.Button updateF;
        private System.Windows.Forms.Button delectF;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}