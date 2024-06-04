using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton1.Checked == true)
            {
                checkBox1.Visible = true;
                checkBox2.Visible = true;
                checkBox3.Visible = true;
                checkBox4.Visible = true;
            }
            else
            {
                checkBox1.Visible = false;
                checkBox2.Visible = false;
                checkBox3.Visible = false;
                checkBox4.Visible = false;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                checkBox6.Visible = true;
                checkBox5.Visible = true;
                checkBox8.Visible = true;

            }
            else
            {
                checkBox6.Visible = false;
                checkBox5.Visible = false;
                checkBox8.Visible = false;
            }
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                checkBox10.Visible = true;
                checkBox9.Visible = true;
                checkBox7.Visible = true;
            }
            else
            {
                checkBox10.Visible = false;
                checkBox9.Visible = false;
                checkBox7.Visible = false;
            }
           
        }
    }
}
