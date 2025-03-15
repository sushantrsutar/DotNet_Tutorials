using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADOPractice
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader rdr;
        String sql;
        public Form1()
        {
            InitializeComponent();
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["defaultName"].ConnectionString);
        }

        public void clear() { 
            Id.Clear();
            Name.Clear();
            Gender.Clear();
            Age.Clear();
        }
       

        private void ShowEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "select * from Employees";
                cmd = new SqlCommand(sql, conn);
                conn.Open();
                rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rdr);
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

        private void Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "insert into Employees values(@Id,@Name,@Gender,@Age)";
                cmd=new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("Id", Id.Text);
                cmd.Parameters.AddWithValue("Name", Name.Text);
                cmd.Parameters.AddWithValue("Gender", Gender.Text);
                cmd.Parameters.AddWithValue("Age", Age.Text);
                conn.Open();
                int result=cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Data Added");
                    clear();
                }
                else {
                    MessageBox.Show("Not Added");
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            finally { 
                conn.Close( );
            }
        }
    }
}
