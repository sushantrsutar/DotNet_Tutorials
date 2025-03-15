namespace ADOPractice
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.TextBox();
            this.Gender = new System.Windows.Forms.TextBox();
            this.Age = new System.Windows.Forms.TextBox();
            this.AddEmployee = new System.Windows.Forms.Button();
            this.DeleteEmployee = new System.Windows.Forms.Button();
            this.UpdateEmployee = new System.Windows.Forms.Button();
            this.ShowEmployee = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gender:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Age:";
            // 
            // Id
            // 
            this.Id.Location = new System.Drawing.Point(122, 45);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(237, 26);
            this.Id.TabIndex = 4;
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(122, 109);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(237, 26);
            this.Name.TabIndex = 5;
            this.Name.TextChanged += new System.EventHandler(this.Name_TextChanged);
            // 
            // Gender
            // 
            this.Gender.Location = new System.Drawing.Point(122, 165);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(237, 26);
            this.Gender.TabIndex = 6;
            // 
            // Age
            // 
            this.Age.Location = new System.Drawing.Point(122, 224);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(237, 26);
            this.Age.TabIndex = 7;
            // 
            // AddEmployee
            // 
            this.AddEmployee.Location = new System.Drawing.Point(50, 283);
            this.AddEmployee.Name = "AddEmployee";
            this.AddEmployee.Size = new System.Drawing.Size(146, 36);
            this.AddEmployee.TabIndex = 8;
            this.AddEmployee.Text = "Add";
            this.AddEmployee.UseVisualStyleBackColor = true;
            this.AddEmployee.Click += new System.EventHandler(this.AddEmployee_Click);
            // 
            // DeleteEmployee
            // 
            this.DeleteEmployee.Location = new System.Drawing.Point(50, 336);
            this.DeleteEmployee.Name = "DeleteEmployee";
            this.DeleteEmployee.Size = new System.Drawing.Size(146, 36);
            this.DeleteEmployee.TabIndex = 9;
            this.DeleteEmployee.Text = "Delete";
            this.DeleteEmployee.UseVisualStyleBackColor = true;
            // 
            // UpdateEmployee
            // 
            this.UpdateEmployee.Location = new System.Drawing.Point(213, 283);
            this.UpdateEmployee.Name = "UpdateEmployee";
            this.UpdateEmployee.Size = new System.Drawing.Size(146, 36);
            this.UpdateEmployee.TabIndex = 10;
            this.UpdateEmployee.Text = "Upadate";
            this.UpdateEmployee.UseVisualStyleBackColor = true;
            // 
            // ShowEmployee
            // 
            this.ShowEmployee.Location = new System.Drawing.Point(213, 336);
            this.ShowEmployee.Name = "ShowEmployee";
            this.ShowEmployee.Size = new System.Drawing.Size(146, 36);
            this.ShowEmployee.TabIndex = 11;
            this.ShowEmployee.Text = "Show";
            this.ShowEmployee.UseVisualStyleBackColor = true;
            this.ShowEmployee.Click += new System.EventHandler(this.ShowEmployee_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(392, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(396, 327);
            this.dataGridView1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ShowEmployee);
            this.Controls.Add(this.UpdateEmployee);
            this.Controls.Add(this.DeleteEmployee);
            this.Controls.Add(this.AddEmployee);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            //this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Id;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.TextBox Gender;
        private System.Windows.Forms.TextBox Age;
        private System.Windows.Forms.Button AddEmployee;
        private System.Windows.Forms.Button DeleteEmployee;
        private System.Windows.Forms.Button UpdateEmployee;
        private System.Windows.Forms.Button ShowEmployee;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

