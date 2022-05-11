using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KokorinYan
{
    public partial class Числа : Form
    {
        public Числа()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int parrots = 38;
            textBox1.Text = parrots.ToString("X8");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int myvalue = 4;
            textBox1.Text = Convert.ToString(myvalue, 2); // возвратит 100
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int myValue = 365;
            // Преобразуем в восьмеричное значение
            listBox1.Items.Add(Convert.ToString(myValue, 8));
            // Преобразуем в шестнадцатеричное значение
            listBox1.Items.Add(Convert.ToString(myValue, 16));
        }

        enum Cats { Рыжик = 0, Барсик = 1, Мурзик = 2, Васька = 3, Пушок = 4};
        private void button4_Click(object sender, EventArgs e)
        {
            // Перечисляем все элементы перечисления
            string[] catNames = Enum.GetNames(typeof(Cats));
            foreach (string s in catNames)
            {
                listBox1.Items.Add(s);
            }
            // Перечисляем все значения перечисления
            int[] valCats = (int[])Enum.GetValues(typeof(Cats));
            foreach (int val in valCats)
            {
                listBox1.Items.Add(val.ToString());
            }
            listBox1.Items.Add(catNames[0].ToString());
            listBox1.Items.Add(valCats[0].ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Получаем массив строк, содержащих все цвета в системе
            string[] allcolors =
            Enum.GetNames(typeof(System.Drawing.KnownColor));
            listBox1.Items.Clear();
            // Выводим все имена в список
            listBox1.Items.AddRange(allcolors);
            // Другой вариант
            //foreach (string s in allcolors)
            //{
            // listBox1.Items.Add(s);
            //}
        }

       
    }
}
