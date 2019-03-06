using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Text = "确定";
            label1.Text = "请输入一个10以内的数字：";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;
            
            i = Convert.ToInt32(textBox1.Text);
            if (i > 6)
            {
                MessageBox.Show("当前的数字太大！");

            }
            else if (i == 6)
            {
                MessageBox.Show("恭喜你猜对了！");

            }
            else if (i < 6)
            {
                MessageBox.Show("当前的数字太小！");
            }
            else
            {
                MessageBox.Show("输入错误！");

            }
        }
    }
}
