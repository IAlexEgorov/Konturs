namespace Program
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.яркостьконтрастностьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цветовойБалансToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.повыситьРезкостьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.размытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.приветToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.превиттToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.собельToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.собельСтандартныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.щаррToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.робертсToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кэнниToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сбросToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(16, 33);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(685, 424);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.сбросToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(714, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(59, 24);
            this.toolStripMenuItem1.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.открытьToolStripMenuItem.Text = "Открыть...";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как...";
            this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.сохранитьКакToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.яркостьконтрастностьToolStripMenuItem,
            this.цветовойБалансToolStripMenuItem,
            this.повыситьРезкостьToolStripMenuItem,
            this.размытьToolStripMenuItem,
            this.приветToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(85, 24);
            this.toolStripMenuItem2.Text = "Фильтры";
            // 
            // яркостьконтрастностьToolStripMenuItem
            // 
            this.яркостьконтрастностьToolStripMenuItem.Name = "яркостьконтрастностьToolStripMenuItem";
            this.яркостьконтрастностьToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.яркостьконтрастностьToolStripMenuItem.Text = "Яркость/контрастность";
            this.яркостьконтрастностьToolStripMenuItem.Click += new System.EventHandler(this.яркостьконтрастностьToolStripMenuItem_Click);
            // 
            // цветовойБалансToolStripMenuItem
            // 
            this.цветовойБалансToolStripMenuItem.Name = "цветовойБалансToolStripMenuItem";
            this.цветовойБалансToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.цветовойБалансToolStripMenuItem.Text = "Цветовой баланс";
            this.цветовойБалансToolStripMenuItem.Click += new System.EventHandler(this.цветовойБалансToolStripMenuItem_Click);
            // 
            // повыситьРезкостьToolStripMenuItem
            // 
            this.повыситьРезкостьToolStripMenuItem.Name = "повыситьРезкостьToolStripMenuItem";
            this.повыситьРезкостьToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.повыситьРезкостьToolStripMenuItem.Text = "Повысить резкость";
            this.повыситьРезкостьToolStripMenuItem.Click += new System.EventHandler(this.повыситьРезкостьToolStripMenuItem_Click);
            // 
            // размытьToolStripMenuItem
            // 
            this.размытьToolStripMenuItem.Name = "размытьToolStripMenuItem";
            this.размытьToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.размытьToolStripMenuItem.Text = "Размыть";
            this.размытьToolStripMenuItem.Click += new System.EventHandler(this.размытьToolStripMenuItem_Click);
            // 
            // приветToolStripMenuItem
            // 
            this.приветToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.превиттToolStripMenuItem,
            this.собельToolStripMenuItem,
            this.робертсToolStripMenuItem,
            this.кэнниToolStripMenuItem});
            this.приветToolStripMenuItem.Name = "приветToolStripMenuItem";
            this.приветToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.приветToolStripMenuItem.Text = "Выделение контуров";
            // 
            // превиттToolStripMenuItem
            // 
            this.превиттToolStripMenuItem.Name = "превиттToolStripMenuItem";
            this.превиттToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.превиттToolStripMenuItem.Text = "Превитт";
            this.превиттToolStripMenuItem.Click += new System.EventHandler(this.ПревиттToolStripMenuItem_Click);
            // 
            // собельToolStripMenuItem
            // 
            this.собельToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.собельСтандартныйToolStripMenuItem,
            this.щаррToolStripMenuItem});
            this.собельToolStripMenuItem.Name = "собельToolStripMenuItem";
            this.собельToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.собельToolStripMenuItem.Text = "Собель";
            // 
            // собельСтандартныйToolStripMenuItem
            // 
            this.собельСтандартныйToolStripMenuItem.Name = "собельСтандартныйToolStripMenuItem";
            this.собельСтандартныйToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.собельСтандартныйToolStripMenuItem.Text = "Оператор Собеля";
            this.собельСтандартныйToolStripMenuItem.Click += new System.EventHandler(this.СобельToolStripMenuItem_Click);
            // 
            // щаррToolStripMenuItem
            // 
            this.щаррToolStripMenuItem.Name = "щаррToolStripMenuItem";
            this.щаррToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.щаррToolStripMenuItem.Text = "Оператор Щарра";
            this.щаррToolStripMenuItem.Click += new System.EventHandler(this.ЩаррToolStripMenuItem_Click);
            // 
            // робертсToolStripMenuItem
            // 
            this.робертсToolStripMenuItem.Name = "робертсToolStripMenuItem";
            this.робертсToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.робертсToolStripMenuItem.Text = "Робертс";
            this.робертсToolStripMenuItem.Click += new System.EventHandler(this.РобертсToolStripMenuItem_Click);
            // 
            // кэнниToolStripMenuItem
            // 
            this.кэнниToolStripMenuItem.Name = "кэнниToolStripMenuItem";
            this.кэнниToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.кэнниToolStripMenuItem.Text = "Кэнни";
            // 
            // сбросToolStripMenuItem
            // 
            this.сбросToolStripMenuItem.Name = "сбросToolStripMenuItem";
            this.сбросToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.сбросToolStripMenuItem.Text = "Сброс";
            this.сбросToolStripMenuItem.Click += new System.EventHandler(this.сбросToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 470);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Фильтрация изображений";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem яркостьконтрастностьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem цветовойБалансToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem повыситьРезкостьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem размытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem приветToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem превиттToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem собельToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem робертсToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сбросToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem собельСтандартныйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem щаррToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кэнниToolStripMenuItem;
    }
}

