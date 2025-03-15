using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileHandlingDemoTQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"E:\DemoFolder";
                if (Directory.Exists(path))
                {
                    MessageBox.Show("Directory Exists");
                }
                else { 
                    Directory.CreateDirectory(path);
                    MessageBox.Show("New diresctory Created");
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = @"E:\DemoFolder\file1.dat";
                if (File.Exists(fileName))
                {
                    MessageBox.Show("File Exists");
                }
                else { 
                    File.Create(fileName);
                    MessageBox.Show("File Created");
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

        }

        private void CreateFileUsingFileStream_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = @"E:\DemoFolder\file2.dat";
                FileStream fs = new FileStream(fileName,FileMode.Create);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write("Iron-Man");
                bw.Close();
                fs.Close();
                MessageBox.Show("file created");
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void ReadData_Click(object sender, EventArgs e)
        {
            try {
                string fileName = @"E:\DemoFolder\file2.dat";
                FileStream fs= new FileStream(fileName,FileMode.Open);
                //FileStream fs = new FileStream(fileName, FileMode.Open,FileAccess.Write);//we can not read this file
                BinaryReader br = new BinaryReader(fs);
                MessageBox.Show("data : "+br.ReadString());
                //MessageBox.Show("data : " + br.Read());//return num of chars
                br.Close();
                fs.Close();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void IOText_TextChanged(object sender, EventArgs e)
        {

        }

        private void WriteData_Click(object sender, EventArgs e)
        {
            try
            {
                string data = IOText.Text;
                int length= data.Length;
                //MessageBox.Show(length.ToString());
                if (length == 0)
                {
                    MessageBox.Show("please Enter Data ");
                }
                else
                {
                    string fileName = @"E:\DemoFolder\file3.dat";
                    FileStream fs = new FileStream(fileName, FileMode.Create);
                    BinaryWriter bw = new BinaryWriter(fs);
                    bw.Write(data);

                    bw.Close();
                    fs.Close();
                    MessageBox.Show("data stored");
                    IOText.Text ="";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DataRead_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = @"E:\DemoFolder\file3.dat";
                FileStream fs = new FileStream(fileName, FileMode.Open);
                //FileStream fs = new FileStream(fileName, FileMode.Open,FileAccess.Write);//we can not read this file
                BinaryReader br = new BinaryReader(fs);
                //MessageBox.Show("data : " + br.ReadString());
                IOText.Text = br.ReadString();
                //MessageBox.Show("data : " + br.Read());//return num of chars
                br.Close();
                fs.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void EmpId_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmpName_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmpSalary_TextChanged(object sender, EventArgs e)
        {

        }
        private void SaveEmpData_Click(object sender, EventArgs e)
        {
            if (EmpId.Text != string.Empty && EmpName.Text != string.Empty && EmpSalary.Text != string.Empty)
            {
                try
                {
                    string fileName = @"E:/DemoFolder/EmpData1.dat";
                    FileStream f = new FileStream(fileName, FileMode.Create, FileAccess.Write);
                    BinaryWriter bw = new BinaryWriter(f);
                    bw.Write(Convert.ToInt32(EmpId.Text));
                    bw.Write(EmpName.Text);
                    bw.Write(Convert.ToDouble(EmpSalary.Text));
                    bw.Close();
                    f.Close();
                    MessageBox.Show("Data Saved");
                    EmpId.Clear();
                    EmpName.Clear();
                    EmpSalary.Clear();


                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
            else {
                MessageBox.Show("Enter data");
            }

        }

        

        private void ReadEmpData_Click(object sender, EventArgs e)
        {
            
                try
                {
                    string fileName = @"E:/DemoFolder/EmpData1.dat";
                    FileStream f = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(f);
                    EmpId.Text = br.ReadInt32().ToString();
                    EmpName.Text = br.ReadString();
                    EmpSalary.Text = br.ReadDouble().ToString();
                    br.Close();
                    f.Close();


                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            
            
        }

        private void ClearFields_Click(object sender, EventArgs e)
        {
            if (EmpId.Text != string.Empty && EmpName.Text != string.Empty && EmpSalary.Text != string.Empty)
            {
                EmpId.Clear();
                EmpName.Clear();
                EmpSalary.Clear();
                
            }
            else {
                MessageBox.Show("Enter data");
            }
        }
    }
}
