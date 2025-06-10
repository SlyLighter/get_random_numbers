using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting; // для CustomLabel

namespace GetRandomNumbers1
{
    public partial class Form1 : Form
    {
        private static Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hideElements();
            comboBox1.SelectedIndex = -1;
            chart1.Series.Clear();

            // выключение кнопки Сгенерировать при запуске (пока не выбран закон распределения)
            generateButton.Enabled = false;

            textBoxLowerLimit.Tag = "allowMinus";
            textBoxUpperLimit.Tag = "allowMinus";
            textBoxMathExp.Tag = "allowMinus";
            textBoxForm.Tag = "onlyIntPositive";
        }

        // обработчик нажатия на объект Справка
        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Программное обеспечение для генерации случайных величин\n\n" +
                "Разработчик: Итальева Елизавета Александровна, студентка группы 23ИСП-1",
                "О программе",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        // обработчик нажатия на кнопку Сгенерировать
        private void generateButton_Click(object sender, EventArgs e)
        {
            // проверка на количество элементов
            if (!int.TryParse(textBoxCount.Text, out int count) || count <= 0)
            {
                MessageBox.Show(
                    "Количество случайных величин должно быть положительным целым числом.",
                    "Ошибка ввода данных",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            double[] values = new double[count];

            try
            {
                switch (comboBox1.SelectedIndex)
                {
                    case 0: // пуассоновское
                        double lambda = double.Parse(textBoxIntensity.Text);
                        if (lambda <= 0) throw new Exception("Интенсивность должна быть больше 0.");
                        for (int i = 0; i < count; i++)
                            values[i] = GeneratePuasson(lambda);
                        break;

                    case 1: // показательное
                        lambda = double.Parse(textBoxIntensity.Text);
                        if (lambda <= 0) throw new Exception("Интенсивность должна быть больше 0.");
                        for (int i = 0; i < count; i++)
                            values[i] = GenerateExponential(lambda);
                        break;

                    case 2: // равномерное
                        double a = double.Parse(textBoxLowerLimit.Text);
                        double b = double.Parse(textBoxUpperLimit.Text);
                        if (b <= a) throw new Exception("Верхняя граница должна быть больше нижней.");
                        for (int i = 0; i < count; i++)
                            values[i] = GenerateUniform(a, b);
                        break;

                    case 3: // нормальное
                        double m = double.Parse(textBoxMathExp.Text);
                        double sigma = double.Parse(textBoxStandDeviation.Text);
                        if (sigma <= 0) throw new Exception("Отклонение должно быть больше 0.");
                        for (int i = 0; i < count; i++)
                            values[i] = GenerateNormal(m, sigma);
                        break;

                    case 4: // логарифмически нормальное
                        m = double.Parse(textBoxMathExp.Text);
                        if (m > 20) throw new Exception("Математическое ожидание должно быть меньше 20.");
                        sigma = double.Parse(textBoxStandDeviation.Text);
                        if (sigma <= 0 || sigma > 20) throw new Exception("Отклонение должно быть больше 0 и меньше 20.");
                        for (int i = 0; i < count; i++)
                            values[i] = GenerateLogNormal(m, sigma);
                        break;

                    case 5: // треугольное
                        a = double.Parse(textBoxLowerLimit.Text);
                        b = double.Parse(textBoxUpperLimit.Text);
                        double d = double.Parse(textBoxMode.Text);
                        if (!(a <= d && d <= b)) throw new Exception("Мода должна быть между нижней и верхней границами.");
                        for (int i = 0; i < count; i++)
                            values[i] = GenerateTriangular(a, b, d);
                        break;

                    case 6: // гамма-распределение
                        double scale = double.Parse(textBoxScale.Text); // масштаб
                        double form = double.Parse(textBoxForm.Text);  // форма
                        if (scale <= 0 || form <= 0) throw new Exception("Параметры гамма-распределения должны быть больше 0.");
                        for (int i = 0; i < count; i++)
                            values[i] = GenerateGamma(scale, form);
                        break;
                }

                // вывод значений в текстовое поле
                textBoxOutput.Text = string.Join("  ", values.Select(v => v.ToString("F2"))); // добавление к строке, преобразование в текст

                // построение частотной диаграммы
                chart1.Series.Clear();
                chart1.ChartAreas[0].RecalculateAxesScale(); // принудительное пересчитывание масштаба

                // вычисление интервалов
                int intervalCount = 10;
                double min = values.Min();
                double max = values.Max();
                double intervalWidth = (max - min) / intervalCount;

                int[] frequencies = new int[intervalCount]; // массив frequencies хранит количество попаданий в i-й интервал

                // подстчёт количества попаданий в каждый интервал
                foreach (double value in values) // выбираем и проверям каждое значение в массиве
                {
                    for (int i = 0; i < intervalCount; i++)
                    {
                        double left = min + i * intervalWidth;
                        double right = min + (i + 1) * intervalWidth;

                        if ((value >= left && value < right) || (i == intervalCount - 1 && value == max)) // учитывается ещё и максимальное значение для последнего интервала
                        {
                            frequencies[i]++;
                            break;
                        }
                    }
                }

                // проверка на максимальное количество попаданий и задание шага отображения значений и сетки
                int maxFrequency = frequencies.Max();
                if (maxFrequency > 1000)
                {
                    chart1.ChartAreas[0].AxisY.LabelStyle.Interval = 100;
                    chart1.ChartAreas[0].AxisY.MajorGrid.Interval = 100;
                }
                else if (maxFrequency > 500)
                {
                    chart1.ChartAreas[0].AxisY.LabelStyle.Interval = 50;
                    chart1.ChartAreas[0].AxisY.MajorGrid.Interval = 50;
                }
                else if (maxFrequency > 90)
                {
                    chart1.ChartAreas[0].AxisY.LabelStyle.Interval = 8;
                    chart1.ChartAreas[0].AxisY.MajorGrid.Interval = 8;
                }
                else if (maxFrequency > 50)
                {
                    chart1.ChartAreas[0].AxisY.LabelStyle.Interval = 4;
                    chart1.ChartAreas[0].AxisY.MajorGrid.Interval = 4;
                }
                else if (maxFrequency > 30)
                {
                    chart1.ChartAreas[0].AxisY.LabelStyle.Interval = 2;
                    chart1.ChartAreas[0].AxisY.MajorGrid.Interval = 2;
                }
                else
                {
                    chart1.ChartAreas[0].AxisY.LabelStyle.Interval = 1;
                    chart1.ChartAreas[0].AxisY.MajorGrid.Interval = 1;
                }


                var series = chart1.Series.Add("Частота");
                var axisX = chart1.ChartAreas[0].AxisX;
                axisX.CustomLabels.Clear();

                chart1.ChartAreas[0].AxisX.LabelStyle.Angle = -45; // наклон подписей Ох

                // задание ширины столбцов
                series["PointWidth"] = "0.90";

                // отрисовка столбцов и подписей
                for (int i = 0; i < intervalCount; i++)
                {
                    double left = min + i * intervalWidth;
                    double right = left + intervalWidth;
                    double mid = (left + right) / 2;

                    series.Points.AddXY(mid, frequencies[i]);

                    string label = $"{Math.Round(left, 2)} - {Math.Round(right, 2)}";
                    chart1.ChartAreas[0].AxisX.CustomLabels.Add(new CustomLabel(left, right, label, 0, LabelMarkStyle.None));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Ошибка вывода данных",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        // обработчик нажатия на кнопку Сброс
        private void resetButton_Click(object sender, EventArgs e)
        {
            // очистка текстовых полей
            textBoxCount.Clear();
            textBoxMathExp.Clear();
            textBoxStandDeviation.Clear();
            textBoxIntensity.Clear();
            textBoxLowerLimit.Clear();
            textBoxUpperLimit.Clear();
            textBoxOutput.Clear();
            textBoxForm.Clear();
            textBoxScale.Clear();
            textBoxMode.Clear();

            comboBox1.SelectedIndex = -1;

            chart1.Series.Clear();
        }

        // отображение параметров в соответствии с выбранным законом распределения
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // скрытие всех элементов параметров по умолчанию
            hideElements();

            switch (comboBox1.SelectedIndex)
            {
                // пуассоновское
                case 0:
                    labelIntensity.Visible = true;
                    textBoxIntensity.Visible = true;
                    break;
                // показательное
                case 1:
                    labelIntensity.Visible = true;
                    textBoxIntensity.Visible = true;
                    break;
                // равномерное
                case 2:
                    labelLowerLimit.Visible = true;
                    textBoxLowerLimit.Visible = true;
                    labelUpperLimit.Visible = true;
                    textBoxUpperLimit.Visible = true;
                    break;
                // нормальное
                case 3:
                    labelMathExp.Visible = true;
                    textBoxMathExp.Visible = true;
                    labelStandDeviation.Visible = true;
                    textBoxStandDeviation.Visible = true;
                    break;
                // лгарифмически нормальное
                case 4:
                    labelMathExp.Visible = true;
                    textBoxMathExp.Visible = true;
                    labelStandDeviation.Visible = true;
                    textBoxStandDeviation.Visible = true;
                    break;
                // треугольное
                case 5:
                    labelLowerLimit.Visible = true;
                    textBoxLowerLimit.Visible = true;
                    labelUpperLimit.Visible = true;
                    textBoxUpperLimit.Visible = true;
                    labelMode.Visible = true;
                    textBoxMode.Visible = true;
                    break;
                // гамма распределение
                case 6:
                    labelForm.Visible = true;
                    textBoxForm.Visible = true;
                    labelScale.Visible = true;
                    textBoxScale.Visible = true;
                    break;
            }
            CheckNotEmpty();
        }

        // метод скрытия пераметров
        private void hideElements()
        {
            labelIntensity.Visible = false;
            textBoxIntensity.Visible = false;
            labelLowerLimit.Visible = false;
            textBoxLowerLimit.Visible = false;
            labelUpperLimit.Visible = false;
            textBoxUpperLimit.Visible = false;
            labelMathExp.Visible = false;
            textBoxMathExp.Visible = false;
            labelStandDeviation.Visible = false;
            textBoxStandDeviation.Visible = false;
            labelMode.Visible = false;
            textBoxMode.Visible = false;
            labelForm.Visible = false;
            textBoxForm.Visible = false;
            labelScale.Visible = false;
            textBoxScale.Visible = false;
        }

        // метод проверки заполненности полей и включение кнопки Сгенерировать
        private void CheckNotEmpty()
        {
            // проверка выбора закона распределения
            bool notEmpty = comboBox1.SelectedIndex >= 0;

            // проверка количества случайных величин
            notEmpty &= !string.IsNullOrEmpty(textBoxCount.Text);

            // проверка параметров в зависимости от выбранного закона распределения
            switch (comboBox1.SelectedIndex)
            {
                // пуассоновское
                case 0:
                    notEmpty &= !string.IsNullOrEmpty(textBoxIntensity.Text);
                    break;
                // показательное
                case 1:
                    notEmpty &= !string.IsNullOrEmpty(textBoxIntensity.Text);
                    break;
                // равномерное
                case 2:
                    notEmpty &= !string.IsNullOrEmpty(textBoxLowerLimit.Text)
                             && !string.IsNullOrEmpty(textBoxUpperLimit.Text);
                    break;
                // нормальное
                case 3:
                    notEmpty &= !string.IsNullOrEmpty(textBoxMathExp.Text)
                             && !string.IsNullOrEmpty(textBoxStandDeviation.Text);
                    break;
                // лгарифмически нормальное
                case 4:
                    notEmpty &= !string.IsNullOrEmpty(textBoxMathExp.Text)
                             && !string.IsNullOrEmpty(textBoxStandDeviation.Text);
                    break;
                // треугольное
                case 5:
                    notEmpty &= !string.IsNullOrEmpty(textBoxLowerLimit.Text)
                             && !string.IsNullOrEmpty(textBoxUpperLimit.Text)
                             && !string.IsNullOrEmpty(textBoxMode.Text);
                    break;
                // гамма распределение
                case 6:
                    notEmpty &= !string.IsNullOrEmpty(textBoxForm.Text)
                             && !string.IsNullOrEmpty(textBoxScale.Text);
                    break;
            }
            generateButton.Enabled = notEmpty;
        }

        // метод защиты ввода
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // преобразование sender в TeextBox, чтобы 
            TextBox tb = sender as TextBox;
            string tag = tb.Tag?.ToString();

            // добавление тега для допуска ввода минуса
            bool allowMinis = tb.Tag != null && tag == "allowMinus";

            // добавление тега для целых неотрицательных чисел
            bool onlyIntPositive = tb.Tag != null && tag == "onlyIntPositive";

            // проверка вводимых значений
            if (!char.IsDigit(e.KeyChar) // проверка цифр
                && e.KeyChar != '\b' // проверка backspace
                && !(e.KeyChar == '-' 
                    && tb.SelectionStart == 0
                    && tb.Tag != null
                    && tag == "allowMinus"
                    && !tb.Text.Contains("-")
                    && tag != "onlyIntPositive")
                && !(e.KeyChar == ',' // проверка запятой
                    && !tb.Text.Contains(',')
                    && tb.SelectionStart > 0
                    && tb.Text[tb.SelectionStart - 1] != '-'
                    && tag != "onlyIntPositive"))
                e.Handled = true;
        }

        // проверка изменений текстовых полей
        private void textBox_TextChanged(object sender, EventArgs e)
        {
            CheckNotEmpty();
        }

        // методы генерации случайных величин

        // вычисление чисел по пуассоновскому распределению
        private int GeneratePuasson(double lambda)
        {
            double L = Math.Exp(-lambda);
            double p = 1.0;
            int k = 0;
            while (p > L)
            {
                k++;
                p *= rnd.NextDouble();
            };
            return k - 1;
        }

        // вычисление чисел по показательному распределению
        private double GenerateExponential(double lambda) // где lambda - интенсивность
        {
            return -1.0 / lambda * Math.Log(rnd.NextDouble());
        }

        // вычисление чисел по равномерному распределению
        private double GenerateUniform(double a, double b) // где а - нижняя граница, b - верхняя
        {
            return a + (b - a) * rnd.NextDouble();
        }

        // вычисление чисел по нормальному распределению
        private double GenerateNormal(double m, double sigma) // где m - мат ожидание, sigma - среднеквадратичное откронение
        {
            double rand1 = rnd.NextDouble();
            double rand2 = rnd.NextDouble();
            double z = Math.Sqrt(-2.0 * Math.Log(rand1)) * Math.Cos(2.0 * Math.PI * rand2); // по преобразованию Бокса-Мюллера
            return m + sigma * z;
        }

        // вычисление чисел по логарифмически нормальному распределению
        private double GenerateLogNormal(double m, double sigma)
        {
            return Math.Exp(GenerateNormal(m, sigma));
        }

        // вычисление чисел по треугольному распределению
        private double GenerateTriangular(double a, double b, double d) // где d - мода
        {
            double r = rnd.NextDouble();
            if (r <= (d - a) / (b - a))
                return a + Math.Sqrt((d - a) * (b - a) * r);
            else
                return b - Math.Sqrt((b - d) * (b - a) * (1 - r));
        }

        // вычисление чисел по гамма распределению
        private double GenerateGamma(double a, double b) // где a - масштаб, b - форма
        {
            double sum = 0;
            for (int i = 0; i < b; i++)
            {
                double r = rnd.NextDouble();
                sum += Math.Log(1 - r);
            }
            return -1.0 / a * sum;
        }
    }
}
