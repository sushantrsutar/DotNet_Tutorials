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

namespace ConnectedDemo
{
    public partial class Form1 : Form
    {
         SqlConnection conn;
         SqlCommand cmd;
         SqlDataReader reader;
         string sql;

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
        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "insert into employee values (@eid,@ename,@esal)";
          
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", textBox1.Text);
                cmd.Parameters.AddWithValue("@name", textBox2.Text);
                cmd.Parameters.AddWithValue("@salary", textBox3.Text);
               

                conn.Open();
                int result = cmd.ExecuteNonQuery();
                ClearInput();
                if (result > 0)
                {
                    MessageBox.Show("Employee Added");
                   
                }
                else
                {
                    MessageBox.Show("Not Added");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { 
                conn.Close();
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "select * from employee where eid=@eid";
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@eid", textBox1.Text);
                conn.Open();
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        textBox2.Text = reader["ename"].ToString();
                        textBox3.Text = reader["esal"].ToString();
                    }
                }
                else {
                    MessageBox.Show("Record Not Found for this Id");
                    ClearInput();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { 
                conn.Close();
                
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "update employee set ename=@ename ,esal=@esal where eid=@eid";
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@eid", textBox1.Text);
                cmd.Parameters.AddWithValue("@ename", textBox2.Text);
                cmd.Parameters.AddWithValue("@esal", textBox3.Text);
                conn.Open();

                int result = cmd.ExecuteNonQuery();
                ClearInput();
                if (result >= 1)
                {
                    MessageBox.Show("Record updated");
                }
                else
                {
                    MessageBox.Show("Record Not updated check Id");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { 
            conn.Close() ;
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "delete from employee where eid=@eid";
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@eid",textBox1.Text);
                conn.Open();
                int result=cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Employee Deleted");
                }
                else {
                    MessageBox.Show("Employee Not Deleted or Id not found");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally {
                conn.Close();
            }
        }

        private void Show_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "select * from employee";
               
                cmd = new SqlCommand(sql, conn);
                conn.Open();
                reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
            finally { 
                conn.Close();
                ClearInput();
                
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchByName_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "select * from employee where ename=@ename";
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ename", textBox2.Text);
                conn.Open(); 
                reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView1.DataSource = dt;
                

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            finally {
                conn.Close();
            }
        }
    }
}
