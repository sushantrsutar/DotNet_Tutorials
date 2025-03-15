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

namespace TaskConnectedArchitecture
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {

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
            finally
            {
                conn.Close();
                ClearInput();

            }

        }
    }
}
