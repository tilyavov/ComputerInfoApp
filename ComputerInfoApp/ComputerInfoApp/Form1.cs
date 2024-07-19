using System;
using System.Management;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;

namespace ComputerInfoApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetSystemInfo();
        }

        private void GetSystemInfo()
        {
            labelComputerName.Text += Environment.MachineName;
            labelUserName.Text += Environment.UserName;
            labelOSVersion.Text += Environment.OSVersion;

            // Processor Info
            string cpuInfo = ""; // Метод создает объект ManagementObjectSearcher с запросом для получения информации обо всех процессорах в системе.
                                 //Он перебирает результаты запроса и добавляет имя каждого процессора в строку cpuInfo.
            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from Win32_Processor")) 
            {
                foreach (ManagementObject obj in searcher.Get())
                {
                    cpuInfo += obj["Name"] + " ";
                }
            }
            labelProcessorInfo.Text += cpuInfo;

            // Memory Info
            string memoryInfo = "";
            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from Win32_PhysicalMemory"))
            {
                foreach (ManagementObject obj in searcher.Get())
                {
                    memoryInfo += Math.Round(Convert.ToDouble(obj["Capacity"]) / 1024 / 1024 / 1024, 2) + " GB ";
                }
            }
            labelMemoryInfo.Text += memoryInfo;

            // Disk Info
            string diskInfo = "";
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                if (drive.IsReady)
                {
                    diskInfo += drive.Name + " - " + Math.Round((double)drive.TotalSize / 1024 / 1024 / 1024, 2) + " GB ";
                }
            }
            labelDiskInfo.Text += diskInfo;
        }

        private void buttonChangeUserName_Click(object sender, EventArgs e)
        {
            string newUserName = textBoxNewUserName.Text; // получает новое имя пользователя    
            if (!string.IsNullOrEmpty(newUserName))
            {
                try
                {
                    RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Explorer", true); // Открытие ключа реестра:
                    key.SetValue("Logon User Name", newUserName);
                    MessageBox.Show("Имя пользователя изменено. Пожалуйста, перезагрузите компьютер для применения изменений.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex) // Обработка исключения
                {
                    MessageBox.Show("Ошибка при изменении имени пользователя: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonChangeFont_Click(object sender, EventArgs e)
        {
            try
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Control Panel\Desktop", true); // Открытие ключа реестра:
                key.SetValue("LogPixels", 120);
                MessageBox.Show("Размер шрифта изменен. Пожалуйста, перезагрузите компьютер для применения изменений.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при изменении размера шрифта: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonChangeWallpaper_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog(); // Создание объек
            openFileDialog.Filter = "Изображения|*.bmp;*.jpg;*.jpeg;*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string wallpaperPath = openFileDialog.FileName;
                SetWallpaper(wallpaperPath);
            }
        }
        // Установка изображение в качестве обоев рабочего стола. 
        [DllImport("user32.dll", CharSet = CharSet.Auto)] // используется атрибут DllImport для импорта функции SystemParametersInfo из библиотеки Win32
        private static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);

        private void SetWallpaper(string path)
        {
            const int SPI_SETDESKWALLPAPER = 20; // константа, указывающая действие по установке обоев рабочего стола.
            const int SPIF_UPDATEINIFILE = 0x01; // константа, указывающая, что необходимо обновить файл инициализации системы (INI-файл).
            const int SPIF_SENDCHANGE = 0x02; //  константа, указывающая, что необходимо отправить широковещательное сообщение всем окнам, чтобы они обновили свои фоновые рисунки.

            try
            {
                SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, path, SPIF_UPDATEINIFILE | SPIF_SENDCHANGE); //SystemParametersInfo принимает Аргументы для установки обоя
                MessageBox.Show("Фон рабочего стола изменен.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при изменении фона рабочего стола: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
