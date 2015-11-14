namespace Курсовая_БД_ООП
{
    partial class MainForm
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
            this.button_Analyze = new System.Windows.Forms.Button();
            this.button_Sort = new System.Windows.Forms.Button();
            this.button_SetCoef = new System.Windows.Forms.Button();
            this.button_Code = new System.Windows.Forms.Button();
            this.radioButton_Compress = new System.Windows.Forms.RadioButton();
            this.radioButton_MoveDown = new System.Windows.Forms.RadioButton();
            this.radioButton_MoveUp = new System.Windows.Forms.RadioButton();
            this.radioButton_Widening = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.данныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изФайлаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изБазыДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Analyze
            // 
            this.button_Analyze.Location = new System.Drawing.Point(31, 29);
            this.button_Analyze.Name = "button_Analyze";
            this.button_Analyze.Size = new System.Drawing.Size(173, 50);
            this.button_Analyze.TabIndex = 0;
            this.button_Analyze.Text = "Анализировать";
            this.button_Analyze.UseVisualStyleBackColor = true;
            this.button_Analyze.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_Sort
            // 
            this.button_Sort.Location = new System.Drawing.Point(31, 85);
            this.button_Sort.Name = "button_Sort";
            this.button_Sort.Size = new System.Drawing.Size(173, 50);
            this.button_Sort.TabIndex = 0;
            this.button_Sort.Text = "Сортировать";
            this.button_Sort.UseVisualStyleBackColor = true;
            // 
            // button_SetCoef
            // 
            this.button_SetCoef.Location = new System.Drawing.Point(31, 141);
            this.button_SetCoef.Name = "button_SetCoef";
            this.button_SetCoef.Size = new System.Drawing.Size(173, 50);
            this.button_SetCoef.TabIndex = 0;
            this.button_SetCoef.Text = "Выбор к-кодирования";
            this.button_SetCoef.UseVisualStyleBackColor = true;
            // 
            // button_Code
            // 
            this.button_Code.Enabled = false;
            this.button_Code.Location = new System.Drawing.Point(31, 197);
            this.button_Code.Name = "button_Code";
            this.button_Code.Size = new System.Drawing.Size(173, 50);
            this.button_Code.TabIndex = 0;
            this.button_Code.Text = "Кодировать";
            this.button_Code.UseVisualStyleBackColor = true;
            this.button_Code.Click += new System.EventHandler(this.button3_Click);
            // 
            // radioButton_Compress
            // 
            this.radioButton_Compress.AutoSize = true;
            this.radioButton_Compress.Enabled = false;
            this.radioButton_Compress.Location = new System.Drawing.Point(21, 32);
            this.radioButton_Compress.Name = "radioButton_Compress";
            this.radioButton_Compress.Size = new System.Drawing.Size(122, 21);
            this.radioButton_Compress.TabIndex = 1;
            this.radioButton_Compress.TabStop = true;
            this.radioButton_Compress.Text = "Метод сжатия";
            this.radioButton_Compress.UseVisualStyleBackColor = true;
            // 
            // radioButton_MoveDown
            // 
            this.radioButton_MoveDown.AutoSize = true;
            this.radioButton_MoveDown.Enabled = false;
            this.radioButton_MoveDown.Location = new System.Drawing.Point(21, 59);
            this.radioButton_MoveDown.Name = "radioButton_MoveDown";
            this.radioButton_MoveDown.Size = new System.Drawing.Size(176, 21);
            this.radioButton_MoveDown.TabIndex = 1;
            this.radioButton_MoveDown.TabStop = true;
            this.radioButton_MoveDown.Text = "Метод смещения вниз";
            this.radioButton_MoveDown.UseVisualStyleBackColor = true;
            // 
            // radioButton_MoveUp
            // 
            this.radioButton_MoveUp.AutoSize = true;
            this.radioButton_MoveUp.Enabled = false;
            this.radioButton_MoveUp.Location = new System.Drawing.Point(21, 86);
            this.radioButton_MoveUp.Name = "radioButton_MoveUp";
            this.radioButton_MoveUp.Size = new System.Drawing.Size(182, 21);
            this.radioButton_MoveUp.TabIndex = 1;
            this.radioButton_MoveUp.TabStop = true;
            this.radioButton_MoveUp.Text = "Метод смещения вверх";
            this.radioButton_MoveUp.UseVisualStyleBackColor = true;
            // 
            // radioButton_Widening
            // 
            this.radioButton_Widening.AutoSize = true;
            this.radioButton_Widening.Enabled = false;
            this.radioButton_Widening.Location = new System.Drawing.Point(21, 113);
            this.radioButton_Widening.Name = "radioButton_Widening";
            this.radioButton_Widening.Size = new System.Drawing.Size(157, 21);
            this.radioButton_Widening.TabIndex = 1;
            this.radioButton_Widening.TabStop = true;
            this.radioButton_Widening.Text = "Метод расширения";
            this.radioButton_Widening.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_MoveDown);
            this.groupBox1.Controls.Add(this.radioButton_Widening);
            this.groupBox1.Controls.Add(this.radioButton_Compress);
            this.groupBox1.Controls.Add(this.radioButton_MoveUp);
            this.groupBox1.Location = new System.Drawing.Point(31, 271);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 152);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбор метода кодирования";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(302, 49);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(98, 260);
            this.listBox1.TabIndex = 3;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(469, 49);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(98, 260);
            this.listBox2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Начальные данные";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(435, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Закодированные данные";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(210, 155);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(60, 22);
            this.textBox1.TabIndex = 5;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.данныеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(651, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // данныеToolStripMenuItem
            // 
            this.данныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.загрузитьToolStripMenuItem});
            this.данныеToolStripMenuItem.Name = "данныеToolStripMenuItem";
            this.данныеToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.данныеToolStripMenuItem.Text = "Данные";
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.изФайлаToolStripMenuItem,
            this.изБазыДанныхToolStripMenuItem});
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            // 
            // изФайлаToolStripMenuItem
            // 
            this.изФайлаToolStripMenuItem.Name = "изФайлаToolStripMenuItem";
            this.изФайлаToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
            this.изФайлаToolStripMenuItem.Text = "Из файла";
            this.изФайлаToolStripMenuItem.Click += new System.EventHandler(this.изФайлаToolStripMenuItem_Click);
            // 
            // изБазыДанныхToolStripMenuItem
            // 
            this.изБазыДанныхToolStripMenuItem.Name = "изБазыДанныхToolStripMenuItem";
            this.изБазыДанныхToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
            this.изБазыДанныхToolStripMenuItem.Text = "Из базы данных";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 485);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_Code);
            this.Controls.Add(this.button_SetCoef);
            this.Controls.Add(this.button_Sort);
            this.Controls.Add(this.button_Analyze);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Шифрование данных";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Analyze;
        private System.Windows.Forms.Button button_Sort;
        private System.Windows.Forms.Button button_SetCoef;
        private System.Windows.Forms.Button button_Code;
        private System.Windows.Forms.RadioButton radioButton_Compress;
        private System.Windows.Forms.RadioButton radioButton_MoveDown;
        private System.Windows.Forms.RadioButton radioButton_MoveUp;
        private System.Windows.Forms.RadioButton radioButton_Widening;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem данныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изФайлаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изБазыДанныхToolStripMenuItem;
    }
}

