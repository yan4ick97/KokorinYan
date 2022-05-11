namespace KokorinYan
{
    partial class Элементы_управления
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "6.1. Добавление элемента на форму";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.EnabledChanged += new System.EventHandler(this.button1_Click);
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(38, 79);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 60);
            this.button2.TabIndex = 1;
            this.button2.Text = "6.2. Получение всех элементов управления на форме";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(38, 145);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 40);
            this.button3.TabIndex = 3;
            this.button3.Text = "6.3. Рекурсивный способ обхода всех элементов управления";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(388, 191);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 195);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(45, 94);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(268, 20);
            this.textBox1.TabIndex = 0;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(170, 79);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(107, 94);
            this.button5.TabIndex = 10;
            this.button5.Text = "6.6. Программный перевод фокуса на другой элемент управления ";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.TabIndexChanged += new System.EventHandler(this.Элементы_управления_Load);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(326, 32);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(100, 20);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(38, 191);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(111, 49);
            this.button4.TabIndex = 5;
            this.button4.Text = "6.4. Изменение цвета границ у элемента управления";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 275);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(250, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "6.5 Окантовка вокруг элемента управления";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(150, 31);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(103, 42);
            this.button6.TabIndex = 11;
            this.button6.Text = "6.7. Изменение Z-порядка";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(181, 179);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(89, 90);
            this.button7.TabIndex = 12;
            this.button7.Text = " 6.8. Получение размеров строки в пикселах";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(187, 298);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(90, 88);
            this.button8.TabIndex = 13;
            this.button8.Text = " 6.9. Превращение стандартной кнопки в овальную";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Элементы_управления
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Элементы_управления";
            this.Text = "Элементы_управления";
            this.Load += new System.EventHandler(this.Элементы_управления_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Элементы_управления_Paint);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox richTextBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
    }
}