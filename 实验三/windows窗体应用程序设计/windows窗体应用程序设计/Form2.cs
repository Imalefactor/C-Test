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
    public partial class Form2 : Form
    {
        

        public Form2()
        {
            InitializeComponent();
            this.Text ="欢迎"+Form1.user;
            label1.Text = "请输入一个整数";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            TableButton();
            FlowButton();

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("是否关闭窗体", "提示",
         MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK) //使用if语句判定是否单击“是”按钮
            {
                e.Cancel = false;   //如果单击“是”按钮则关闭窗体
            }
            else
            {
                e.Cancel = true;  //否则，不执行操作
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void FlowButton()
        {
            for (int i = 1; i <= 16; i++)
            {
                Button bt = new Button();
                bt.Text = i.ToString();
                bt.BackColor = Color.Blue;
                flowLayoutPanel1.Controls.Add(bt);
            }
        }
        private void TableButton()
        {
            int row = 4, col = 4;
            TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
            tableLayoutPanel.Dock = DockStyle.Fill;
            panel1.Controls.Add(tableLayoutPanel);
            tableLayoutPanel.RowCount = row;    //设置成几行 
            for (int i = 0; i < row; i++)
            {
                tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            }
            tableLayoutPanel.ColumnCount = col;    //设成几列
            for (int i = 0; i < col; i++)
            {
                tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            }
            Button bt;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    bt = new Button();
                    bt.BackColor = Color.Blue;
                    bt.Dock = DockStyle.Fill;
                    bt.Text = (i * col + j + 1).ToString();
                    bt.Font = new Font("隶书", 16, FontStyle.Bold);
                    tableLayoutPanel.Controls.Add(bt);
                }
            }
        }
    }
}
