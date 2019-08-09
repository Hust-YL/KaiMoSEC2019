namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.upGroupBox = new System.Windows.Forms.GroupBox();
            this.helpButton = new System.Windows.Forms.Button();
            this.SaveHistoryButton = new System.Windows.Forms.Button();
            this.showHistoryButton = new System.Windows.Forms.Button();
            this.unitLabel = new System.Windows.Forms.Label();
            this.inchRadioButton = new System.Windows.Forms.RadioButton();
            this.centimetreRadioButton = new System.Windows.Forms.RadioButton();
            this.resectButton = new System.Windows.Forms.Button();
            this.selectComboBox = new System.Windows.Forms.ComboBox();
            this.downGroupBox = new System.Windows.Forms.GroupBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.parameterLabelThree = new System.Windows.Forms.Label();
            this.parameterTextBoxThree = new System.Windows.Forms.TextBox();
            this.parameterLabelTwo = new System.Windows.Forms.Label();
            this.parameterTextBoxTwo = new System.Windows.Forms.TextBox();
            this.parameterLabelOne = new System.Windows.Forms.Label();
            this.parameterTextBoxOne = new System.Windows.Forms.TextBox();
            this.upGroupBox.SuspendLayout();
            this.downGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // upGroupBox
            // 
            this.upGroupBox.Controls.Add(this.helpButton);
            this.upGroupBox.Controls.Add(this.SaveHistoryButton);
            this.upGroupBox.Controls.Add(this.showHistoryButton);
            this.upGroupBox.Controls.Add(this.unitLabel);
            this.upGroupBox.Controls.Add(this.inchRadioButton);
            this.upGroupBox.Controls.Add(this.centimetreRadioButton);
            this.upGroupBox.Controls.Add(this.resectButton);
            this.upGroupBox.Controls.Add(this.selectComboBox);
            this.upGroupBox.Location = new System.Drawing.Point(13, 12);
            this.upGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.upGroupBox.Name = "upGroupBox";
            this.upGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.upGroupBox.Size = new System.Drawing.Size(312, 144);
            this.upGroupBox.TabIndex = 8;
            this.upGroupBox.TabStop = false;
            this.upGroupBox.Tag = "r";
            this.upGroupBox.Text = "设置";
            // 
            // helpButton
            // 
            this.helpButton.Location = new System.Drawing.Point(208, 89);
            this.helpButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(84, 35);
            this.helpButton.TabIndex = 4;
            this.helpButton.Text = "查看帮助";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // SaveHistoryButton
            // 
            this.SaveHistoryButton.Location = new System.Drawing.Point(113, 89);
            this.SaveHistoryButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SaveHistoryButton.Name = "SaveHistoryButton";
            this.SaveHistoryButton.Size = new System.Drawing.Size(84, 35);
            this.SaveHistoryButton.TabIndex = 4;
            this.SaveHistoryButton.Text = "保存记录";
            this.SaveHistoryButton.UseVisualStyleBackColor = true;
            this.SaveHistoryButton.Click += new System.EventHandler(this.SaveHistoryButton_Click);
            // 
            // showHistoryButton
            // 
            this.showHistoryButton.Location = new System.Drawing.Point(18, 89);
            this.showHistoryButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.showHistoryButton.Name = "showHistoryButton";
            this.showHistoryButton.Size = new System.Drawing.Size(84, 35);
            this.showHistoryButton.TabIndex = 4;
            this.showHistoryButton.Text = "查看记录";
            this.showHistoryButton.UseVisualStyleBackColor = true;
            this.showHistoryButton.Click += new System.EventHandler(this.ShowHistoryButton_Click);
            // 
            // unitLabel
            // 
            this.unitLabel.AutoSize = true;
            this.unitLabel.Location = new System.Drawing.Point(15, 60);
            this.unitLabel.Name = "unitLabel";
            this.unitLabel.Size = new System.Drawing.Size(112, 15);
            this.unitLabel.TabIndex = 3;
            this.unitLabel.Text = "输入参数单位：";
            // 
            // inchRadioButton
            // 
            this.inchRadioButton.AutoSize = true;
            this.inchRadioButton.Location = new System.Drawing.Point(206, 58);
            this.inchRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inchRadioButton.Name = "inchRadioButton";
            this.inchRadioButton.Size = new System.Drawing.Size(58, 19);
            this.inchRadioButton.TabIndex = 2;
            this.inchRadioButton.TabStop = true;
            this.inchRadioButton.Text = "英寸";
            this.inchRadioButton.UseVisualStyleBackColor = true;
            // 
            // centimetreRadioButton
            // 
            this.centimetreRadioButton.AutoSize = true;
            this.centimetreRadioButton.Location = new System.Drawing.Point(140, 58);
            this.centimetreRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.centimetreRadioButton.Name = "centimetreRadioButton";
            this.centimetreRadioButton.Size = new System.Drawing.Size(58, 19);
            this.centimetreRadioButton.TabIndex = 2;
            this.centimetreRadioButton.Text = "厘米";
            this.centimetreRadioButton.UseVisualStyleBackColor = true;
            // 
            // resectButton
            // 
            this.resectButton.Location = new System.Drawing.Point(231, 25);
            this.resectButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resectButton.Name = "resectButton";
            this.resectButton.Size = new System.Drawing.Size(61, 25);
            this.resectButton.TabIndex = 1;
            this.resectButton.Text = "重置";
            this.resectButton.UseVisualStyleBackColor = true;
            this.resectButton.Click += new System.EventHandler(this.ResectButton_Click);
            // 
            // selectComboBox
            // 
            this.selectComboBox.Font = new System.Drawing.Font("宋体", 10F);
            this.selectComboBox.FormattingEnabled = true;
            this.selectComboBox.Items.AddRange(new object[] {
            "正方形",
            "长方形",
            "平行四边形",
            "梯形",
            "三角形（三边）",
            "三角形（底和高）",
            "圆形",
            "扇形",
            "圆环"});
            this.selectComboBox.Location = new System.Drawing.Point(18, 25);
            this.selectComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.selectComboBox.Name = "selectComboBox";
            this.selectComboBox.Size = new System.Drawing.Size(196, 25);
            this.selectComboBox.TabIndex = 0;
            this.selectComboBox.SelectedValueChanged += new System.EventHandler(this.SelectComboBox_SelectedValueChanged);
            // 
            // downGroupBox
            // 
            this.downGroupBox.Controls.Add(this.calculateButton);
            this.downGroupBox.Controls.Add(this.resultTextBox);
            this.downGroupBox.Controls.Add(this.parameterLabelThree);
            this.downGroupBox.Controls.Add(this.parameterTextBoxThree);
            this.downGroupBox.Controls.Add(this.parameterLabelTwo);
            this.downGroupBox.Controls.Add(this.parameterTextBoxTwo);
            this.downGroupBox.Controls.Add(this.parameterLabelOne);
            this.downGroupBox.Controls.Add(this.parameterTextBoxOne);
            this.downGroupBox.Location = new System.Drawing.Point(13, 172);
            this.downGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.downGroupBox.Name = "downGroupBox";
            this.downGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.downGroupBox.Size = new System.Drawing.Size(312, 291);
            this.downGroupBox.TabIndex = 9;
            this.downGroupBox.TabStop = false;
            this.downGroupBox.Text = "计算";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(18, 237);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(275, 35);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "计算";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // resultTextBox
            // 
            this.resultTextBox.Font = new System.Drawing.Font("宋体", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.resultTextBox.Location = new System.Drawing.Point(18, 23);
            this.resultTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(275, 57);
            this.resultTextBox.TabIndex = 2;
            this.resultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // parameterLabelThree
            // 
            this.parameterLabelThree.AutoSize = true;
            this.parameterLabelThree.Location = new System.Drawing.Point(15, 156);
            this.parameterLabelThree.Name = "parameterLabelThree";
            this.parameterLabelThree.Size = new System.Drawing.Size(47, 15);
            this.parameterLabelThree.TabIndex = 1;
            this.parameterLabelThree.Text = "label";
            // 
            // parameterTextBoxThree
            // 
            this.parameterTextBoxThree.Location = new System.Drawing.Point(76, 153);
            this.parameterTextBoxThree.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.parameterTextBoxThree.Name = "parameterTextBoxThree";
            this.parameterTextBoxThree.Size = new System.Drawing.Size(217, 25);
            this.parameterTextBoxThree.TabIndex = 0;
            // 
            // parameterLabelTwo
            // 
            this.parameterLabelTwo.AutoSize = true;
            this.parameterLabelTwo.Location = new System.Drawing.Point(15, 127);
            this.parameterLabelTwo.Name = "parameterLabelTwo";
            this.parameterLabelTwo.Size = new System.Drawing.Size(47, 15);
            this.parameterLabelTwo.TabIndex = 1;
            this.parameterLabelTwo.Text = "label";
            // 
            // parameterTextBoxTwo
            // 
            this.parameterTextBoxTwo.Location = new System.Drawing.Point(76, 124);
            this.parameterTextBoxTwo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.parameterTextBoxTwo.Name = "parameterTextBoxTwo";
            this.parameterTextBoxTwo.Size = new System.Drawing.Size(217, 25);
            this.parameterTextBoxTwo.TabIndex = 0;
            // 
            // parameterLabelOne
            // 
            this.parameterLabelOne.AutoSize = true;
            this.parameterLabelOne.Location = new System.Drawing.Point(15, 97);
            this.parameterLabelOne.Name = "parameterLabelOne";
            this.parameterLabelOne.Size = new System.Drawing.Size(47, 15);
            this.parameterLabelOne.TabIndex = 1;
            this.parameterLabelOne.Text = "label";
            // 
            // parameterTextBoxOne
            // 
            this.parameterTextBoxOne.Location = new System.Drawing.Point(76, 95);
            this.parameterTextBoxOne.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.parameterTextBoxOne.Name = "parameterTextBoxOne";
            this.parameterTextBoxOne.Size = new System.Drawing.Size(217, 25);
            this.parameterTextBoxOne.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 500);
            this.Controls.Add(this.downGroupBox);
            this.Controls.Add(this.upGroupBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(358, 547);
            this.MinimumSize = new System.Drawing.Size(358, 547);
            this.Name = "Form1";
            this.Text = "通用面积计算器";
            this.upGroupBox.ResumeLayout(false);
            this.upGroupBox.PerformLayout();
            this.downGroupBox.ResumeLayout(false);
            this.downGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox upGroupBox;
        private System.Windows.Forms.Button resectButton;
        private System.Windows.Forms.ComboBox selectComboBox;
        private System.Windows.Forms.Label unitLabel;
        private System.Windows.Forms.RadioButton inchRadioButton;
        private System.Windows.Forms.RadioButton centimetreRadioButton;
        private System.Windows.Forms.GroupBox downGroupBox;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Button SaveHistoryButton;
        private System.Windows.Forms.Button showHistoryButton;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Label parameterLabelThree;
        private System.Windows.Forms.TextBox parameterTextBoxThree;
        private System.Windows.Forms.Label parameterLabelTwo;
        private System.Windows.Forms.TextBox parameterTextBoxTwo;
        private System.Windows.Forms.Label parameterLabelOne;
        private System.Windows.Forms.TextBox parameterTextBoxOne;
        private System.Windows.Forms.Button calculateButton;
    }
}

