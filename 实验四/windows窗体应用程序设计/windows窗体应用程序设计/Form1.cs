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
            
    }
        public static string user;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:\\Users\\IMalefactor\\Desktop\\实验\\实验四\\windows窗体应用程序设计\\images\\login.jpg");
            user = textBox1.Text;
            new Form2().Show();
            this.Hide();
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:\\Users\\IMalefactor\\Desktop\\实验\\实验四\\windows窗体应用程序设计\\images\\login.jpg");
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:\\Users\\IMalefactor\\Desktop\\实验\\实验四\\windows窗体应用程序设计\\images\\loginmove.jpg");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile("C:\\Users\\IMalefactor\\Desktop\\实验\\实验四\\windows窗体应用程序设计\\images\\close.jpg");
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile("C:\\Users\\IMalefactor\\Desktop\\实验\\实验四\\windows窗体应用程序设计\\images\\close.jpg");
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile("C:\\Users\\IMalefactor\\Desktop\\实验\\实验四\\windows窗体应用程序设计\\images\\closemove.jpg");
        }
    }
}
