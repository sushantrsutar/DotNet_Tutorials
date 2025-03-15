using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace DiconnectedDemoTQ
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlDataAdapter da;
        SqlCommandBuilder builder;
        DataSet ds;

        public Form1()
        {
            InitializeComponent();
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["defaultName"].ConnectionString);
        }
        public void ClearInput() {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
        private DataSet GetEmployees() {
            string query = "select * from employee";
            da = new SqlDataAdapter(query, conn);
            da.MissingSchemaAction=MissingSchemaAction.AddWithKey;
            builder = new SqlCommandBuilder(da);
            ds=new DataSet();
            da.Fill(ds,"EmpDataSet");
            return ds;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            try {
                ds=GetEmployees();
                //create new row to add record
                DataRow row=ds.Tables["EmpDataSet"].NewRow();
                //asign value to row
                row["eid"] = textBox1.Text;
                row["ename"] = textBox2.Text;
                row["esal"]=textBox3.Text;

                //atach the row in dataset table
                ds.Tables["EmpDataSet"].Rows.Add(row);
                //update the changes from dataset to db
                int result = da.Update(ds.Tables["EmpDataSet"]);
                if (result >= 1)
                {
                    MessageBox.Show("Data Added");
                    ClearInput();
                    
                }
                else {
                    MessageBox.Show("Data not added");
                }

            }catch (Exception Ex){
                MessageBox.Show(Ex.Message);
            }
        }

        private void Show_Click(object sender, EventArgs e)
        {

            try
            {
                ds = GetEmployees();
                dataGridView1.DataSource = ds.Tables["EmpDataSet"];
                ClearInput();

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetEmployees();
                //find the data row
                DataRow row = ds.Tables["EmpDataSet"].Rows.Find(textBox1.Text);
                if (row != null)
                {
                    //delete the current row from dataset
                    row.Delete();
                    int result = da.Update(ds.Tables["EmpDataSet"]);
                    if (result >= 0)
                    {
                        MessageBox.Show("Record deleted");
                    }
                    else {
                        MessageBox.Show("Not deleted");
                    }

                }
                else {
                    MessageBox.Show("ID not found");
                }

            }
            catch (Exception Ex) { 
                MessageBox.Show(Ex.Message);
            }

        }

        private void Update_Click(object sender, EventArgs e)
        {

            try
            {
                ds=GetEmployees();
                //find the row
                DataRow row = ds.Tables["EmpDataSet"].Rows.Find(textBox1.Text);
                if (row != null)
                {
                    row["eid"] = textBox1.Text;
                    row["ename"] = textBox2.Text;
                    row["esal"]=textBox3.Text;

                    int result = da.Update(ds.Tables["EmpDataSet"]);
                    if (result >= 1)
                    {
                           MessageBox.Show("Data updated");
                        ClearInput();
                    }
                    
                }
                else
                {
                    MessageBox.Show("Id not found");
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }

        private void Search_Click(object sender, EventArgs e)
        {

            try
            {
                ds = GetEmployees();
                //find the row
                DataRow row = ds.Tables["EmpDataSet"].Rows.Find(textBox1.Text);
                if (row != null) {
                    textBox2.Text = row["ename"].ToString();
                    textBox3.Text = row["esal"].ToString();
                }
                else
                {
                    MessageBox.Show("Employee Not Found");
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
    }
}
