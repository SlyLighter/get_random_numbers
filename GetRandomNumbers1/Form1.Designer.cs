
namespace GetRandomNumbers1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.generateButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelMathExp = new System.Windows.Forms.Label();
            this.labelStandDeviation = new System.Windows.Forms.Label();
            this.textBoxMathExp = new System.Windows.Forms.TextBox();
            this.textBoxStandDeviation = new System.Windows.Forms.TextBox();
            this.textBoxIntensity = new System.Windows.Forms.TextBox();
            this.labelIntensity = new System.Windows.Forms.Label();
            this.textBoxLowerLimit = new System.Windows.Forms.TextBox();
            this.labelLowerLimit = new System.Windows.Forms.Label();
            this.labelUpperLimit = new System.Windows.Forms.Label();
            this.textBoxUpperLimit = new System.Windows.Forms.TextBox();
            this.textBoxMode = new System.Windows.Forms.TextBox();
            this.labelMode = new System.Windows.Forms.Label();
            this.labelForm = new System.Windows.Forms.Label();
            this.labelScale = new System.Windows.Forms.Label();
            this.textBoxForm = new System.Windows.Forms.TextBox();
            this.textBoxScale = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(9, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Количество случайных величин";
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.resetButton.Location = new System.Drawing.Point(15, 555);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(88, 36);
            this.resetButton.TabIndex = 0;
            this.resetButton.Text = "Сброс";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // generateButton
            // 
            this.generateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.generateButton.Location = new System.Drawing.Point(109, 555);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(119, 36);
            this.generateButton.TabIndex = 1;
            this.generateButton.Text = "Сгенерировать";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(9, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Закон распределения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(9, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Параметры распределения";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Пуассоновское распределение",
            "Показательное распределение",
            "Равномерное распределение",
            "Нормальное распределение",
            "Логарифмически нормальное",
            "Треугольное распределение",
            "Гамма распределение"});
            this.comboBox1.Location = new System.Drawing.Point(12, 112);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(218, 25);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBoxCount
            // 
            this.textBoxCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.textBoxCount.Location = new System.Drawing.Point(12, 49);
            this.textBoxCount.MaxLength = 4;
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(100, 23);
            this.textBoxCount.TabIndex = 6;
            this.textBoxCount.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textBoxCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // chart1
            // 
            chartArea2.AxisX.LabelStyle.Interval = 1D;
            chartArea2.AxisX.MajorGrid.Interval = 1D;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea2.AxisX.MajorTickMark.Enabled = false;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(296, 174);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(672, 417);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(323, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Частотная диаграмма";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.Location = new System.Drawing.Point(323, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(272, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Сгенерированные случайные величины";
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.textBoxOutput.Location = new System.Drawing.Point(326, 53);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ReadOnly = true;
            this.textBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutput.Size = new System.Drawing.Size(642, 80);
            this.textBoxOutput.TabIndex = 10;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(980, 27);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(74, 23);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // labelMathExp
            // 
            this.labelMathExp.AutoSize = true;
            this.labelMathExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelMathExp.Location = new System.Drawing.Point(9, 178);
            this.labelMathExp.Name = "labelMathExp";
            this.labelMathExp.Size = new System.Drawing.Size(189, 17);
            this.labelMathExp.TabIndex = 12;
            this.labelMathExp.Text = "Математическое ожидание";
            // 
            // labelStandDeviation
            // 
            this.labelStandDeviation.AutoSize = true;
            this.labelStandDeviation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelStandDeviation.Location = new System.Drawing.Point(9, 227);
            this.labelStandDeviation.Name = "labelStandDeviation";
            this.labelStandDeviation.Size = new System.Drawing.Size(232, 17);
            this.labelStandDeviation.TabIndex = 13;
            this.labelStandDeviation.Text = "Среднеквадратичное отклонение";
            // 
            // textBoxMathExp
            // 
            this.textBoxMathExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.textBoxMathExp.Location = new System.Drawing.Point(12, 198);
            this.textBoxMathExp.MaxLength = 15;
            this.textBoxMathExp.Name = "textBoxMathExp";
            this.textBoxMathExp.Size = new System.Drawing.Size(100, 23);
            this.textBoxMathExp.TabIndex = 14;
            this.textBoxMathExp.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textBoxMathExp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // textBoxStandDeviation
            // 
            this.textBoxStandDeviation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.textBoxStandDeviation.Location = new System.Drawing.Point(12, 247);
            this.textBoxStandDeviation.MaxLength = 15;
            this.textBoxStandDeviation.Name = "textBoxStandDeviation";
            this.textBoxStandDeviation.Size = new System.Drawing.Size(100, 23);
            this.textBoxStandDeviation.TabIndex = 15;
            this.textBoxStandDeviation.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textBoxStandDeviation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // textBoxIntensity
            // 
            this.textBoxIntensity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.textBoxIntensity.Location = new System.Drawing.Point(12, 198);
            this.textBoxIntensity.MaxLength = 4;
            this.textBoxIntensity.Name = "textBoxIntensity";
            this.textBoxIntensity.Size = new System.Drawing.Size(100, 23);
            this.textBoxIntensity.TabIndex = 16;
            this.textBoxIntensity.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textBoxIntensity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // labelIntensity
            // 
            this.labelIntensity.AutoSize = true;
            this.labelIntensity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelIntensity.Location = new System.Drawing.Point(9, 178);
            this.labelIntensity.Name = "labelIntensity";
            this.labelIntensity.Size = new System.Drawing.Size(108, 17);
            this.labelIntensity.TabIndex = 17;
            this.labelIntensity.Text = "Интенсивность";
            // 
            // textBoxLowerLimit
            // 
            this.textBoxLowerLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.textBoxLowerLimit.Location = new System.Drawing.Point(12, 198);
            this.textBoxLowerLimit.MaxLength = 15;
            this.textBoxLowerLimit.Name = "textBoxLowerLimit";
            this.textBoxLowerLimit.Size = new System.Drawing.Size(100, 23);
            this.textBoxLowerLimit.TabIndex = 18;
            this.textBoxLowerLimit.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textBoxLowerLimit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // labelLowerLimit
            // 
            this.labelLowerLimit.AutoSize = true;
            this.labelLowerLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelLowerLimit.Location = new System.Drawing.Point(9, 178);
            this.labelLowerLimit.Name = "labelLowerLimit";
            this.labelLowerLimit.Size = new System.Drawing.Size(116, 17);
            this.labelLowerLimit.TabIndex = 19;
            this.labelLowerLimit.Text = "Нижняя граница";
            // 
            // labelUpperLimit
            // 
            this.labelUpperLimit.AutoSize = true;
            this.labelUpperLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelUpperLimit.Location = new System.Drawing.Point(9, 227);
            this.labelUpperLimit.Name = "labelUpperLimit";
            this.labelUpperLimit.Size = new System.Drawing.Size(120, 17);
            this.labelUpperLimit.TabIndex = 20;
            this.labelUpperLimit.Text = "Верхняя граница";
            // 
            // textBoxUpperLimit
            // 
            this.textBoxUpperLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.textBoxUpperLimit.Location = new System.Drawing.Point(12, 247);
            this.textBoxUpperLimit.MaxLength = 15;
            this.textBoxUpperLimit.Name = "textBoxUpperLimit";
            this.textBoxUpperLimit.Size = new System.Drawing.Size(100, 23);
            this.textBoxUpperLimit.TabIndex = 21;
            this.textBoxUpperLimit.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textBoxUpperLimit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // textBoxMode
            // 
            this.textBoxMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.textBoxMode.Location = new System.Drawing.Point(12, 294);
            this.textBoxMode.MaxLength = 15;
            this.textBoxMode.Name = "textBoxMode";
            this.textBoxMode.Size = new System.Drawing.Size(100, 23);
            this.textBoxMode.TabIndex = 23;
            this.textBoxMode.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textBoxMode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // labelMode
            // 
            this.labelMode.AutoSize = true;
            this.labelMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelMode.Location = new System.Drawing.Point(9, 274);
            this.labelMode.Name = "labelMode";
            this.labelMode.Size = new System.Drawing.Size(43, 17);
            this.labelMode.TabIndex = 22;
            this.labelMode.Text = "Мода";
            // 
            // labelForm
            // 
            this.labelForm.AutoSize = true;
            this.labelForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelForm.Location = new System.Drawing.Point(9, 227);
            this.labelForm.Name = "labelForm";
            this.labelForm.Size = new System.Drawing.Size(54, 17);
            this.labelForm.TabIndex = 24;
            this.labelForm.Text = "Форма";
            // 
            // labelScale
            // 
            this.labelScale.AutoSize = true;
            this.labelScale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelScale.Location = new System.Drawing.Point(9, 178);
            this.labelScale.Name = "labelScale";
            this.labelScale.Size = new System.Drawing.Size(68, 17);
            this.labelScale.TabIndex = 25;
            this.labelScale.Text = "Масштаб";
            // 
            // textBoxForm
            // 
            this.textBoxForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.textBoxForm.Location = new System.Drawing.Point(12, 247);
            this.textBoxForm.MaxLength = 5;
            this.textBoxForm.Name = "textBoxForm";
            this.textBoxForm.Size = new System.Drawing.Size(100, 23);
            this.textBoxForm.TabIndex = 26;
            this.textBoxForm.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textBoxForm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // textBoxScale
            // 
            this.textBoxScale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.textBoxScale.Location = new System.Drawing.Point(12, 198);
            this.textBoxScale.MaxLength = 4;
            this.textBoxScale.Name = "textBoxScale";
            this.textBoxScale.Size = new System.Drawing.Size(100, 23);
            this.textBoxScale.TabIndex = 27;
            this.textBoxScale.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textBoxScale.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 603);
            this.Controls.Add(this.textBoxScale);
            this.Controls.Add(this.textBoxForm);
            this.Controls.Add(this.labelScale);
            this.Controls.Add(this.labelForm);
            this.Controls.Add(this.textBoxMode);
            this.Controls.Add(this.labelMode);
            this.Controls.Add(this.textBoxUpperLimit);
            this.Controls.Add(this.labelUpperLimit);
            this.Controls.Add(this.labelLowerLimit);
            this.Controls.Add(this.textBoxLowerLimit);
            this.Controls.Add(this.labelIntensity);
            this.Controls.Add(this.textBoxIntensity);
            this.Controls.Add(this.textBoxStandDeviation);
            this.Controls.Add(this.textBoxMathExp);
            this.Controls.Add(this.labelStandDeviation);
            this.Controls.Add(this.labelMathExp);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.textBoxCount);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Генерация случайных величин";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.Label labelMathExp;
        private System.Windows.Forms.Label labelStandDeviation;
        private System.Windows.Forms.TextBox textBoxMathExp;
        private System.Windows.Forms.TextBox textBoxStandDeviation;
        private System.Windows.Forms.TextBox textBoxIntensity;
        private System.Windows.Forms.Label labelIntensity;
        private System.Windows.Forms.TextBox textBoxLowerLimit;
        private System.Windows.Forms.Label labelLowerLimit;
        private System.Windows.Forms.Label labelUpperLimit;
        private System.Windows.Forms.TextBox textBoxUpperLimit;
        private System.Windows.Forms.TextBox textBoxMode;
        private System.Windows.Forms.Label labelMode;
        private System.Windows.Forms.Label labelForm;
        private System.Windows.Forms.Label labelScale;
        private System.Windows.Forms.TextBox textBoxForm;
        private System.Windows.Forms.TextBox textBoxScale;
    }
}

