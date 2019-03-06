using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 进制转换
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "2进制";
            label2.Text = "8进制";
            label3.Text = "10进制";
            label4.Text = "16进制";
            button1.Text = "转换！";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double i = Convert.ToDouble(textBox1.Text);

            if (textBox1.Text != "" && textBox2.Text == "" && textBox3.Text == "" && textBox4.Text == "")
            {

                textBox3.Text = Convert.ToInt32(i, 2);
            }



        }
    }
}
