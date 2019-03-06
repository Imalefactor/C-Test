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
            label1.Text = "今天是星期";
            button1.Text = "查看";
        }
        public enum enumweek
            {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
            }
        private void button1_Click(object sender, EventArgs e)

        {
            
            int i;
            i = Convert.ToInt32(textBox1.Text);
            switch(i)
            {
                case (int)enumweek.Sunday:
                    MessageBox.Show("泽泽的生日");
                    break;
                case (int)enumweek.Monday:
                    MessageBox.Show("上班第一天");
                    break;
                case (int)enumweek.Wednesday:
                    MessageBox.Show("见客户");
                    break;
                case (int)enumweek.Friday:
                    MessageBox.Show("去公园");
                   break;
                    default:
                    MessageBox.Show("今日无日程");
                    break;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
