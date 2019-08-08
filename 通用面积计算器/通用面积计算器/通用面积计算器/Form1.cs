using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 通用面积计算器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem)
            {
            
                case "正方形":
                    this.label4.Visible = true;
                    this.label5.Visible = false;
                    this.label6.Visible = false;
                    this.label7.Visible = false;
                    this.label8.Visible = false;
                    this.label9.Visible = false;
                    this.textBox1.Visible = true;
                    this.textBox2.Visible = false;
                    break;
               case "长方形":
                    this.label4.Visible = false;
                    this.label5.Visible = true;
                    this.label6.Visible = true;
                    this.label7.Visible = false;
                    this.label8.Visible = false;
                    this.label9.Visible = false;
                    this.textBox1.Visible = true;
                    this.textBox2.Visible = true;
                    break;
                case "圆形":
                    this.label4.Visible = false;
                    this.label5.Visible = false;
                    this.label6.Visible = false;
                    this.label7.Visible = false;
                    this.label8.Visible = false;
                    this.label9.Visible = true;
                    this.textBox1.Visible = true;
                    this.textBox2.Visible = false;
                    break;
                case "三角形":
                    this.label4.Visible = false;
                    this.label5.Visible = false;
                    this.label6.Visible = false;
                    this.label7.Visible = true;
                    this.label8.Visible = true;
                    this.label9.Visible = false;
                    this.textBox1.Visible = true;
                    this.textBox2.Visible = true;
                    break;
                case "无":
                    this.label4.Visible = false;
                    this.label5.Visible = false;
                    this.label6.Visible = false;
                    this.label7.Visible = false;
                    this.label8.Visible = false;
                    this.label9.Visible = false;
                    this.textBox1.Visible = false;
                    this.textBox2.Visible = false;
                    break;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = "无";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "无")
                MessageBox.Show("请选择一种图形");
        }
    }
}
