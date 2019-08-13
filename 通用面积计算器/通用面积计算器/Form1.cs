using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Reset();
        }

        public Exception parameter_error;

        private void Reset()
        {
            this.parameterLabelOne.Visible = false;
            this.parameterLabelTwo.Visible = false;
            this.parameterLabelThree.Visible = false;
            this.parameterTextBoxOne.Visible = false;
            this.parameterTextBoxTwo.Visible = false;
            this.parameterTextBoxThree.Visible = false;
            this.parameterTextBoxOne.Clear();
            this.parameterTextBoxTwo.Clear();
            this.parameterTextBoxThree.Clear();
            this.centimetreRadioButton.Checked = true;
            this.selectComboBox.Text = "<请选择一种图形>";
        }

        private void ResectButton_Click(object sender, EventArgs e)
        {
            Reset();
            this.centimetreRadioButton.Checked = false;
            this.inchRadioButton.Checked = false;
            this.resultTextBox.Clear();
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

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                CheckParameter();
                switch (selectComboBox.SelectedItem)
                {
                    case "正方形":
                        double square_parameter = NeedTransform(this.parameterTextBoxOne.Text);
                        double squareArea = AreaCalculate.Square(square_parameter);
                        this.resultTextBox.Text = squareArea.ToString();
                        break;
                    case "长方形":
                        double rectangle_parameterone = NeedTransform(this.parameterTextBoxOne.Text);
                        double rectangle_parametertwo = NeedTransform(this.parameterTextBoxTwo.Text);
                        double rectangleArea = AreaCalculate.Rectangle(rectangle_parameterone, rectangle_parametertwo);
                        this.resultTextBox.Text = rectangleArea.ToString();
                        break;
                    case "圆形":
                        double circle_parameterone = NeedTransform(this.parameterTextBoxOne.Text);
                        double circleArea = AreaCalculate.Circle(circle_parameterone);
                        this.resultTextBox.Text = circleArea.ToString();
                        SelectCircle();
                        break;
                    case "圆环":
                        double torus_parameterone = NeedTransform(this.parameterTextBoxOne.Text);
                        double torus_parametertwo = NeedTransform(this.parameterTextBoxTwo.Text);
                        double torusArea = AreaCalculate.Torus(torus_parameterone, torus_parametertwo);
                        this.resultTextBox.Text = torusArea.ToString();
                        break;
                    case "梯形":
                        double trapezoid_parameterone = NeedTransform(this.parameterTextBoxOne.Text);
                        double trapezoid_parametertwo = NeedTransform(this.parameterTextBoxTwo.Text);
                        double trapezoid_parameterthree = NeedTransform(this.parameterTextBoxThree.Text);
                        double trapezoidArea = AreaCalculate.Trapezoid(trapezoid_parameterone, trapezoid_parametertwo, trapezoid_parameterthree);
                        this.resultTextBox.Text = trapezoidArea.ToString();
                        break;
                    case "扇形":
                        double sector_parameterone = NeedTransform(this.parameterTextBoxOne.Text);
                        double sector_parametertwo = NeedTransform(this.parameterTextBoxTwo.Text);
                        double sectorArea = AreaCalculate.Sector(sector_parameterone, sector_parametertwo);
                        this.resultTextBox.Text = sectorArea.ToString();
                        break;
                    case "平行四边形":
                        double parallelogram_parameterone = NeedTransform(this.parameterTextBoxOne.Text);
                        double parallelogram_parametertwo = NeedTransform(this.parameterTextBoxTwo.Text);
                        double parallelogramArea = AreaCalculate.Rectangle(parallelogram_parameterone, parallelogram_parametertwo);
                        this.resultTextBox.Text = parallelogramArea.ToString();
                        break;
                    case "三角形（三边）":
                        double A_parameterone = NeedTransform(this.parameterTextBoxOne.Text);
                        double A_parametertwo = NeedTransform(this.parameterTextBoxTwo.Text);
                        double A_parameterthree = NeedTransform(this.parameterTextBoxThree.Text);
                        double AArea = AreaCalculate.TriangleThree(A_parameterone, A_parametertwo, A_parameterthree);
                        this.resultTextBox.Text = AArea.ToString();
                        break;
                    case "三角形（底和高）":
                        double B_parameterone = NeedTransform(this.parameterTextBoxOne.Text);
                        double B_parametertwo = NeedTransform(this.parameterTextBoxTwo.Text);
                        double BArea = AreaCalculate.TriangleTwo(B_parameterone, B_parametertwo);
                        this.resultTextBox.Text = BArea.ToString();
                        break;
                }
                this.resultTextBox.Text += "cm²";
            }
            catch 
            {
                MessageBox.Show("参数错误!");
            }
        }

        private double NeedTransform(string text)
        {
            if(this.centimetreRadioButton.Checked&&!this.inchRadioButton.Checked)
            {
                double parameter = double.Parse(text);
                return parameter;
            }
            else
            {
                double parameter = double.Parse(text);
                parameter = InchToCentimetre.Transform(parameter);
                return parameter;
            }
        }

        private void CheckParameter()
        {
            if (double.Parse(this.parameterTextBoxOne.Text) < 0)
            {
                throw parameter_error;
            }
            if (this.parameterLabelTwo.Visible && double.Parse(this.parameterTextBoxTwo.Text) < 0)
            {
                throw parameter_error;
            }
            if (this.parameterLabelThree.Visible && double.Parse(this.parameterTextBoxThree.Text) < 0)
            {
                throw parameter_error;
            }
            switch (selectComboBox.SelectedItem)
            {
                case "梯形":
                    if (double.Parse(this.parameterTextBoxOne.Text) == 0 || double.Parse(this.parameterTextBoxTwo.Text) == 0 || double.Parse(this.parameterTextBoxThree.Text) == 0)
                    {
                        throw parameter_error;
                    }
                    break;
                case "圆环":
                    double torus_parameterone = double.Parse(this.parameterTextBoxOne.Text);
                    double torus_parametertwo = double.Parse(this.parameterTextBoxTwo.Text);
                    if(torus_parameterone<=torus_parametertwo)
                    {
                        throw parameter_error;
                    }
                    break;
                case "三角形（三边）":
                    double triangle_parameterone = double.Parse(this.parameterTextBoxOne.Text);
                    double triangle_parametertwo = double.Parse(this.parameterTextBoxTwo.Text);
                    double triangle_parameterthree = double.Parse(this.parameterTextBoxThree.Text);
                    if (triangle_parameterone+triangle_parametertwo<=triangle_parameterthree)
                    {
                        throw parameter_error;
                    }
                    if (triangle_parameterthree + triangle_parametertwo <= triangle_parameterone)
                    {
                        throw parameter_error;
                    }
                    if (triangle_parameterone + triangle_parameterthree <= triangle_parametertwo)
                    {
                        throw parameter_error;
                    }
                    break;
                case "扇形":
                    double sector_parametertwo = double.Parse(this.parameterTextBoxTwo.Text);
                    if(sector_parametertwo>=360)
                    {
                        throw parameter_error;
                    }
                    break;
            }
        }

        private void SaveHistoryButton_Click(object sender, EventArgs e)
        {
            string addition = this.selectComboBox.Text + " ";
            addition += this.parameterLabelOne.Text + " " + this.parameterTextBoxOne.Text + " ";
            if(this.parameterLabelTwo.Visible)
            {
                addition += this.parameterLabelTwo.Text + " " + this.parameterTextBoxTwo.Text + " ";
            }
            if (this.parameterLabelThree.Visible)
            {
                addition += this.parameterLabelThree.Text + " " + this.parameterTextBoxThree.Text + " ";
            }
            addition += "面积 " + this.resultTextBox.Text;
            string[] line = { addition };
            File.AppendAllLines("HistoryFile.txt", line);
        }

        private void ShowHistoryButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("HistoryFile.txt");
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("HelpFile.txt");
        }

    }
}
