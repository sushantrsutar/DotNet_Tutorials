using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDemoTQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string name;

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox1.Text);
            
            //textBox1.Text = "hi i am textbox;
        }

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        
    }
}
