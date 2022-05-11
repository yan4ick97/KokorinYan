﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace KokorinYan
{
    public partial class Disc : Form
    {
        private object label1;

        public Disc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] astrLogicalDrives = System.IO.Directory.GetLogicalDrives();
            foreach (string disk in astrLogicalDrives)
                listBox1.Items.Add(disk);
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            string[] astrLogicalDrives = System.Environment.GetLogicalDrives();
            foreach (string disk in astrLogicalDrives)
                listBox1.Items.Add(disk);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Выводим информацию о диске 
            System.IO.DriveInfo drv = new System.IO.DriveInfo(@"d:\");
            listBox1.Items.Clear();
            listBox1.Items.Add("Диск: " + drv.Name);

            if (drv.IsReady)
            {
                listBox1.Items.Add("Тип диска: " + drv.DriveType.ToString());
                listBox1.Items.Add("Файловая система: " +
                drv.DriveFormat.ToString());
                listBox1.Items.Add("Свободное место на диске: " +
                drv.AvailableFreeSpace.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Получим список папок на диске D: 
            listBox1.Items.Clear();
            string[] astrFolders = System.IO.Directory.GetDirectories(@"d:\");
            foreach (string folder in astrFolders)
                listBox1.Items.Add(folder);
        }

        private void Disc_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Получим список папок, где встречается буквосочетание pro 
            listBox1.Items.Clear();
            System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(@"d:\");
            System.IO.DirectoryInfo[] folders = di.GetDirectories("*pro*");
            foreach (System.IO.DirectoryInfo maskdirs in folders)
                listBox1.Items.Add(maskdirs);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (System.IO.Directory.Exists(@"C:\windows"))
                listBox1.Items.Add("Папка " + @"C:\Windows" + " существует");
            else
                listBox1.Items.Add("Папка не существует");
        }
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                // Попытаемся создание папку C:\MyFolder
                System.IO.Directory.CreateDirectory(@"c:\MyFolder");
                listBox1.Items.Add("Папка создана.");


            }
            finally { }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Переименовываем папку MyFolder в папку NewFolder 
            string oldPathString = @"C:\MyFolder";
            string newPathString = @"C:\NewFolder";
            Directory.Move(oldPathString, newPathString);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                // Попытаемся удалить папку C:\WUTEMP 
                System.IO.Directory.Delete(@"c:\wutemp");
                listBox1.Items.Add("Папка удалена.");
            }
            catch (Exception)
            {
                listBox1.Items.Add("Нельзя удалить непустую папку.");
            }
            finally { }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            // задаем папку верхнего уровня 
            fbd.RootFolder = Environment.SpecialFolder.MyComputer;
            // Заголовок в диалоговом окне 
            fbd.Description = "Выберите папку";
            // Не выводим кнопку Новая папка 
            fbd.ShowNewFolderButton = false;
            // Получаем папку, выбранную пользователем 
            if (fbd.ShowDialog() == DialogResult.OK)
                this.Text = fbd.SelectedPath;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(Environment.GetFolderPath(
         Environment.SpecialFolder.Personal));
        }

        private void button11_Click(object sender, EventArgs e)
        {
            System.IO.DirectoryInfo dir = new
            System.IO.DirectoryInfo(@"c:\wutemp");
            listBox1.Items.Clear();
            listBox1.Items.Add("Проверка папки: " + dir.Name);
            listBox1.Items.Add("Родительская папка: " + dir.Parent.Name);
            listBox1.Items.Add("Папка существует: ");
            listBox1.Items.Add(dir.Exists.ToString());
            if (dir.Exists)
            {
                listBox1.Items.Add("Папка создана: ");
                listBox1.Items.Add(dir.CreationTime.ToString());
                listBox1.Items.Add("Папка изменена: ");
                listBox1.Items.Add(dir.LastWriteTime.ToString());
                listBox1.Items.Add("Время последнего доступа: ");
                listBox1.Items.Add(dir.LastAccessTime.ToString());
                listBox1.Items.Add("Атрибуты папки: ");
                listBox1.Items.Add(dir.Attributes.ToString());
                listBox1.Items.Add("Папка содержит: " +
                dir.GetFiles().Length.ToString() + " файла");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string[] astrFiles = System.IO.Directory.GetFiles(@"c:\");
            listBox1.Items.Add("Всего файлов: " + astrFiles.Length);
            foreach (string file in astrFiles)
                listBox1.Items.Add(file);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string[] directoryEntries =
 System.IO.Directory.GetFileSystemEntries(@"c:\windows");
            foreach (string str in directoryEntries)
            {
                listBox1.Items.Add(str);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string[] astrFiles = System.IO.Directory.GetFiles(@"c:\", "*.in?");
            listBox1.Items.Add("Всего файлов: " + astrFiles.Length);
            foreach (string file in astrFiles)
                listBox1.Items.Add(file);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (System.IO.File.Exists(Application.StartupPath + "\\test.txt"))
                listBox1.Items.Add ("Файл test.txt существует");
            else
                listBox1.Items.Add( "Файл test.txt не существует");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            // Полный путь к файлу 
            string fileNamePath = @"c:\windows\system32\notepad.exe";
            // Имя файла с расширением 
            listBox1.Items.Add(System.IO.Path.GetFileName(fileNamePath));
            // Имя файла без расширения 
            listBox1.Items.Add(
            System.IO.Path.GetFileNameWithoutExtension(fileNamePath));
        }

        private void button17_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            // Полный путь к файлу 
            string fileNamePath = @"c:\windows\system32\notepad.exe";
            // Получим расширение файла 
            listBox1.Items.Add(System.IO.Path.GetExtension(fileNamePath));

        }

        private void button18_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            // путь к тестовому файлу 
            string path = @"c:\WUTEMP\test2.txt";
            // если файлы имел атрибут Скрытый 
            if ((System.IO.File.GetAttributes(path) &
            System.IO.FileAttributes.Hidden)
            == System.IO.FileAttributes.Hidden)
            {
                // то устанавливаем атрибут Normal 
                System.IO.File.SetAttributes(path,
                System.IO.FileAttributes.Normal);
                MessageBox.Show("Файл больше не является скрытым", path);
            }
            else // если файл не был скрытым 
            {
                // то устанавливаем у файла атрибут Скрытый 
                System.IO.File.SetAttributes(path,
                System.IO.File.GetAttributes(path) |
                System.IO.FileAttributes.Hidden);
                MessageBox.Show("Файл стал скрытым", path);
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            // Выводим информацию о файле. 
            System.IO.FileInfo file = new
            System.IO.FileInfo(@"c:\wutemp\test2.txt");
            listBox1.Items.Clear();
            listBox1.Items.Add("Свойства для файла: " + file.Name);
            listBox1.Items.Add("Наличие файла: " + file.Exists.ToString());
            if (file.Exists)
            {
                listBox1.Items.Add("Время создания файла: ");
                listBox1.Items.Add(file.CreationTime.ToString());
                listBox1.Items.Add("Последнее изменение файла: ");
                listBox1.Items.Add(file.LastWriteTime.ToString());
                listBox1.Items.Add("Файл был открыт в последний раз: ");
                listBox1.Items.Add(file.LastAccessTime.ToString());
                listBox1.Items.Add("Размер файла (в байтах): ");
                listBox1.Items.Add(file.Length.ToString());
                listBox1.Items.Add("Атрибуты файла: ");
                listBox1.Items.Add(file.Attributes.ToString());
            }
        }
    }
    
}            