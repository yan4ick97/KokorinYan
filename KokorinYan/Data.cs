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

namespace KokorinYan
{
    public partial class Data : Form
    {
        public Data()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            listBox1.Items.Add(today.Date.ToLongDateString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            listBox1.Items.Clear();
            listBox1.Items.Add("d: " + dt.ToString("d"));
            listBox1.Items.Add("D: " + dt.ToString("D"));
            listBox1.Items.Add("f: " + dt.ToString("f"));
            listBox1.Items.Add("F: " + dt.ToString("F"));
            listBox1.Items.Add("g: " + dt.ToString("g"));
            listBox1.Items.Add("G: " + dt.ToString("G"));
            listBox1.Items.Add("m: " + dt.ToString("m"));
            listBox1.Items.Add("r: " + dt.ToString("r"));
            listBox1.Items.Add("s: " + dt.ToString("s"));
            listBox1.Items.Add("u: " + dt.ToString("u"));
            listBox1.Items.Add("U: " + dt.ToString("U"));
            listBox1.Items.Add("y: " + dt.ToString("y"));
            listBox1.Items.Add("MMMM dd: " + dt.ToString("MMMM dd"));
            listBox1.Items.Add("MM/dd/yyyy: " + dt.ToString("MM/dd/yyyy"));
            listBox1.Items.Add("MM/dd/yyyy HH:mm: " +
dt.ToString("MM/dd/yyyy HH:mm"));
            listBox1.Items.Add("MM/dd/yyyy hh:mm tt: " +
            dt.ToString("MM/dd/yyyy hh:mm tt"));
            listBox1.Items.Add("MM/dd/yyyy H:mm: " +
            dt.ToString("MM/dd/yyyy H:mm"));
            listBox1.Items.Add("MM/dd/yyyy h:mm tt: " +
            dt.ToString("MM/dd/yyyy h:mm tt"));
            listBox1.Items.Add("MM/dd/yyyy HH:mm:ss: " +
            dt.ToString("MM/dd/yyyy HH:mm:ss"));

            listBox1.Items.Add("dddd, dd MMMM yyyy: " +
            dt.ToString("dddd, dd MMMM yyyy"));
            listBox1.Items.Add("dddd, dd MMMM yyyy HH:mm:ss: " +
            dt.ToString("dddd, dd MMMM yyyy HH:mm:ss"));
            listBox1.Items.Add("ddd, dd MMM yyyy HH':'mm':'ss 'GMT': " +
            dt.ToString("ddd, dd MMM yyyy HH':'mm':'ss 'GMT'"));
            listBox1.Items.Add("yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK: " +
                        dt.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK"));
            listBox1.Items.Add("yyyy'-'MM'-'dd'T'HH':'mm':'ss: " +
            dt.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss"));
            listBox1.Items.Add("yyyy MMMM: " + dt.ToString("yyyy MMMM"));
            listBox1.Items.Add("H:mm: " + dt.ToString("H:mm"));
            listBox1.Items.Add("HH:mm: " + dt.ToString("HH:mm"));
            listBox1.Items.Add("HH:mm:ss: " + dt.ToString("HH:mm:ss"));
            listBox1.Items.Add("h:mm tt: " + dt.ToString("h:mm tt"));
            listBox1.Items.Add("hh:mm tt: " + dt.ToString("hh:mm tt"));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            DateTime curdate = DateTime.Now;
            // Прибавляем семь дней к текущей дате
            DateTime mydate = curdate.AddDays(7);
            listBox1.Items.Add(mydate.ToShortDateString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool leapYear = DateTime.IsLeapYear(DateTime.Now.Year);
            listBox1.Items.Add(
             String.Format("{0} является високосным годом: {1}",
             DateTime.Now.Year, leapYear));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Измеряем производительность для UtsNow 
            DateTime dt = DateTime.UtcNow;
            Stopwatch sw = new Stopwatch();
            for (int i = 0; i < 10; i++)
            {
                sw.Start();
                for (int j = 0; j < 100000; j++)
                {
                    if (DateTime.UtcNow == dt)
                    {
                        /* do action */
                        
                    }
                }
                MessageBox.Show(sw.ElapsedTicks.ToString());
            }
            
            
        }

        public static int DaysDiff(DateTime date1, DateTime date2)
        {
            return date1.Subtract(date2.Date).Days;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int year = Convert.ToInt32(textBox1.Text);
            int month = Convert.ToInt32(textBox2.Text);
            int day = Convert.ToInt32(textBox3.Text);
            
            string howdays = DaysDiff(DateTime.Today, new DateTime(year, month, day)).ToString();

            listBox1.Items.Add("Со дня моего дня рождения прошло: " + howdays+"дней");
        }

        private void Data_Load(object sender, EventArgs e)
        {

        }
    }
}
