using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorTQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double num1;
        double num2;
        double result;

        public double GetNum1()
        {
            return Convert.ToDouble(textBox1.Text);
        }
        public double GetNum2()
        {
            return Convert.ToDouble(textBox2.Text);
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
                result = GetNum1() + GetNum2();
                //label1.Text = "Result = " + result.ToString();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
              //double num1=Convert.ToDouble(textBox1.Text);
              //double num2= Convert.ToDouble(textBox1.Text);
              //double result = 0;
           
                //if (radioButton1.Checked)
                //{
                //    result = num1 + num2;
                    
                //}
                //else if (radioButton2.Checked)
                //{
                //    result = num1 - num2;
                //}
                //else if (radioButton3.Checked)
                //{
                //    result = num1 * num2;
                //}
                //else if (radioButton4.Checked)
                //{
                //    if (num2 != 0)
                //    {
                //        result = num1 / num2;
                //    }
                //    else
                //    {
                //        label1.Text = "Cannot devide by 0";
                //        return;
                //    }
                //}
                //else
                //{
                //    label1.Text = "Select Any Opration";
                //    return;
                //}

            label1.Text = "Result = " + result.ToString();
            
                
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            result = GetNum1() - GetNum2();
            //label1.Text = "Result = " + result.ToString();

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            result = GetNum1() * GetNum2();
            //label1.Text = "Result = " + result.ToString();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            result = GetNum1() / GetNum2();
            //label1.Text = "Result = " + result.ToString();
        }
    }
}
