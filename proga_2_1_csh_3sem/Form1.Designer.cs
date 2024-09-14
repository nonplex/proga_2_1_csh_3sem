namespace proga_2_1_csh_3sem
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
            this.label1 = new System.Windows.Forms.Label();
            this.xEdit = new System.Windows.Forms.TextBox();
            this.formula1RadioButton = new System.Windows.Forms.RadioButton();
            this.formula2RadioButton = new System.Windows.Forms.RadioButton();
            this.formula3RadioButton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.doubleResultCheckBox2 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите x: ";
            // 
            // xEdit
            // 
            this.xEdit.Location = new System.Drawing.Point(183, 67);
            this.xEdit.Name = "xEdit";
            this.xEdit.Size = new System.Drawing.Size(100, 20);
            this.xEdit.TabIndex = 1;
            this.xEdit.TextChanged += new System.EventHandler(this.xEdit_TextChanged);
            // 
            // formula1RadioButton
            // 
            this.formula1RadioButton.AutoSize = true;
            this.formula1RadioButton.Location = new System.Drawing.Point(183, 105);
            this.formula1RadioButton.Name = "formula1RadioButton";
            this.formula1RadioButton.Size = new System.Drawing.Size(117, 17);
            this.formula1RadioButton.TabIndex = 2;
            this.formula1RadioButton.TabStop = true;
            this.formula1RadioButton.Text = "y =[cos(x)]^2,  x<=0";
            this.formula1RadioButton.UseVisualStyleBackColor = true;
            this.formula1RadioButton.CheckedChanged += new System.EventHandler(this.formula1RadioButton_CheckedChanged);
            // 
            // formula2RadioButton
            // 
            this.formula2RadioButton.AutoSize = true;
            this.formula2RadioButton.Location = new System.Drawing.Point(183, 129);
            this.formula2RadioButton.Name = "formula2RadioButton";
            this.formula2RadioButton.Size = new System.Drawing.Size(121, 17);
            this.formula2RadioButton.TabIndex = 3;
            this.formula2RadioButton.TabStop = true;
            this.formula2RadioButton.Text = "y= 2x^3-2,      0<x<1";
            this.formula2RadioButton.UseVisualStyleBackColor = true;
            this.formula2RadioButton.CheckedChanged += new System.EventHandler(this.formula2RadioButton_CheckedChanged);
            // 
            // formula3RadioButton
            // 
            this.formula3RadioButton.AutoSize = true;
            this.formula3RadioButton.Location = new System.Drawing.Point(183, 153);
            this.formula3RadioButton.Name = "formula3RadioButton";
            this.formula3RadioButton.Size = new System.Drawing.Size(129, 17);
            this.formula3RadioButton.TabIndex = 4;
            this.formula3RadioButton.TabStop = true;
            this.formula3RadioButton.Text = "y =(x+1)*(sqrt(x)), x>=1";
            this.formula3RadioButton.UseVisualStyleBackColor = true;
            this.formula3RadioButton.CheckedChanged += new System.EventHandler(this.formula3RadioButton_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Получившийся y:";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(180, 247);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 13);
            this.resultLabel.TabIndex = 7;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(183, 198);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 8;
            this.calculateButton.Text = "Посчитать";
            this.calculateButton.UseVisualStyleBackColor = true;
            // 
            // doubleResultCheckBox2
            // 
            this.doubleResultCheckBox2.AutoSize = true;
            this.doubleResultCheckBox2.Location = new System.Drawing.Point(183, 175);
            this.doubleResultCheckBox2.Name = "doubleResultCheckBox2";
            this.doubleResultCheckBox2.Size = new System.Drawing.Size(76, 17);
            this.doubleResultCheckBox2.TabIndex = 9;
            this.doubleResultCheckBox2.Text = "Удвоение";
            this.doubleResultCheckBox2.UseVisualStyleBackColor = true;
            this.doubleResultCheckBox2.CheckedChanged += new System.EventHandler(this.doubleResultCheckBox2_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.doubleResultCheckBox2);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.formula3RadioButton);
            this.Controls.Add(this.formula2RadioButton);
            this.Controls.Add(this.formula1RadioButton);
            this.Controls.Add(this.xEdit);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox xEdit;
        private System.Windows.Forms.RadioButton formula1RadioButton;
        private System.Windows.Forms.RadioButton formula2RadioButton;
        private System.Windows.Forms.RadioButton formula3RadioButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.CheckBox doubleResultCheckBox2;
    }
}

