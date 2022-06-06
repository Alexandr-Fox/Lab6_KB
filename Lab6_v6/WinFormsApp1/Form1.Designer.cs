namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.добавитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.безЧиселToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.максимумСловToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьсписок1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.положительныеЧислаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.дробнаяЧетнаяЧастьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьсписок2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(143, 23);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            this.comboBox1.KeyDown += ComboBox1_KeyDown;
            this.comboBox1.MouseEnter += MouseEnter;
            this.comboBox1.MouseLeave += MouseLeave;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(176, 37);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(203, 274);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.MouseEnter += MouseEnter;
            this.listBox1.MouseLeave += MouseLeave;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Location = new System.Drawing.Point(379, 37);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(203, 274);
            this.listBox2.TabIndex = 2;
            this.listBox2.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox2.MouseEnter += MouseEnter;
            this.listBox2.MouseLeave += MouseLeave;
            // 
            // listBox3
            // 
            this.listBox3.ContextMenuStrip = this.contextMenuStrip1;
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 15;
            this.listBox3.Location = new System.Drawing.Point(579, 37);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(203, 274);
            this.listBox3.TabIndex = 3;
            this.listBox3.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox3.MouseEnter += MouseEnter;
            this.listBox3.MouseLeave += MouseLeave;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem1,
            this.удалитьToolStripMenuItem,
            this.безЧиселToolStripMenuItem,
            this.максимумСловToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(164, 92);
            this.contextMenuStrip1.MouseEnter += MouseEnter;
            this.contextMenuStrip1.MouseLeave += MouseLeave;
            // 
            // добавитьToolStripMenuItem1
            // 
            this.добавитьToolStripMenuItem1.Name = "добавитьToolStripMenuItem1";
            this.добавитьToolStripMenuItem1.Size = new System.Drawing.Size(163, 22);
            this.добавитьToolStripMenuItem1.Tag = "Add";
            this.добавитьToolStripMenuItem1.Text = "Добавить";
            this.добавитьToolStripMenuItem1.Click += MenuItem_Click2;
            this.добавитьToolStripMenuItem1.MouseEnter += MouseEnter;
            this.добавитьToolStripMenuItem1.MouseLeave += MouseLeave;
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.удалитьToolStripMenuItem.Tag = "Delete";
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += MenuItem_Click2;
            this.удалитьToolStripMenuItem.MouseEnter += MouseEnter;
            this.удалитьToolStripMenuItem.MouseLeave += MouseLeave;
            // 
            // безЧиселToolStripMenuItem
            // 
            this.безЧиселToolStripMenuItem.Name = "безЧиселToolStripMenuItem";
            this.безЧиселToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.безЧиселToolStripMenuItem.Tag = "A";
            this.безЧиселToolStripMenuItem.Text = "Без цифр";
            this.безЧиселToolStripMenuItem.Click += MenuItem_Click2;
            this.безЧиселToolStripMenuItem.MouseEnter += MouseEnter;
            this.безЧиселToolStripMenuItem.MouseLeave += MouseLeave;
            // 
            // максимумСловToolStripMenuItem
            // 
            this.максимумСловToolStripMenuItem.Name = "максимумСловToolStripMenuItem";
            this.максимумСловToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.максимумСловToolStripMenuItem.Tag = "G";
            this.максимумСловToolStripMenuItem.Text = "Максимум слов";
            this.максимумСловToolStripMenuItem.Click += MenuItem_Click2;
            this.максимумСловToolStripMenuItem.MouseEnter += MouseEnter;
            this.максимумСловToolStripMenuItem.MouseLeave += MouseLeave;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(176, 316);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(203, 23);
            this.textBox1.TabIndex = 4;
            this.textBox1.KeyDown += textBox1_KeyDown;
            this.textBox1.KeyPress += textBox1_KeyPress;
            this.textBox1.MouseEnter += MouseEnter;
            this.textBox1.MouseLeave += MouseLeave;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(579, 317);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(203, 23);
            this.textBox2.TabIndex = 5;
            this.textBox2.KeyDown += textBox2_KeyDown;
            this.textBox2.MouseEnter += MouseEnter;
            this.textBox2.MouseLeave += MouseLeave;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(13, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(142, 112);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "По вертикали";
            this.groupBox1.MouseEnter += MouseEnter;
            this.groupBox1.MouseLeave += MouseLeave;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 72);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(57, 19);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Внизу";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += RadioButton_Vertical_Checked;
            this.radioButton3.MouseEnter += MouseEnter;
            this.radioButton3.MouseLeave += MouseLeave;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 47);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(82, 19);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "По центру";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += RadioButton_Vertical_Checked;
            this.radioButton2.MouseEnter += MouseEnter;
            this.radioButton2.MouseLeave += MouseLeave;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 22);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(63, 19);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Вверху";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += RadioButton_Vertical_Checked;
            this.radioButton1.MouseEnter += MouseEnter;
            this.radioButton1.MouseLeave += MouseLeave;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Controls.Add(this.radioButton5);
            this.groupBox2.Controls.Add(this.radioButton6);
            this.groupBox2.Location = new System.Drawing.Point(12, 187);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(142, 112);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "По горизонтали";
            this.groupBox2.MouseEnter += MouseEnter;
            this.groupBox2.MouseLeave += MouseLeave;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(6, 72);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(58, 19);
            this.radioButton4.TabIndex = 2;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Слева";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += RadioButton_Horizontal_Checked;
            this.radioButton4.MouseEnter += MouseEnter;
            this.radioButton4.MouseLeave += MouseLeave;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Checked = true;
            this.radioButton5.Location = new System.Drawing.Point(6, 47);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(82, 19);
            this.radioButton5.TabIndex = 1;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "По центру";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += RadioButton_Horizontal_Checked;
            this.radioButton5.MouseEnter += MouseEnter;
            this.radioButton5.MouseLeave += MouseLeave;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(6, 22);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(65, 19);
            this.radioButton6.TabIndex = 0;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Справа";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += RadioButton_Horizontal_Checked;
            this.radioButton6.MouseEnter += MouseEnter;
            this.radioButton6.MouseLeave += MouseLeave;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(12, 305);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(143, 85);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Блокировка";
            this.groupBox3.MouseEnter += MouseEnter;
            this.groupBox3.MouseLeave += MouseLeave;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.удалитьсписок1ToolStripMenuItem,
            this.положительныеЧислаToolStripMenuItem,
            this.дробнаяЧетнаяЧастьToolStripMenuItem,
            this.удалитьсписок2ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.MouseEnter += MouseEnter;
            this.menuStrip1.MouseLeave += MouseLeave;
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuItem_Click1);
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.добавитьToolStripMenuItem.Tag = "Add";
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.MouseEnter += MouseEnter;
            this.добавитьToolStripMenuItem.MouseLeave += MouseLeave;
            // 
            // удалитьсписок1ToolStripMenuItem
            // 
            this.удалитьсписок1ToolStripMenuItem.Name = "удалитьсписок1ToolStripMenuItem";
            this.удалитьсписок1ToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.удалитьсписок1ToolStripMenuItem.Tag = "Delete";
            this.удалитьсписок1ToolStripMenuItem.Text = "Удалить (список 1)";
            this.удалитьсписок1ToolStripMenuItem.MouseEnter += MouseEnter;
            this.удалитьсписок1ToolStripMenuItem.MouseLeave += MouseLeave;
            // 
            // положительныеЧислаToolStripMenuItem
            // 
            this.положительныеЧислаToolStripMenuItem.Name = "положительныеЧислаToolStripMenuItem";
            this.положительныеЧислаToolStripMenuItem.Size = new System.Drawing.Size(147, 20);
            this.положительныеЧислаToolStripMenuItem.Tag = "C";
            this.положительныеЧислаToolStripMenuItem.Text = "Положительные числа";
            this.положительныеЧислаToolStripMenuItem.MouseEnter += MouseEnter;
            this.положительныеЧислаToolStripMenuItem.MouseLeave += MouseLeave;
            // 
            // дробнаяЧетнаяЧастьToolStripMenuItem
            // 
            this.дробнаяЧетнаяЧастьToolStripMenuItem.Name = "дробнаяЧетнаяЧастьToolStripMenuItem";
            this.дробнаяЧетнаяЧастьToolStripMenuItem.Size = new System.Drawing.Size(140, 20);
            this.дробнаяЧетнаяЧастьToolStripMenuItem.Tag = "G";
            this.дробнаяЧетнаяЧастьToolStripMenuItem.Text = "Дробная четная часть";
            this.дробнаяЧетнаяЧастьToolStripMenuItem.MouseEnter += MouseEnter;
            this.дробнаяЧетнаяЧастьToolStripMenuItem.MouseLeave += MouseLeave;
            // 
            // удалитьсписок2ToolStripMenuItem
            // 
            this.удалитьсписок2ToolStripMenuItem.Name = "удалитьсписок2ToolStripMenuItem";
            this.удалитьсписок2ToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.удалитьсписок2ToolStripMenuItem.Tag = "Delete2";
            this.удалитьсписок2ToolStripMenuItem.Text = "Удалить (список 2)";
            this.удалитьсписок2ToolStripMenuItem.MouseEnter += MouseEnter;
            this.удалитьсписок2ToolStripMenuItem.MouseLeave += MouseLeave;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.MouseEnter += MouseEnter;
            this.statusStrip1.MouseLeave += MouseLeave;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.AutoSize = true;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel1.AutoSize = true;
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(118, 17);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            //this.KeyPress += Main_KeyPress;
            this.KeyUp += Main_KeyUp;
            this.MouseClick += Main_MouseDown;
            this.MouseDoubleClick += Main_MouseDoubleClick;
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьсписок1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem положительныеЧислаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem дробнаяЧетнаяЧастьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьсписок2ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem безЧиселToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem максимумСловToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
    }
}
