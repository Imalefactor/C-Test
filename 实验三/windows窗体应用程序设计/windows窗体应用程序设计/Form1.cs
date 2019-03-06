using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windows窗体应用程序设计
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "昵称";
            button1.Text = "登陆";
            this.Text = "用户登陆";
            
    }
        public static string user;


        private void button1_Click(object sender, EventArgs e)
        {
            user = textBox1.Text;
            new Form2().Show();
            this.Hide();
        }
    }
}
