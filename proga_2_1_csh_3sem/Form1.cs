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
            calculateButton.Click += calculateButton_Click; // Подписываемся на событие Click кнопки calculateButton и связываем его с методом calculateButton_Click
            //formula1RadioButton.Checked = true; // Комментарий: Устанавливаем формулу 1 как выбранную по умолчанию
        }

        private void Form1_Load(object sender, EventArgs e) { } // Метод Form1_Load вызывается при загрузке формы

        // Метод calculateButton_Click вызывается при нажатии кнопки calculateButton
        private void calculateButton_Click(object sender, EventArgs e)
        {
            double x; // Объявляем переменную x типа double
            if (!double.TryParse(xEdit.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out x))
            {
                // Попытка преобразовать текст из xEdit в double неудачна, показываем сообщение об ошибке и прерываем выполнение метода
                MessageBox.Show("Пожалуйста, введите допустимое значение для x.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool doubleResult = doubleResultCheckBox2.Checked; // Получаем значение checkbox doubleResultCheckBox2
            double result = 0.0; // Инициализируем переменную result типа double нулевым значением

            // Определяем формулу в зависимости от значения x
            if (x <= 0)
            {
                formula1RadioButton.Checked = true; // Устанавливаем формулу 1 как выбранную
                result = Math.Pow(Math.Cos(x), 2); // Вычисляем результат по формуле 1
            }
            else if (x < 1)
            {
                formula2RadioButton.Checked = true; // Устанавливаем формулу 2 как выбранную
                result = 2 * Math.Pow(x, 3) - 2; // Вычисляем результат по формуле 2
            }
            else
            {
                formula3RadioButton.Checked = true; // Устанавливаем формулу 3 как выбранную
                result = (x + 1) * Math.Sqrt(x); // Вычисляем результат по формуле 3
            }

            // Если checkbox doubleResultCheckBox2 выбран, умножаем результат на 2
            if (doubleResult)
            {
                result *= 2;
            }

            resultLabel.Text = result.ToString(); // Отображаем результат в текстовом поле resultLabel
        }

        // Метод formula1RadioButton_CheckedChanged вызывается при изменении состояния checkbox formula1RadioButton
        private void formula1RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (formula1RadioButton.Checked)
            {
                string xText = xEdit.Text; // Получаем текст из xEdit

                if (string.IsNullOrWhiteSpace(xText))
                {
                    // Показываем сообщение об ошибке, если текст из xEdit пустой или состоит только из пробелов, и прерываем выполнение метода
                    MessageBox.Show("Пожалуйста, введите допустимое значение для x.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!double.TryParse(xText, NumberStyles.Any, CultureInfo.InvariantCulture, out double x))
                {
                    // Показываем сообщение об ошибке, если преобразование текста из xEdit в double неудачно, и прерываем выполнение метода
                    MessageBox.Show("Пожалуйста, введите допустимое значение для x.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                double result = Math.Pow(Math.Cos(x), 2); // Вычисляем результат по формуле 1
                resultLabel.Text = result.ToString(); // Отображаем результат в текстовом поле resultLabel

                if (doubleResultCheckBox2.Checked)
                {
                    // Если checkbox doubleResultCheckBox2 выбран, умножаем результат на 2 и отображаем его в текстовом поле resultLabel
                    resultLabel.Text = (result *= 2).ToString();
                }
            }
        }

        // Метод formula2RadioButton_CheckedChanged вызывается при изменении состояния checkbox formula2RadioButton
        private void formula2RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (formula2RadioButton.Checked)
            {
                string xText = xEdit.Text; // Получаем текст из xEdit

                if (string.IsNullOrWhiteSpace(xText))
                {
                    // Показываем сообщение об ошибке, если текст из xEdit пустой или состоит только из пробелов, и прерываем выполнение метода
                    MessageBox.Show("Пожалуйста, введите допустимое значение для x.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!double.TryParse(xText, NumberStyles.Any, CultureInfo.InvariantCulture, out double x))
                {
                    // Показываем сообщение об ошибке, если преобразование текста из xEdit в double неудачно, и прерываем выполнение метода
                    MessageBox.Show("Пожалуйста, введите допустимое значение для x.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                double result = 2 * Math.Pow(x, 3) - 2; // Вычисляем результат по формуле 2
                resultLabel.Text = result.ToString(); // Отображаем результат в текстовом поле resultLabel

                if (doubleResultCheckBox2.Checked)
                {
                    // Если checkbox doubleResultCheckBox2 выбран, умножаем результат на 2 и отображаем его в текстовом поле resultLabel
                    resultLabel.Text = (result *= 2).ToString();
                }
            }
        }

        // Метод formula3RadioButton_CheckedChanged вызывается при изменении состояния checkbox formula3RadioButton
        private void formula3RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (formula3RadioButton.Checked)
            {
                string xText = xEdit.Text; // Получаем текст из xEdit

                if (string.IsNullOrWhiteSpace(xText))
                {
                    // Показываем сообщение об ошибке, если текст из xEdit пустой или состоит только из пробелов, и прерываем выполнение метода
                    MessageBox.Show("Пожалуйста, введите допустимое значение для x.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!double.TryParse(xText, NumberStyles.Any, CultureInfo.InvariantCulture, out double x))
                {
                    // Показываем сообщение об ошибке, если преобразование текста из xEdit в double неудачно, и прерываем выполнение метода
                    MessageBox.Show("Пожалуйста, введите допустимое значение для x.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                double result = (x + 1) * Math.Sqrt(x); // Вычисляем результат по формуле 3
                resultLabel.Text = result.ToString(); // Отображаем результат в текстовом поле resultLabel

                if (doubleResultCheckBox2.Checked)
                {
                    // Если checkbox doubleResultCheckBox2 выбран, умножаем результат на 2 и отображаем его в текстовом поле resultLabel
                    resultLabel.Text = (result *= 2).ToString();
                }
            }
        }

        // Метод doubleResultCheckBox2_CheckedChanged вызывается при изменении состояния checkbox doubleResultCheckBox2
        private void doubleResultCheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            string xText = xEdit.Text; // Получаем текст из xEdit

            if (string.IsNullOrWhiteSpace(xText))
            {
                // Показываем сообщение об ошибке, если текст из xEdit пустой или состоит только из пробелов, и прерываем выполнение метода
                MessageBox.Show("Пожалуйста, введите допустимое значение для x.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double result = double.Parse(resultLabel.Text); // Получаем текущий результат из текстового поля resultLabel

            if (doubleResultCheckBox2.Checked)
            {
                // Если checkbox doubleResultCheckBox2 выбран, умножаем результат на 2
                result *= 2;
            }
            else
            {
                // Если checkbox doubleResultCheckBox2 не выбран, делим результат на 2
                result /= 2;
            }

            resultLabel.Text = result.ToString(); // Отображаем новый результат в текстовом поле resultLabel
        }

        
        private void xEdit_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}