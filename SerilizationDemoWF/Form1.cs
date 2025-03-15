using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace SerilizationDemoWF
{
    public partial class EId : Form
    {
        public EId()
        {
            InitializeComponent();
        }

        private void ESalary_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void EId_Load(object sender, EventArgs e)
        {

        }
        //binary serialization
        private void Serilization_Click(object sender, EventArgs e)
        {
            try
            {
                Employee employee = new Employee();
                employee.Eid = Convert.ToInt32(textBox1.Text);
                employee.EName = textBox2.Text;
                employee.ESalary = Convert.ToDouble(textBox3.Text);

                FileStream fs = new FileStream(@"E:\DemoFolder\emp.dat", FileMode.Create, FileAccess.Write);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, employee);
                fs.Close();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                MessageBox.Show("Done");
            }
            catch (Exception ex) { 
                MessageBox.Show(ex.Message);
            }
        }

        
        //binary Deserialization
        private void Deserialization_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"E:\DemoFolder\emp.dat", FileMode.Open, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();
                Employee employee=new Employee();
                employee=(Employee)bf.Deserialize(fs);
                textBox1.Text=employee.Eid.ToString();
                textBox2.Text=employee.EName;
                textBox3.Text=employee.ESalary.ToString();
                fs.Close();
            }
            catch (Exception Ex) {
                MessageBox.Show(Ex.Message);
            }
        }

        //XmlSerialization
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Employee employee = new Employee();
                employee.Eid=Convert.ToInt32(textBox1.Text);
                employee.EName=textBox2.Text;
                employee.ESalary=Convert.ToDouble(textBox3.Text);

                FileStream fs = new FileStream(@"E:\DemoFolder\emp.xml", FileMode.Create, FileAccess.Write);
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Employee));
                xmlSerializer.Serialize(fs, employee);
                fs.Close();

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                MessageBox.Show("done");
            }
            catch (Exception Ex) {
                MessageBox.Show(Ex.Message);
            }
        }

        //XmlDeSerialization
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"E:\DemoFolder\emp.xml", FileMode.Open, FileAccess.Read);
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Employee));
                Employee employee = new Employee(); 
                employee=(Employee)xmlSerializer.Deserialize(fs);
                textBox1.Text=employee.Eid.ToString();
                textBox2.Text = employee.EName;
                textBox3.Text=employee.ESalary.ToString();
                fs.Close();
            }
            catch (Exception Ex) {
                MessageBox.Show(Ex.Message);
            }
        }

        //SoapSerialization
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Employee employee = new Employee();
                employee.Eid = Convert.ToInt32(textBox1.Text);
                employee.EName = textBox2.Text;
                employee.ESalary = Convert.ToInt32(textBox3.Text);

                FileStream fs = new FileStream(@"E:\DemoFolder\empSoap.soap", FileMode.Create, FileAccess.Write);
                SoapFormatter soapFormatter = new SoapFormatter();
                soapFormatter.Serialize(fs, employee);
                fs.Close();

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                MessageBox.Show("done");
            }
            catch (Exception Ex) {
                MessageBox.Show(Ex.Message);
            }
        }


        //SoapDeSerialization
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"E:\DemoFolder\empSoap.soap", FileMode.Open, FileAccess.Read);
                SoapFormatter soapFormatter = new SoapFormatter();
                Employee employee = (Employee)soapFormatter.Deserialize(fs);

                textBox1.Text = employee.Eid.ToString();
                textBox2.Text = employee.EName;
                textBox3.Text = employee.ESalary.ToString();

                fs.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

       
        //JsonSerialization
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                Employee employee=new Employee();
                employee.Eid=Convert.ToInt32(textBox1.Text);
                employee.EName=textBox2.Text;
                employee.ESalary=Convert.ToDouble(textBox3.Text);

                FileStream fs = new FileStream(@"E:\DemoFolder\empJson.json", FileMode.Create, FileAccess.Write);
                JsonSerializer.Serialize<Employee>(fs, employee);
                fs.Close() ;
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                MessageBox.Show("done");
            }
            catch (Exception Ex) {
                MessageBox.Show(Ex.Message);
            }
        }

        //JsonDeSerialization
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"E:\DemoFolder\empJson.json", FileMode.Open, FileAccess.Read);

                Employee employee = JsonSerializer.Deserialize<Employee>(fs);

                textBox1.Text = employee.Eid.ToString();
                textBox2.Text = employee.EName;
                textBox3.Text = employee.ESalary.ToString();

                fs.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
    }
    
}
