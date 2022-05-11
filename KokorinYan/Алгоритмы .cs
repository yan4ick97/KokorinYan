using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.IO;
using System.Text.RegularExpressions;


namespace KokorinYan
{
    public partial class Алгоритмы : Form
    {
        public Алгоритмы()
        {
            InitializeComponent();
        }

        // Метод для нахождения наибольшего значения из трех заданных чисел 
        public static int FindMax3(int a, int b, int c)
        {
            int max;
            max = Math.Max(a, Math.Max(b, c));
            return max;
        }

        // Метод для нахождения наименьшего значения из трех заданных чисел 
        public static int FindMin3(int a, int b, int c)
        {
            int min;
            min = Math.Min(a, Math.Min(b, c));
            return min;
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int x;
            int y;
            int z;

            x = Convert.ToInt32(textBox1.Text);

            y = Convert.ToInt32(textBox2.Text);

            z = Convert.ToInt32(textBox3.Text);

            listBox1.Items.Add("Наибольшее число из трех: " + FindMax3(x, y, z));
            listBox1.Items.Add("Наименьшее число из трех: " + FindMin3(x, y, z));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String[] s = Regex.Split("Январь Февраль Март Апрель Май Июнь   " +
                " Июль Август Сентябрь Октябрь Ноябрь Декабрь", " ");
            // Выводим 12 элемент массива 
            listBox1.Items.Add(s[10]);

        }


     

        private void button3_Click(object sender, EventArgs e)
        { int degrees= Convert.ToInt32(textBox1.Text);

            double radians = (Math.PI / 180) * degrees;
                listBox1.Items.Add(radians);
            listBox1.Items.Add (radians);
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int radians = Convert.ToInt32(textBox1.Text);
            double degrees = (180 / Math.PI) * radians;
            listBox1.Items.Add (degrees);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int Fahrenheit= Convert.ToInt32(textBox1.Text);
            listBox1.Items.Add((5.0 / 9.0) * (Fahrenheit - 32));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int Celsius= Convert.ToInt32(textBox1.Text);
            listBox1.Items.Add(((9.0 / 5.0) * Celsius) + 32);
        }

        private Random m_Rnd = new Random();
        private Color RandomRGBColor()
        {
            return Color.FromArgb(255, m_Rnd.Next(0, 255),
            m_Rnd.Next(0, 255), m_Rnd.Next(0, 255));
        }
        private void button7_Click(object sender, EventArgs e)
        {
            this.BackColor = RandomRGBColor();
        }
    }
}
