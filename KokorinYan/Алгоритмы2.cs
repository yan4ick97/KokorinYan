using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;



namespace KokorinYan
{

    
    public partial class Алгоритмы2 : Form
    {
        public Алгоритмы2()
        {
            InitializeComponent();
            ComboBox cboNotDrop = new ComboBox();
            cboNotDrop.Parent = this;
            cboNotDrop.Width = 140;
            cboNotDrop.Height = 60;
            cboNotDrop.Items.Add("One");
            cboNotDrop.Items.Add("Two");
            // ... и так далее
            RichTextBox rboxex = new RichTextBox();
            rboxex.Parent = this;
            rboxex.Top = 400;




        }


        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string className, string windowName);

        [DllImport("User32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr SendMessage(IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam);

        [DllImport("User32.dll")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("User32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool PostMessage(IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam);

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            listBox1.TopIndex = listBox1.Items.Count - 1;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            // Подгоняем ширину списка под самый длинный текст 
            Graphics g = listBox1.CreateGraphics();
            float maxWidth = 0f;
            float height = 0f;
            for (int i = 0; i < listBox1.Items.Count; ++i)
            {
                float w = g.MeasureString(listBox1.Items[i].ToString(),
                listBox1.Font).Width;
                if (w > maxWidth)
                    maxWidth = w;
                height += listBox1.GetItemHeight(i);
            }
            g.Dispose();
            listBox1.Width = (int)(maxWidth + 8 + ((height > listBox1.Height - 4) ?
             16 : 0)); // 16 - ширина прокрутки 
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            //Извлекаем имя перетаскиваемого файла 
            string[] astrings = (string[])e.Data.GetData(DataFormats.FileDrop, true);

            foreach (string strfile in astrings)
            {
                // только имя файла 
                listBox1.Items.Add(strfile.Substring(1 +
                strfile.LastIndexOf(@"\")));
                // или полный путь к файлу 
                listBox1.Items.Add(strfile);
            }
        }

        private void listBox1_DragEnter(object sender, DragEventArgs e)
        {
            // Разрешаем Drop только файлам 
            e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop) ?
            DragDropEffects.All : DragDropEffects.None;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("One");
            listBox1.Items.Add("Two");
            listBox1.Items.Add("Three");
            listBox1.Items.Add(Color.Red.Name);
            listBox1.Items.Add(Color.Yellow.Name);
            listBox1.Items.Add(Color.Green.Name);
            listBox1.Items.Add(Color.Blue.Name);
        }

        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            if ((e.State & DrawItemState.Selected) != 0)
                e.Graphics.FillRectangle(SystemBrushes.Highlight, e.Bounds);
            else
                e.Graphics.FillRectangle(Brushes.White, e.Bounds);
            string itemText = listBox1.Items[e.Index].ToString();
            Color color = Color.FromName(itemText);
            //Рисуем строку 
            e.Graphics.DrawString(itemText, Font, new SolidBrush(color),
            e.Bounds);
            Pen pen = new Pen(color);

            //Рисуем линию под строкой 
            e.Graphics.DrawLine(pen, e.Bounds.X, e.Bounds.Bottom - 1,
            e.Bounds.Right, e.Bounds.Bottom - 1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Graphics g = comboBox1.CreateGraphics();
            float maxWidth = 0f;
            foreach (object o in comboBox1.Items)
            {
                float w = g.MeasureString(o.ToString(), comboBox1.Font).Width;
                if (w > maxWidth)
                    maxWidth = w;
            }
            g.Dispose();
            // 28 - учитываем ширину кнопки в поле со списком 
            comboBox1.Width = (int)maxWidth + 28;
        }
        protected override void WndProc(ref System.Windows.Forms.Message m)
        {
            // константы для левой кнопки мыши 
            const int WM_LBUTTONDOWN = 0x201;
            const int WM_LBUTTONDBLCLK = 0x203;
            if (m.Msg == WM_LBUTTONDOWN || m.Msg == WM_LBUTTONDBLCLK)
                return;
            base.WndProc(ref m);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            ComboBox cboNotDrop = new ComboBox();
            cboNotDrop.Parent = this;
            cboNotDrop.Width = 140;
            cboNotDrop.Height = 60;
            cboNotDrop.Items.Add("One");
            cboNotDrop.Items.Add("Two");
            // ... и так далее 
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.DroppedDown = true;
            comboBox1.Font = new Font("Arial", 16);


        }

        private void button7_Click(object sender, EventArgs e)
        {
            comboBox1.Font = new Font("Arial", 16);
        }
        const int CB_SETITEMHEIGHT = 0x0153;
        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hWnd,
        UInt32 Msg, Int32 wParam, UInt32 lParam);

        private void button8_Click(object sender, EventArgs e)
        {
            SendMessage(comboBox1.Handle, CB_SETITEMHEIGHT, -1, 40);
        }





        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Алгоритмы2_Load(object sender, EventArgs e)
        {

            txtLinesCount.Multiline = true;
            txtLinesCount.WordWrap = true;
            txtLinesCount.Height = 98;
            txtLinesCount.Text += "У Лукоморья дуб зеленый; ";
            txtLinesCount.Text += "Златая цепь на дубе том: ";
            txtLinesCount.Text += "И днем и ночью кот ученый ";
            linkLabel1.Text = "Yandex Google Rambler GoGo";
            linkLabel1.LinkBehavior = LinkBehavior.HoverUnderline;
            linkLabel1.Links.Add(0, 6, "www.yandex.ru");
            linkLabel1.Links.Add(7, 6, "www.google.ru");
            linkLabel1.Links.Add(14, 7, "www.rambler.ru");
            linkLabel1.Links.Add(22, 4, "www.gogo.ru");
            linkLabel1.LinkClicked +=
            new LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
        }

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
        UInt32 Msg, UInt32 wParam, UInt32 lParam);
        const int EM_GETLINECOUNT = 0x00BA;
        private void button9_Click(object sender, EventArgs e)
        {

            int LineCount;
            LineCount =
            listBox1.Items.Add("Число строк");


        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13 || e.KeyChar == 'Б')
                e.Handled = true;
            if (!Char.IsDigit(e.KeyChar))
                e.Handled = true;
            // по шаблону разрешаем вводить в поле цифры, знаки плюс, минус и запятую 
            string pattern = "0123456789+-,";
            if (!Char.IsControl(e.KeyChar))
                if (pattern.IndexOf(e.KeyChar.ToString()) < 0)
                    e.Handled = true;
            if (e.KeyChar == (char)13)
                e.Handled = true;
            else
                base.OnKeyPress(e);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string[] strWeekDay = { "Понедельник", "Вторник", "Среда" };
            txtLinesCount.Multiline = true;
            txtLinesCount.Lines = strWeekDay;

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            // Используем escape-последовательности для переноса текста 
            // на новую строку 
            txtLinesCount.Text = "Раз\r\nДва\r\nТри";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            // Используем свойство NewLine для переноса строк 
            txtLinesCount.Text = "Месяцы года:" + Environment.NewLine + "Декабрь" +
             Environment.NewLine + "Январь...";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            // Все вводимые символы переводятся в верхний регистр 
            this.textBox1.CharacterCasing =
             System.Windows.Forms.CharacterCasing.Upper;
        }

        private void listBox1_DragDrop_1(object sender, DragEventArgs e)
        {
            //Извлекаем имя перетаскиваемого файла 
            string[] astrings = (string[])e.Data.GetData(DataFormats.FileDrop,
            true);

            foreach (string strfile in astrings)
            {
                // только имя файла 
                listBox1.Items.Add(strfile.Substring(1 +
                strfile.LastIndexOf(@"\")));
                // или полный путь к файлу 
                listBox1.Items.Add(strfile);
            }
        }

        private void listBox1_DragEnter_1(object sender, DragEventArgs e)
        {
            // Разрешаем Drop только файлам 
            e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop) ?
            DragDropEffects.All : DragDropEffects.None;
        }

        private void button15_Click(object sender, EventArgs e)
        {

        }


        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.SelectionStart = 0;
            textBox1.SelectionLength = textBox1.Text.Length;
        }

        private void txtLinesCount_Enter(object sender, EventArgs e)
        {
            textBox1.SelectionStart = 1;
            textBox1.SelectionLength = textBox1.Text.Length;
        }

        private void txtLinesCount_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Rtf;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            // Устанавливаем фокус на richTextBox 
            richTextBox1.Focus();
            // Устанавливаем цвет для выделенного текста 
            richTextBox1.SelectionColor = Color.Red;
            // Устанавливаем шрифт 
            richTextBox1.SelectionFont = new Font("Courier", 10, FontStyle.Bold);
        }

        private void richTextBox1_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        [DllImport("User32.dll")]
        static extern int GetWindowLong(IntPtr hWnd, int nIndex);
        const int GWL_STYLE = -16;
        const int WS_HSCROLL = 0x00100000;
        const int WS_VSCROLL = 0x00200000;
        bool IsVertScrollPresent(Control control)
        {
            int style = GetWindowLong(control.Handle, GWL_STYLE);
            return (style & WS_VSCROLL) > 0;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Вертикальная прокрутка: " +
         IsVertScrollPresent(richTextBox1).ToString() +
         Environment.NewLine + "Горизонтальная прокрутка: " +
         IsVertScrollPresent(richTextBox1).ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = " ";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            // Устанавливаем фокус 
            dateTimePicker1.Focus();
            // Посылаем команду 
            SendKeys.Send("{F4}");
        }

        private void button21_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.FromArgb(255, 255, 192, 192);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {
            linkLabel1.Text = "На нашем сайте вы найдете дополнительную информацию";
            linkLabel1.LinkArea = new LinkArea(0, 60);
        }

         

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://rusproject.narod.ru/");
            LinkLabel lnk = new LinkLabel();
            lnk = (LinkLabel)sender;
            lnk.Links[lnk.Links.IndexOf(e.Link)].Visited = true;
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }

        private void Алгоритмы2_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
                Hide();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if ( Visible)
                 Visible = false;
            else
                 Visible = true;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            this.timer1.Stop();
            notifyIcon1.Visible = true;
            MessageBox.Show("Мигание приостановлено");
        }

        private void Алгоритмы2_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void button24_Click(object sender, EventArgs e)
        {

        }

        private void button25_Click(object sender, EventArgs e)
        {
            this.listView1.SelectedItems.Clear();
            // Установим фокус 
            listView1.Focus();
            // Выбираем второй элемент 
            listView1.Items[1].Selected = true;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            // Установим фокус 
            listView1.Items.Add("Я");
            listView1.Focus();
            // Выбираем второй элемент 
            listView1.Items[0].Selected = true;
        }

        private void button27_Click(object sender, EventArgs e)
        {

        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
