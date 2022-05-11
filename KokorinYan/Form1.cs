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
using Microsoft.Win32;

namespace KokorinYan
{
    public partial class Form1 : Form
    {
        protected Process[] procs;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           
                string appPath = Application.ExecutablePath;
                // Выводим полный путь к файлу 
                listBox1.Items.Add(appPath);
     
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath;
            listBox1.Items.Add(path);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process proc = new Process();
            proc.StartInfo.FileName = "Notepad.exe";
            proc.StartInfo.Arguments = "";
            proc.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Запускаем Блокнот с файлом test.txt 
            Process.Start("notepad.exe", "test.txt");
            // Запускаем браузер с заданным адресом 
            Process.Start("iexplore.exe", "netsources.narod.ru");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            procs = Process.GetProcessesByName("Notepad");
            int i = 0;
            while (i != procs.Length)
            {
                procs[i].Kill();
                i++;
                MessageBox.Show("Всего : " + i.ToString());
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Устанавливаем информацию 
            ProcessStartInfo start_info = new ProcessStartInfo
            (@"C:\windows\system32\notepad.exe");
            start_info.UseShellExecute = false;
            start_info.CreateNoWindow = true;
            // создаем новый процесс 
            Process proc = new Process();
            proc.StartInfo = start_info;
            // Запускаем процесс 
            proc.Start();
            // Ждем, пока Блокнот запущен 
            proc.WaitForExit();
            MessageBox.Show("Код завершения: " + proc.ExitCode, "Завершение " +
            "Код", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            ProcessStartInfo pInfo = new ProcessStartInfo();
            string currentProgramFolder = Application.StartupPath;
            pInfo.FileName = currentProgramFolder + @"\eula.txt";

            Console.WriteLine(currentProgramFolder);

            pInfo.UseShellExecute = true;
            Process p = Process.Start(pInfo);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int am = Process.GetCurrentProcess().ProcessorAffinity.ToInt32();
            int processorCount = 0;
            while (am != 0)
            {
                processorCount++;
                am &= (am - 1);
            }
            listBox1.Items.Add(processorCount.ToString());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
          String.Format(
          "Число процессоров: {0}",
          Environment.ProcessorCount.ToString()));
        }

        private void button10_Click(object sender, EventArgs e)
        {
            // Делаем паузу на 3 секунды 
            System.Threading.Thread.Sleep(3000);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            foreach (Process p in Process.GetProcesses())
                listBox1.Items.Add(p.ToString());

        }

        private void button12_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (Process p in
            Process.GetProcesses(System.Environment.MachineName))
            {
                if (p.MainWindowHandle != IntPtr.Zero)
                {
                    // Оконные приложения 
                    listBox1.Items.Add(p.ToString());
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            // Очистим список 
            listBox1.Items.Clear();
            // Получим список процессов, связанных с Microsoft Edge 
            foreach (Process p in Process.GetProcessesByName("msedge"))
                listBox1.Items.Add(p.ToString());
        }

        private void button14_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            OperatingSystem os = Environment.OSVersion;
            listBox1.Items.Add(os.Version);
            listBox1.Items.Add(os.Platform);
            listBox1.Items.Add(os.ServicePack);
            listBox1.Items.Add(os.VersionString);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            OperatingSystem os = Environment.OSVersion;
            Version version = os.Version;
            if ((version.Major == 5) && (version.Minor == 1)
            || version.Major >= 6)
            {
                MessageBox.Show("Программа может запускаться" +
              " в вашей операционной системе");
            }
            else
            {
                MessageBox.Show
                ("Эта версия операционной системы не поддерживается." +
                "\r\n Используйте Windows XP или Windows Vista");
            }

        }

       

        private void button17_Click(object sender, EventArgs e)
        {
            // Определяем имя пользователя системы 
            MessageBox.Show(SystemInformation.UserName);
        }

        
    }
}
