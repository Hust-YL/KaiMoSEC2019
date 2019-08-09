using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Reset();
        }

        private void Reset()
        {
            this.parameterLabelOne.Visible = false;
            this.parameterLabelTwo.Visible = false;
            this.parameterLabelThree.Visible = false;
            this.parameterTextBoxOne.Visible = false;
            this.parameterTextBoxTwo.Visible = false;
            this.parameterTextBoxThree.Visible = false;
            this.selectComboBox.Text = "<请选择一种图形>";
        }

        private void ResectButton_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void SelectComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            Reset();
            switch(selectComboBox.SelectedItem)
            {
                case "正方形":
                    SelectSquare();
                    break;
                case "长方形":
                    SelectRectangle();
                    break;
                case "圆形":
                    SelectCircle();
                    break;
                case "圆环":
                    SelectTorus();
                    break;
                case "梯形":
                    SelectTrapezoid();
                    break;
                case "扇形":
                    SelectSector();
                    break;
                case "平行四边形":
                    SelectParallelogram();
                    break;
                case "三角形（三边）":
                    SelectTriangle_A();
                    break;
                case "三角形（底和高）":
                    SelectTriangle_B();
                    break;
            }
        }
        private void SelectSquare()
        {
            OneParameter();
            this.parameterLabelOne.Text = "边长";
        }
        private void SelectRectangle()
        {
            TwoParameter();
            this.parameterLabelOne.Text = "长";
            this.parameterLabelTwo.Text = "宽";
        }
        private void SelectCircle()
        {
            OneParameter();
            this.parameterLabelOne.Text = "半径";
        }
        private void SelectTorus()
        {
            TwoParameter();
            this.parameterLabelOne.Text = "外径";
            this.parameterLabelTwo.Text = "内径";
        }
        private void SelectTrapezoid()
        {
            ThreeParameter();
            this.parameterLabelOne.Text = "上底";
            this.parameterLabelTwo.Text = "下底";
            this.parameterLabelThree.Text = "高";
        }
        private void SelectSector()
        {
            TwoParameter();
            this.parameterLabelOne.Text = "半径";
            this.parameterLabelTwo.Text = "角度";
        }
        private void SelectParallelogram()
        {
            TwoParameter();
            this.parameterLabelOne.Text = "底";
            this.parameterLabelTwo.Text = "高";
        }
        private void SelectTriangle_A()
        {
            ThreeParameter();
            this.parameterLabelOne.Text = "边一";
            this.parameterLabelTwo.Text = "边二";
            this.parameterLabelThree.Text = "边三";
        }
        private void SelectTriangle_B()
        {
            TwoParameter();
            this.parameterLabelOne.Text = "底";
            this.parameterLabelTwo.Text = "高";
        }
        private void OneParameter()
        {
            this.parameterLabelOne.Visible = true;
            this.parameterTextBoxOne.Visible = true;
        }
        private void TwoParameter()
        {
            this.parameterLabelOne.Visible = true;
            this.parameterTextBoxOne.Visible = true;
            this.parameterLabelTwo.Visible = true;
            this.parameterTextBoxTwo.Visible = true;
            this.parameterLabelTwo.Visible = true;
            this.parameterTextBoxTwo.Visible = true;
        }
        private void ThreeParameter()
        {
            this.parameterLabelOne.Visible = true;
            this.parameterTextBoxOne.Visible = true;
            this.parameterLabelTwo.Visible = true;
            this.parameterTextBoxTwo.Visible = true;
            this.parameterLabelTwo.Visible = true;
            this.parameterTextBoxTwo.Visible = true;
            this.parameterLabelThree.Visible = true;
            this.parameterTextBoxThree.Visible = true;
        }
    }
}
