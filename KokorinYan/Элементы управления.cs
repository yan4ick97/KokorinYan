using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Configuration;
using System.Drawing.Drawing2D;


namespace KokorinYan
{

    public partial class Элементы_управления : Form

    {
        const string strTextForButton = "Тестовая строкаааааааааааааа";
        public Элементы_управления()
        {
            InitializeComponent();
           

        }

        private void Элементы_управления_Load(object sender, EventArgs e)
        {
           
        }
        public class MyButton : Button
        {
            protected override void OnPaint(PaintEventArgs e)
            {
                base.OnPaint(e);
                int borderWidth = 6;
                Color borderColor = Color.Purple;
                ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, borderColor,
                borderWidth, ButtonBorderStyle.Solid, borderColor,
                borderWidth, ButtonBorderStyle.Solid, borderColor,
                borderWidth, ButtonBorderStyle.Solid, borderColor,
                borderWidth, ButtonBorderStyle.Solid);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Шаг 1 
            TextBox tb = new TextBox();
            // Шаг 2 
            tb.Location = new Point(10, 10);
            tb.Size = new Size(100, 20);
            tb.Text = "Я был создан во время выполнения программы";
            // Шаг 3 
            this.Controls.Add(tb);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                // Работаем только с текстовыми полями 
                if (ctrl.GetType() == typeof(TextBox))
                    ctrl.Text = "Народные советы";
            }
        }

        private void IterateControls(Control ctrl)
        {
            // Работаем только с текстовыми полями 
            if (ctrl.GetType() == typeof(TextBox))
            {
                ctrl.Text = "АМАРОКУБА НАЖИВАСАКЕ";
            }
            // Проходим через элементы рекурсивно, 
            // чтобы не пропустить элементы, которые находятся в контейнерах 
            foreach (Control ctrlChild in ctrl.Controls)
            {
                IterateControls(ctrlChild);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            IterateControls(this);
        }


        private void button4_Click(object sender, EventArgs e)
        {
            MyButton btn = new MyButton();
            btn.Width = 90;
            btn.Height = 50;
            btn.Left = 100;
            btn.Top = 10;
            btn.Text = "Я новая кнопка";
            btn.Visible = true;
            this.Controls.Add(btn);
        }

        

        private void Элементы_управления_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen p = new Pen(Color.Red, 3);

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl.GetType() == typeof(CheckBox))
                {
                    g.DrawRectangle(p, new Rectangle(ctrl.Location, ctrl.Size));
                }
            }

        }

       

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            const int MAX_LENGTH = 4;
            if (richTextBox1.Text.Length == MAX_LENGTH)
                // переводим фокус на следующий элемент управления 
                SelectNextControl(richTextBox1, true, true, false, false);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Выводим кнопку button2 на передний край 
            this.Controls.SetChildIndex(button1, 0);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button1.Text = strTextForButton;
            using (Graphics graphics = button1.CreateGraphics())
                button1.Width = (int)graphics.MeasureString(strTextForButton,
                 Font).Width;
            this.Text = button1.Width.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            GraphicsPath gp = new GraphicsPath();
            Graphics g = CreateGraphics();
            // Создадим новый прямоугольник с размерами кнопки 
            Rectangle smallRectangle = button1.ClientRectangle;

            // уменьшим размеры прямоугольника 
            smallRectangle.Inflate(-3, -3);
            // создадим эллипс, используя полученные размеры 
            gp.AddEllipse(smallRectangle);
            button1.Region = new Region(gp);
            // рисуем окантовоку для круглой кнопки 
            g.DrawEllipse(new Pen(Color.Gray, 2),
            button1.Left + 1,
            button1.Top + 1,
            button1.Width - 3,
            button1.Height - 3);
            // освобождаем ресурсы 
            g.Dispose();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
