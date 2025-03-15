namespace FileHandlingDemoTQ
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
            this.button1 = new System.Windows.Forms.Button();
            this.createFile = new System.Windows.Forms.Button();
            this.CreateFileUsingFileStream = new System.Windows.Forms.Button();
            this.ReadData = new System.Windows.Forms.Button();
            this.IOText = new System.Windows.Forms.TextBox();
            this.WriteData = new System.Windows.Forms.Button();
            this.DataRead = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.EmpId = new System.Windows.Forms.TextBox();
            this.EmpName = new System.Windows.Forms.TextBox();
            this.EmpSalary = new System.Windows.Forms.TextBox();
            this.SaveEmpData = new System.Windows.Forms.Button();
            this.ReadEmpData = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ClearFields = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 8);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Create Directory";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // createFile
            // 
            this.createFile.Location = new System.Drawing.Point(147, 8);
            this.createFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.createFile.Name = "createFile";
            this.createFile.Size = new System.Drawing.Size(91, 45);
            this.createFile.TabIndex = 1;
            this.createFile.Text = "Create File";
            this.createFile.UseVisualStyleBackColor = true;
            this.createFile.Click += new System.EventHandler(this.button2_Click);
            // 
            // CreateFileUsingFileStream
            // 
            this.CreateFileUsingFileStream.Location = new System.Drawing.Point(253, 8);
            this.CreateFileUsingFileStream.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CreateFileUsingFileStream.Name = "CreateFileUsingFileStream";
            this.CreateFileUsingFileStream.Size = new System.Drawing.Size(91, 45);
            this.CreateFileUsingFileStream.TabIndex = 2;
            this.CreateFileUsingFileStream.Text = "CreateFileUsingFileStream";
            this.CreateFileUsingFileStream.UseVisualStyleBackColor = true;
            this.CreateFileUsingFileStream.Click += new System.EventHandler(this.CreateFileUsingFileStream_Click);
            // 
            // ReadData
            // 
            this.ReadData.Location = new System.Drawing.Point(355, 8);
            this.ReadData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ReadData.Name = "ReadData";
            this.ReadData.Size = new System.Drawing.Size(91, 45);
            this.ReadData.TabIndex = 3;
            this.ReadData.Text = "ReadData";
            this.ReadData.UseVisualStyleBackColor = true;
            this.ReadData.Click += new System.EventHandler(this.ReadData_Click);
            // 
            // IOText
            // 
            this.IOText.Location = new System.Drawing.Point(39, 72);
            this.IOText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.IOText.Name = "IOText";
            this.IOText.Size = new System.Drawing.Size(191, 20);
            this.IOText.TabIndex = 4;
            this.IOText.TextChanged += new System.EventHandler(this.IOText_TextChanged);
            // 
            // WriteData
            // 
            this.WriteData.Location = new System.Drawing.Point(39, 93);
            this.WriteData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.WriteData.Name = "WriteData";
            this.WriteData.Size = new System.Drawing.Size(91, 24);
            this.WriteData.TabIndex = 5;
            this.WriteData.Text = "WriteData";
            this.WriteData.UseVisualStyleBackColor = true;
            this.WriteData.Click += new System.EventHandler(this.WriteData_Click);
            // 
            // DataRead
            // 
            this.DataRead.Location = new System.Drawing.Point(137, 93);
            this.DataRead.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DataRead.Name = "DataRead";
            this.DataRead.Size = new System.Drawing.Size(91, 24);
            this.DataRead.TabIndex = 6;
            this.DataRead.Text = "ReadData";
            this.DataRead.UseVisualStyleBackColor = true;
            this.DataRead.Click += new System.EventHandler(this.DataRead_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Enter Data Here:";
            // 
            // EmpId
            // 
            this.EmpId.Location = new System.Drawing.Point(329, 79);
            this.EmpId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EmpId.Name = "EmpId";
            this.EmpId.Size = new System.Drawing.Size(191, 20);
            this.EmpId.TabIndex = 8;
            this.EmpId.TextChanged += new System.EventHandler(this.EmpId_TextChanged);
            // 
            // EmpName
            // 
            this.EmpName.Location = new System.Drawing.Point(329, 108);
            this.EmpName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EmpName.Name = "EmpName";
            this.EmpName.Size = new System.Drawing.Size(191, 20);
            this.EmpName.TabIndex = 9;
            this.EmpName.TextChanged += new System.EventHandler(this.EmpName_TextChanged);
            // 
            // EmpSalary
            // 
            this.EmpSalary.Location = new System.Drawing.Point(329, 137);
            this.EmpSalary.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EmpSalary.Name = "EmpSalary";
            this.EmpSalary.Size = new System.Drawing.Size(191, 20);
            this.EmpSalary.TabIndex = 10;
            this.EmpSalary.TextChanged += new System.EventHandler(this.EmpSalary_TextChanged);
            // 
            // SaveEmpData
            // 
            this.SaveEmpData.Location = new System.Drawing.Point(329, 165);
            this.SaveEmpData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SaveEmpData.Name = "SaveEmpData";
            this.SaveEmpData.Size = new System.Drawing.Size(76, 24);
            this.SaveEmpData.TabIndex = 11;
            this.SaveEmpData.Text = "Save Data";
            this.SaveEmpData.UseVisualStyleBackColor = true;
            this.SaveEmpData.Click += new System.EventHandler(this.SaveEmpData_Click);
            // 
            // ReadEmpData
            // 
            this.ReadEmpData.Location = new System.Drawing.Point(435, 165);
            this.ReadEmpData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ReadEmpData.Name = "ReadEmpData";
            this.ReadEmpData.Size = new System.Drawing.Size(84, 24);
            this.ReadEmpData.TabIndex = 12;
            this.ReadEmpData.Text = "View Data";
            this.ReadEmpData.UseVisualStyleBackColor = true;
            this.ReadEmpData.Click += new System.EventHandler(this.ReadEmpData_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(284, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(284, 141);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Salary:";
            // 
            // ClearFields
            // 
            this.ClearFields.Location = new System.Drawing.Point(379, 193);
            this.ClearFields.Margin = new System.Windows.Forms.Padding(2);
            this.ClearFields.Name = "ClearFields";
            this.ClearFields.Size = new System.Drawing.Size(76, 24);
            this.ClearFields.TabIndex = 16;
            this.ClearFields.Text = "Clear Fields";
            this.ClearFields.UseVisualStyleBackColor = true;
            this.ClearFields.Click += new System.EventHandler(this.ClearFields_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 287);
            this.Controls.Add(this.ClearFields);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ReadEmpData);
            this.Controls.Add(this.SaveEmpData);
            this.Controls.Add(this.EmpSalary);
            this.Controls.Add(this.EmpName);
            this.Controls.Add(this.EmpId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataRead);
            this.Controls.Add(this.WriteData);
            this.Controls.Add(this.IOText);
            this.Controls.Add(this.ReadData);
            this.Controls.Add(this.CreateFileUsingFileStream);
            this.Controls.Add(this.createFile);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button createFile;
        private System.Windows.Forms.Button CreateFileUsingFileStream;
        private System.Windows.Forms.Button ReadData;
        private System.Windows.Forms.TextBox IOText;
        private System.Windows.Forms.Button WriteData;
        private System.Windows.Forms.Button DataRead;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EmpId;
        private System.Windows.Forms.TextBox EmpName;
        private System.Windows.Forms.TextBox EmpSalary;
        private System.Windows.Forms.Button SaveEmpData;
        private System.Windows.Forms.Button ReadEmpData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ClearFields;
    }
}

