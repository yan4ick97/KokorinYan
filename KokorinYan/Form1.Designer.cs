namespace KokorinYan
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
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOrchid;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(61, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 62);
            this.button1.TabIndex = 0;
            this.button1.Text = " 9.1 Получение пути к запущенному приложению ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.RosyBrown;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(332, 40);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(665, 355);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkOrchid;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(61, 80);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 74);
            this.button2.TabIndex = 2;
            this.button2.Text = "9.2 Получение пути к папке, из которого запущено приложение";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkOrchid;
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(61, 160);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 71);
            this.button3.TabIndex = 3;
            this.button3.Text = " 9.3. Запуск другого приложения ";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkOrchid;
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.Location = new System.Drawing.Point(61, 237);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(119, 59);
            this.button4.TabIndex = 4;
            this.button4.Text = " 9.4. Запуск приложения с параметрами ";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DarkOrchid;
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button5.Location = new System.Drawing.Point(61, 355);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(119, 60);
            this.button5.TabIndex = 5;
            this.button5.Text = " 9.6. Запуск приложения с запретом на закрытие своего приложения ";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.DarkOrchid;
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button6.Location = new System.Drawing.Point(61, 302);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(119, 47);
            this.button6.TabIndex = 6;
            this.button6.Text = " 9.5. Запуск приложения с запретом на закрытие своего приложения ";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.DarkOrchid;
            this.button7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button7.Location = new System.Drawing.Point(61, 421);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(119, 66);
            this.button7.TabIndex = 7;
            this.button7.Text = " 9.7. Открытие файла в ассоциированном приложении ";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.DarkOrchid;
            this.button8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button8.Location = new System.Drawing.Point(61, 493);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(119, 56);
            this.button8.TabIndex = 8;
            this.button8.Text = " 9.8. Получение числа процессоров в системе ";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.DarkOrchid;
            this.button9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button9.Location = new System.Drawing.Point(61, 555);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(119, 52);
            this.button9.TabIndex = 9;
            this.button9.Text = " 9.9. Второй способ получения процессоров в системе ";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.DarkOrchid;
            this.button10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button10.Location = new System.Drawing.Point(61, 613);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(119, 61);
            this.button10.TabIndex = 10;
            this.button10.Text = " 9.10. Пауза в программе ";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.DarkOrchid;
            this.button11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button11.Location = new System.Drawing.Point(61, 680);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(119, 50);
            this.button11.TabIndex = 11;
            this.button11.Text = "9.11. Получение списка всех процессов, запущенных в системе";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.DarkOrchid;
            this.button12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button12.Location = new System.Drawing.Point(196, 12);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(105, 61);
            this.button12.TabIndex = 12;
            this.button12.Text = " 9.12. Получение списка оконных процессов";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.DarkOrchid;
            this.button13.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button13.Location = new System.Drawing.Point(196, 80);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(105, 74);
            this.button13.TabIndex = 13;
            this.button13.Text = " 9.13. Получение списка определенных процессов ";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.MediumOrchid;
            this.button14.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button14.Location = new System.Drawing.Point(196, 160);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(105, 71);
            this.button14.TabIndex = 14;
            this.button14.Text = " 9.16. Определение операционной системы пользователя";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.DarkOrchid;
            this.button15.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button15.Location = new System.Drawing.Point(196, 237);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(105, 58);
            this.button15.TabIndex = 15;
            this.button15.Text = " 9.17. Исправленная версия проверки операционной системы";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.DarkOrchid;
            this.button17.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button17.Location = new System.Drawing.Point(196, 302);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(105, 47);
            this.button17.TabIndex = 17;
            this.button17.Text = " 9.22. Получение имени пользователя системы ";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.BackgroundImage = global::KokorinYan.Properties.Resources.Снимок;
            this.ClientSize = new System.Drawing.Size(1022, 850);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button17;
    }
}

