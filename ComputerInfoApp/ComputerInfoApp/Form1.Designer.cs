namespace ComputerInfoApp
{
    partial class Form1
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
            this.labelComputerName = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelOSVersion = new System.Windows.Forms.Label();
            this.labelProcessorInfo = new System.Windows.Forms.Label();
            this.labelMemoryInfo = new System.Windows.Forms.Label();
            this.labelDiskInfo = new System.Windows.Forms.Label();
            this.textBoxNewUserName = new System.Windows.Forms.TextBox();
            this.buttonChangeUserName = new System.Windows.Forms.Button();
            this.buttonChangeFont = new System.Windows.Forms.Button();
            this.buttonChangeWallpaper = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelComputerName
            // 
            this.labelComputerName.AutoSize = true;
            this.labelComputerName.Location = new System.Drawing.Point(12, 9);
            this.labelComputerName.Name = "labelComputerName";
            this.labelComputerName.Size = new System.Drawing.Size(122, 13);
            this.labelComputerName.TabIndex = 0;
            this.labelComputerName.Text = "Имя компьютера: ";
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(12, 32);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(114, 13);
            this.labelUserName.TabIndex = 1;
            this.labelUserName.Text = "Имя пользователя: ";
            // 
            // labelOSVersion
            // 
            this.labelOSVersion.AutoSize = true;
            this.labelOSVersion.Location = new System.Drawing.Point(12, 55);
            this.labelOSVersion.Name = "labelOSVersion";
            this.labelOSVersion.Size = new System.Drawing.Size(95, 13);
            this.labelOSVersion.TabIndex = 2;
            this.labelOSVersion.Text = "Версия ОС: ";
            // 
            // labelProcessorInfo
            // 
            this.labelProcessorInfo.AutoSize = true;
            this.labelProcessorInfo.Location = new System.Drawing.Point(12, 78);
            this.labelProcessorInfo.Name = "labelProcessorInfo";
            this.labelProcessorInfo.Size = new System.Drawing.Size(83, 13);
            this.labelProcessorInfo.TabIndex = 3;
            this.labelProcessorInfo.Text = "Процессор: ";
            // 
            // labelMemoryInfo
            // 
            this.labelMemoryInfo.AutoSize = true;
            this.labelMemoryInfo.Location = new System.Drawing.Point(12, 101);
            this.labelMemoryInfo.Name = "labelMemoryInfo";
            this.labelMemoryInfo.Size = new System.Drawing.Size(57, 13);
            this.labelMemoryInfo.TabIndex = 4;
            this.labelMemoryInfo.Text = "Память: ";
            // 
            // labelDiskInfo
            // 
            this.labelDiskInfo.AutoSize = true;
            this.labelDiskInfo.Location = new System.Drawing.Point(12, 124);
            this.labelDiskInfo.Name = "labelDiskInfo";
            this.labelDiskInfo.Size = new System.Drawing.Size(57, 13);
            this.labelDiskInfo.TabIndex = 5;
            this.labelDiskInfo.Text = "Диски: ";
            // 
            // textBoxNewUserName
            // 
            this.textBoxNewUserName.Location = new System.Drawing.Point(15, 150);
            this.textBoxNewUserName.Name = "textBoxNewUserName";
            this.textBoxNewUserName.Size = new System.Drawing.Size(100, 20);
            this.textBoxNewUserName.TabIndex = 6;
            // 
            // buttonChangeUserName
            // 
            this.buttonChangeUserName.Location = new System.Drawing.Point(121, 148);
            this.buttonChangeUserName.Name = "buttonChangeUserName";
            this.buttonChangeUserName.Size = new System.Drawing.Size(151, 23);
            this.buttonChangeUserName.TabIndex = 7;
            this.buttonChangeUserName.Text = "Изменить имя пользователя";
            this.buttonChangeUserName.UseVisualStyleBackColor = true;
            this.buttonChangeUserName.Click += new System.EventHandler(this.buttonChangeUserName_Click);
            // 
            // buttonChangeFont
            // 
            this.buttonChangeFont.Location = new System.Drawing.Point(15, 176);
            this.buttonChangeFont.Name = "buttonChangeFont";
            this.buttonChangeFont.Size = new System.Drawing.Size(257, 23);
            this.buttonChangeFont.TabIndex = 8;
            this.buttonChangeFont.Text = "Изменить размер шрифта рабочего стола";
            this.buttonChangeFont.UseVisualStyleBackColor = true;
            this.buttonChangeFont.Click += new System.EventHandler(this.buttonChangeFont_Click);
            // 
            // buttonChangeWallpaper
            // 
            this.buttonChangeWallpaper.Location = new System.Drawing.Point(15, 205);
            this.buttonChangeWallpaper.Name = "buttonChangeWallpaper";
            this.buttonChangeWallpaper.Size = new System.Drawing.Size(257, 23);
            this.buttonChangeWallpaper.TabIndex = 9;
            this.buttonChangeWallpaper.Text = "Изменить фон рабочего стола";
            this.buttonChangeWallpaper.UseVisualStyleBackColor = true;
            this.buttonChangeWallpaper.Click += new System.EventHandler(this.buttonChangeWallpaper_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 241);
            this.Controls.Add(this.buttonChangeWallpaper);
            this.Controls.Add(this.buttonChangeFont);
            this.Controls.Add(this.buttonChangeUserName);
            this.Controls.Add(this.textBoxNewUserName);
            this.Controls.Add(this.labelDiskInfo);
            this.Controls.Add(this.labelMemoryInfo);
            this.Controls.Add(this.labelProcessorInfo);
            this.Controls.Add(this.labelOSVersion);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.labelComputerName);
            this.Name = "Form1";
            this.Text = "Информация о компьютере";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelComputerName;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelOSVersion;
        private System.Windows.Forms.Label labelProcessorInfo;
        private System.Windows.Forms.Label labelMemoryInfo;
        private System.Windows.Forms.Label labelDiskInfo;
        private System.Windows.Forms.TextBox textBoxNewUserName;
        private System.Windows.Forms.Button buttonChangeUserName;
        private System.Windows.Forms.Button buttonChangeFont;
        private System.Windows.Forms.Button buttonChangeWallpaper;
    }
}
