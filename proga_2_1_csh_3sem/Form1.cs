using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace proga_2_1_csh_3sem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void calculateButton_Click_1(object sender, EventArgs e)
        {
            double x; // Объявляем переменную x типа double
            if (!double.TryParse(xEdit.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out x))
            {
                xEdit.Focus();
                xEdit.SelectAll();
                // Попытка преобразовать текст из xEdit в double неудачна, показываем сообщение об ошибке и прерываем выполнение метода
                MessageBox.Show("Пожалуйста, введите допустимое значение для x.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool doubleResult = doubleResultCheck2.Checked; // Получаем значение checkbox doubleResultCheckBox2
            double result = 0.0; // Инициализируем переменную result типа double нулевым значением

            // Определяем формулу в зависимости от значения x
            if (x <= 0)
            {
                formula1Radio.Checked = true; // Устанавливаем формулу 1 как выбранную
                result = Math.Pow(Math.Cos(x), 2); // Вычисляем результат по формуле 1
            }
            else if (x < 1)
            {
                formula2Radio.Checked = true; // Устанавливаем формулу 2 как выбранную
                result = 2 * Math.Pow(x, 3) - 2; // Вычисляем результат по формуле 2
            }
            else
            {
                formula3Radio.Checked = true; // Устанавливаем формулу 3 как выбранную
                result = (x + 1) * Math.Sqrt(x); // Вычисляем результат по формуле 3
            }

            // Если checkbox doubleResultCheckBox2 выбран, умножаем результат на 2
            if (doubleResult)
            {
                result *= 2;
            }

            resultLabel.Text = result.ToString(); // Отображаем результат в текстовом поле resultLabel
        }


        private void formula1Radio_CheckedChanged(object sender, EventArgs e)
        {
            if (formula1Radio.Checked)
            {
                if (!double.TryParse(xEdit.Text, out double x))
                {
                    xEdit.Focus();
                    xEdit.SelectAll();
                    MessageBox.Show("Неверное значение для x.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                double result = Math.Pow(Math.Cos(x), 2);
                resultLabel.Text = result.ToString();

                if (doubleResultCheck2.Checked)
                {
                    result *= 2;
                    resultLabel.Text = result.ToString();
                }
            }
        }

        private void formula2Radio_CheckedChanged(object sender, EventArgs e)
        {
            if (formula2Radio.Checked)
            {
                if (!double.TryParse(xEdit.Text, out double x))
                {
                    xEdit.Focus();
                    xEdit.SelectAll();
                    MessageBox.Show("Неверное значение для x.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                double result = 2 * Math.Pow(x, 3) - 2;
                resultLabel.Text = result.ToString();

                if (doubleResultCheck2.Checked)
                {
                    result *= 2;
                    resultLabel.Text = result.ToString();
                }
            }
        }

        private void formula3Radio_CheckedChanged(object sender, EventArgs e)
        {
            if (formula3Radio.Checked)
            {
                if (!double.TryParse(xEdit.Text, out double x))
                {
                    xEdit.Focus();
                    xEdit.SelectAll();
                    MessageBox.Show("Неверное значение для x.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                double result = (x + 1) * Math.Sqrt(x);
                resultLabel.Text = result.ToString();

                if (doubleResultCheck2.Checked)
                {
                    result *= 2;
                    resultLabel.Text = result.ToString();
                }
            }
        }

        private void doubleResultCheck2_CheckedChanged(object sender, EventArgs e)
        {
            if (double.TryParse(resultLabel.Text, out double result))
            {
                if (!double.TryParse(xEdit.Text, out double x))
                {
                    xEdit.Focus();
                    xEdit.SelectAll();
                    MessageBox.Show("Неверное значение для x.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (doubleResultCheck2.Checked)
                {
                    result *= 2;
                }
                else
                {
                    result /= 2;
                }

                resultLabel.Text = result.ToString();
            }
            else
            {
                xEdit.Focus();
                xEdit.SelectAll();
                MessageBox.Show("Неверное значение для результата.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void xEdit_TextChanged(object sender, EventArgs e)
        {
            // double x = double.Parse(xEdit.Text);

            // if (double.IsNaN(x) || x == double.NaN)
            // {
            //     MessageBox.Show("Please enter a valid value for x.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //     return;
            // }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Add any initialization code here
        }

        
    }
}
