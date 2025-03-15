namespace DiconnectedDemoTQ
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Show = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(96, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 26);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(96, 144);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(170, 26);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(96, 218);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(170, 26);
            this.textBox3.TabIndex = 2;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(96, 264);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(79, 42);
            this.Save.TabIndex = 3;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(187, 264);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(79, 42);
            this.Update.TabIndex = 4;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(96, 329);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(79, 42);
            this.Search.TabIndex = 5;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(187, 329);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(79, 42);
            this.Delete.TabIndex = 6;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Show
            // 
            this.Show.Location = new System.Drawing.Point(142, 377);
            this.Show.Name = "Show";
            this.Show.Size = new System.Drawing.Size(79, 42);
            this.Show.TabIndex = 7;
            this.Show.Text = "Show";
            this.Show.UseVisualStyleBackColor = true;
            this.Show.Click += new System.EventHandler(this.Show_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(307, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(335, 236);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Id";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Salary";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(271, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Disconnected Architecture Demo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Show);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Show;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

