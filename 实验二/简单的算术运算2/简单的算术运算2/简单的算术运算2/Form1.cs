using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 简单的算术运算2
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
            label1.Text = "操作数1：";
            label2.Text = "操作数2：";
            label3.Text = "计算结果：";
            button1.Text = "计算";
            button2.Text = "清除";
            radioButton1.Text = "+";
            radioButton2.Text = "-";
            radioButton3.Text = "*";
            radioButton4.Text = "/";

        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {
                MessageBox.Show("操作数1不能为空！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("操作数2不能为空！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            double i = Convert.ToDouble(textBox1.Text);
            double j = Convert.ToDouble(textBox2.Text);
            double result = 0.0;

            if (radioButton1.Checked == true)
            {
                result = i + j;
            }
            if (radioButton2.Checked == true)
            {
                result = i - j;
            }
            if (radioButton3.Checked == true)
            {
                result = i * j;
            }
            if (radioButton4.Checked == true)
            {
                if (0 == j)
                    MessageBox.Show("除数不能为0！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    result = i / j;
            }
            textBox3.Text = Convert.ToString(result);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Click += new System.EventHandler(this.button1_Click);
            button2.Click += new System.EventHandler(this.button2_Click);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Controls.OfType<TextBox>().ToList().ForEach(t => t.Clear());
        }
    }
}
