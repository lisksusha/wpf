namespace WF12
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рисунокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.котикN1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рисунокN2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рисунокN3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рисунокN4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.рисунокToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // рисунокToolStripMenuItem
            // 
            this.рисунокToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.котикN1ToolStripMenuItem,
            this.рисунокN2ToolStripMenuItem,
            this.рисунокN3ToolStripMenuItem,
            this.рисунокN4ToolStripMenuItem});
            this.рисунокToolStripMenuItem.Name = "рисунокToolStripMenuItem";
            this.рисунокToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.рисунокToolStripMenuItem.Text = "Рисунок";
            // 
            // котикN1ToolStripMenuItem
            // 
            this.котикN1ToolStripMenuItem.Name = "котикN1ToolStripMenuItem";
            this.котикN1ToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.котикN1ToolStripMenuItem.Text = "Рисунок N1";
            // 
            // рисунокN2ToolStripMenuItem
            // 
            this.рисунокN2ToolStripMenuItem.Name = "рисунокN2ToolStripMenuItem";
            this.рисунокN2ToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.рисунокN2ToolStripMenuItem.Text = "Рисунок N2";
            // 
            // рисунокN3ToolStripMenuItem
            // 
            this.рисунокN3ToolStripMenuItem.Name = "рисунокN3ToolStripMenuItem";
            this.рисунокN3ToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.рисунокN3ToolStripMenuItem.Text = "Рисунок N3";
            // 
            // рисунокN4ToolStripMenuItem
            // 
            this.рисунокN4ToolStripMenuItem.Name = "рисунокN4ToolStripMenuItem";
            this.рисунокN4ToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.рисунокN4ToolStripMenuItem.Text = "Рисунок N4";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WF12.Properties.Resources.kot_kashlyaet_mem;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 426);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рисунокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem котикN1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рисунокN2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рисунокN3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рисунокN4ToolStripMenuItem;
        public System.Windows.Forms.PictureBox pictureBox1;
    }
}

