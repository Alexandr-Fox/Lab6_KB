using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.Windows.Input;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private string _vert = "radioButton2";
        private string _horiz = "radioButton4";
        private string FormName { get; set; }
        private bool AltI = false;
        private bool AltX = false;
        private CheckBox NameBlock;
        private CheckBox PosBlock;
        public Form1()
        {
            var checkBox = new CheckBox();
            checkBox.Name = "NameBlock";
            checkBox.Text = "Заголовка";
            checkBox.Checked = false;
            checkBox.AutoSize = true;
            checkBox.Location = new Point(8, 16);
            checkBox.CheckedChanged += new EventHandler(this.checkBox_CheckedChanged);
            var checkBox1 = new CheckBox();
            checkBox1.Name = "PosBlock";
            checkBox1.Text = "Положения окна";
            checkBox1.Checked = false;
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(8, 41);
            InitializeComponent();
            NameBlock = checkBox;
            PosBlock = checkBox1;
            groupBox3.Controls.Add(checkBox);
            groupBox3.Controls.Add(checkBox1);
            textBox1.ContextMenuStrip = new ContextMenuStrip(this.components);
            InitComboBox();

            this.KeyDown += Main_KeyDown;

            KeyPreview = true;

        }
        private void InitComboBox()
        {
            var names = new string[] { "qwerty", "123456789", "Лабораторная работа №6", "Леонов Алексей", "Программа", "Имя", "Имя 2", "Имя 3" };
            foreach (string name in names)
                comboBox1.Items.Add(name);
            comboBox1.SelectedIndex = 0;
        }
        private void Main_MouseDown(object sender, MouseEventArgs e)
        {

            if (AltI && ModifierKeys == Keys.Alt)
            {
                PosBlock.Checked = false;
                NameBlock.Checked = false;
                comboBox1.Items.Clear();
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                listBox3.Items.Clear();
                toolStripStatusLabel1.Text = "";
                toolStripStatusLabel2.Text = "";
                textBox2.Text = "";
                textBox1.Text = "";
                radioButton2.Checked = true;
                radioButton4.Checked = true;
                InitComboBox();
            }
        }
        private void Main_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (AltX && ModifierKeys == Keys.Alt)
            {
                Close();
            }
        }
        private void ComboBox1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter && !comboBox1.Items.Contains( comboBox1.Text))
            {
                comboBox1.Items.Add(comboBox1.Text);
                comboBox1.SelectedIndex = comboBox1.Items.Count - 1;
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!NameBlock.Checked)
            {
                this.Text = comboBox1.Text;
            }
            else comboBox1.SelectedIndex = comboBox1.Items.IndexOf(Text);
        }
        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NameBlock.Checked)
            {
                this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            else
            {
                this.comboBox1.DropDownStyle = ComboBoxStyle.DropDown;
            }

        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void RadioButton_Horizontal_Checked(object sender, EventArgs e)
        {
            var pressed = (RadioButton)sender;
            if (!(bool)PosBlock.Checked)
                switch (pressed.Text)
                {
                    case "Слева":
                        {
                            Left = 0;
                            _horiz = pressed.Name;
                            break;
                        }
                    case "По центру":
                        {
                            Left = (SystemInformation.WorkingArea.Width - Width) / 2;
                            _horiz = pressed.Name;
                            break;
                        }
                    case "Справа":
                        {
                            Left = SystemInformation.WorkingArea.Width - Width;
                            _horiz = pressed.Name;
                            break;
                        }
                }
            else
            {
                var c = Controls.Find(_horiz, true);
                ((RadioButton)c[0]).Checked = true;
            }
        }
        private void RadioButton_Vertical_Checked(object sender, EventArgs e)
        {
            var pressed = (RadioButton)sender;
            if (!(bool)PosBlock.Checked)
                switch (pressed.Text)
                {
                    case "Вверху":
                        {
                            this.Top = 0;
                            _vert = pressed.Name;
                            break;
                        }
                    case "По центру":
                        {
                            Top = (SystemInformation.WorkingArea.Height - Height) / 2;
                            _vert = pressed.Name;
                            break;
                        }
                    case "Внизу":
                        {
                            Top = SystemInformation.WorkingArea.Height - Height;
                            _vert = pressed.Name;
                            break;
                        }
                }
            else
            {
                var c = Controls.Find(_vert, true);
                ((RadioButton)c[0]).Checked = true;
            }
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                NumberFormatInfo provider = new();
                provider.NumberDecimalSeparator = ".";
                provider.NumberGroupSeparator = "";
                if (IsDouble(textBox1.Text))
                    listBox1.Items.Add(Convert.ToDouble(textBox1.Text, provider).ToString());
            }
        }
        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (sender is TextBox textBox && e.KeyCode == Keys.Enter)
            {
                var textBox2 = sender as TextBox;
                listBox3.Items.Add(textBox2.Text);
            }
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox1.Text.Length == 0 && (e.KeyChar == '-' || Char.IsDigit(e.KeyChar))) return;
            else if (IsDouble(textBox1.Text + e.KeyChar)) return;
            else if (e.KeyChar == (char)Keys.Back) return;
            else e.Handled = true;
        }
        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            if (Convert.ToChar(e.KeyCode) == Convert.ToChar(Keys.I))
                AltI = true;
            if (Convert.ToChar(Convert.ToString(Convert.ToChar(e.KeyCode)).ToUpper()) == Convert.ToChar(Keys.X))
                AltX = true;
        }
        private void Main_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.I)
                AltI = false;
            if (e.KeyCode == Keys.X)
                AltX = false;
        }
        private bool IsDouble(string s)
        {
            string s1 = s.TrimStart('-');
            try
            {
                NumberFormatInfo provider = new();
                provider.NumberDecimalSeparator = ".";
                provider.NumberGroupSeparator = "";
                double d = Convert.ToDouble(s, provider);
                return Regex.IsMatch(s, @"-?\d+(?:\.\d+)?") && s1.Length > 1 ? ((s1[0] == '0' && s1[1] == '.') || s1[0] != '0')  : true;
            }
            catch
            {
                return false;
            }
        }
        private void MenuItem_Click1(object sender, ToolStripItemClickedEventArgs e)
        {
            NumberFormatInfo provider = new();
            provider.NumberDecimalSeparator = ".";
            provider.NumberGroupSeparator = "";
            switch (e.ClickedItem.Tag)
            {
                case "Add":
                    {
                        if (textBox1.Text == "")
                            toolStripStatusLabel2.Text = "Текстбокс пуст";
                        else if (IsDouble(textBox1.Text))
                        {
                            listBox1.Items.Add(Convert.ToDouble(textBox1.Text, provider).ToString());
                            textBox1.Text = "";
                        }
                        else
                            toolStripStatusLabel2.Text = "Текстбокс не содержит действительного числа";
                        break;
                    }
                case "Delete":
                    {
                        if (listBox1.Items.Count == 0)
                            toolStripStatusLabel2.Text = "Листбокс пуст";
                        else
                        {
                            var count = listBox1.SelectedItems.Count;
                            if (count > 0)
                            {
                                for (int i = 0; i < count; i++)
                                {
                                    listBox1.Items.Remove(listBox1.SelectedItems[0]);
                                }
                                toolStripStatusLabel2.Text = "Элементы удалены из Листбокс1";
                            }
                            else
                                toolStripStatusLabel2.Text = "Нет выделенных элементов";
                        }
                        break;
                    }
                case "C":
                    {
                        listBox2.Items.Clear();
                        if (listBox1.Items.Count > 0)
                        {
                            foreach (var item in listBox1.Items)
                            {
                                var qw = Convert.ToInt32(Math.Truncate(Convert.ToDouble(item))) % 2;
                                var ds = Convert.ToDouble(item) > 0;
                                if (qw == 0&& ds)
                                {
                                    listBox2.Items.Add(item);
                                }
                            }

                            if (listBox2.Items.Count > 0)
                            {
                                toolStripStatusLabel2.Text = $"Количество положительных элементов с четной целой частью: {listBox2.Items.Count}";
                            }
                            else
                            {
                                toolStripStatusLabel2.Text = "Нет положительных элементов с четной целой чaстью";
                            }
                        }
                        else
                        {
                            toolStripStatusLabel2.Text = "Нет элементов";
                        }
                        break;
                    }
                case "G":
                    {
                        listBox2.Items.Clear();
                        int count = 0;
                        if (listBox1.Items.Count > 0)
                        {
                            if (listBox1.Items.Count > 5)
                            {
                                for (int i = 0; i < 6; i++)
                                {
                                    if (Convert.ToString(listBox1.Items[i]).Contains(",") ? Convert.ToInt32(Convert.ToString(listBox1.Items[i]).Split(",")[1]) % 2 == 0 : false)
                                        count++;
                                }
                                if (count > 0)
                                {
                                    for (int i = 0; i < 6; i++)
                                        listBox2.Items.Add(listBox1.Items[i]);
                                    toolStripStatusLabel2.Text = "Операция завершена";
                                }
                                else
                                {
                                    toolStripStatusLabel2.Text = "Нет чисел с четной дробной частью";
                                }
                            }
                            else
                            {
                                toolStripStatusLabel2.Text = "В списке меньше 6 чисел";
                            }
                        }
                        else
                            toolStripStatusLabel2.Text = "Нет элементов";

                        break;
                    }
                case "Delete2":
                    {
                        var count = listBox2.SelectedItems.Count;
                        if (listBox2.Items.Count == 0)
                            toolStripStatusLabel2.Text = "Листбокс пуст";
                        else
                        {
                            if (count > 0)
                            {
                                for (int i = 0; i < count; i++)
                                {
                                    listBox2.Items.Remove(listBox2.SelectedItems[0]);
                                }
                                toolStripStatusLabel2.Text = "Элементы удалены из Листбокс2";
                            }
                            else
                                toolStripStatusLabel2.Text = "Нет выделенных элементов";
                        }
                        break;
                    }
            }
        }
        private void MenuItem_Click2(object sender, EventArgs e)
        {
            var menuItem = sender as ToolStripMenuItem;
            switch (menuItem.Tag)
            {
                case "Add":
                    {
                        listBox3.Items.Add(textBox2.Text);
                        break;
                    }
                case "Delete":
                    {
                        if (listBox3.Items.Count == 0)
                            toolStripStatusLabel2.Text = "Листбокс пуст";
                        else
                        {
                            var count = listBox3.SelectedItems.Count;
                            if (count > 0)
                            {
                                for (int i = 0; i < count; i++)
                                {
                                    listBox3.Items.Remove(listBox3.SelectedItems[0]);
                                }
                                toolStripStatusLabel2.Text = "Элементы удалены из Листбокс3";
                            }
                            else
                                toolStripStatusLabel2.Text = "Нет выделенных элементов";
                        }
                        break;
                    }
                case "A":
                    {
                        if (listBox3.Items.Count == 0)
                            toolStripStatusLabel2.Text = "Листбокс пуст";
                        else
                        {
                            int c = 0;
                            foreach (string item in listBox3.Items)
                                if (!Regex.IsMatch(item, @".*\d.*"))
                                    c++;
                            toolStripStatusLabel2.Text = $"Количество строк без цифр: {c}";
                        }
                        break;
                    }
                case "G":
                    {
                        if (listBox3.Items.Count == 0)
                            toolStripStatusLabel2.Text = "Листбокс пуст";
                        else
                        {
                            int max = 0;
                            for (int i = 0; i < listBox3.Items.Count; i++)
                            {
                                var c = Convert.ToString(listBox3.Items[i])[0];
                                var l = Convert.ToString(listBox3.Items[i]).Trim(' ').Split(" ");
                                int count = 0;
                                foreach (string item in l)
                                    if (item[0] == c)
                                        count++;
                                max = max>count? max : i;
                            }
                            var list = new List<string>();
                            foreach(string item in listBox3.Items)
                            {
                                var c = Convert.ToString(item)[0];
                                var l = Convert.ToString(item).Trim(' ').Split(" ");
                                int count = 0;
                                foreach (string it in l)
                                    if (it[0] == c)
                                        count++;
                                if (count +1  == max )
                                    list.Add(item);
                            }
                            listBox3.Items.Clear();
                            foreach(string item in list)
                                listBox3.Items.Add(item);
                            toolStripStatusLabel2.Text = $"Операция завершена";
                        }
                        break;
                    }
            }
        }

        private void MouseEnter(object sender, EventArgs e)
        {
            switch (sender)
            {
                case TextBox textBox:
                    {
                        if (textBox.Name == "textBox1")
                            toolStripStatusLabel1.Text = "Поле для добавления действительных чисел в список 1";
                        else if (textBox.Name == "textBox2")
                            toolStripStatusLabel1.Text = "Поле для добавления строк в список 3";
                        break;
                    }
                case ComboBox comboBox:
                    {
                        if (comboBox.Name == "comboBox1")
                            toolStripStatusLabel1.Text = "Выбирите шрифт для окна или добавьте свой";
                        break;
                    }
                case ListBox listBox:
                    {
                        if (listBox.Name == "listBox1")
                            toolStripStatusLabel1.Text = "Список №1, содержащий в себе действительные числа";
                        else if (listBox.Name == "listBox2")
                            toolStripStatusLabel1.Text = "Список №2, хранящий результаты работы со списком №1";
                        else if (listBox.Name == "listBox3")
                            toolStripStatusLabel1.Text = "Список №3, содержащий в строки. Действия выбираются через контекстное меню";
                        break;
                    }
                case GroupBox groupBox:
                    {
                        if (groupBox.Name == "groupBox1")
                            toolStripStatusLabel1.Text = "Выбор положения окна по вертикали";
                        else if (groupBox.Name == "groupBox2")
                            toolStripStatusLabel1.Text = "Выбор положения окна по горизонтали";
                        else if (groupBox.Name == "groupBox3")
                            toolStripStatusLabel1.Text = "Блокировка изменения шрифта и положения через переключатели";
                        break;
                    }
                case MenuStrip menu:
                    {
                        toolStripStatusLabel1.Text = "Меню для работы со списками №1 и №2";
                        break;
                    }
                case ContextMenuStrip contextMenu:
                    {
                        toolStripStatusLabel1.Text = "Меню для работы со списком №3";
                        break;
                    }
                case ToolStripMenuItem menuItem:
                    {

                        if (menuItem.Name == "добавитьToolStripMenuItem")
                            toolStripStatusLabel1.Text = "Добавить число из поля №1 в список №1";
                        else if (menuItem.Name == "удалитьсписок1ToolStripMenuItem")
                            toolStripStatusLabel1.Text = "Удалить выделеные  элементы из списка №1";
                        else if (menuItem.Name == "удалитьсписок2ToolStripMenuItem")
                            toolStripStatusLabel1.Text = "Удалить выделеные  элементы из списка №2";
                        else if (menuItem.Name == "удалитьToolStripMenuItem")
                            toolStripStatusLabel1.Text = "Удалить выделеные  элементы из списка №3";
                        else if (menuItem.Name == "положительныеЧислаToolStripMenuItem")
                            toolStripStatusLabel1.Text = "Найти сумму и количество чисел с четной целой частью";
                        else if (menuItem.Name == "дробнаяЧетнаяЧастьToolStripMenuItem")
                            toolStripStatusLabel1.Text = "Найти среднее геометрическое дробной части положительных чисел";
                        else if (menuItem.Name == "добавитьToolStripMenuItem1")
                            toolStripStatusLabel1.Text = "Добавить число из поля №2 в список №3";
                        else if (menuItem.Name == "безЧиселToolStripMenuItem")
                            toolStripStatusLabel1.Text = "Найти количество строк без цифр";
                        else if (menuItem.Name == "максимумСловToolStripMenuItem")
                            toolStripStatusLabel1.Text = "Убрать пробелы в нечетных строках и удвоить в четных ";
                        break;
                    }
                case CheckBox checkBox:
                    {
                        if (checkBox.Name == "NameBlock")
                            toolStripStatusLabel1.Text = "Блокировка изменения названия формы";
                        else if (checkBox.Name == "PosBlock")
                            toolStripStatusLabel1.Text = "Блокировка изменения переключателей положения";
                        break;
                    }
                case RadioButton radioButton:
                    {
                        if (radioButton.Name == "radioButton2")
                            toolStripStatusLabel1.Text = "Центрирование по горизонтали";
                        else if (radioButton.Name == "radioButton5")
                            toolStripStatusLabel1.Text = "Центрирование по вертикали";
                        else if (radioButton.Name == "radioButton1")
                            toolStripStatusLabel1.Text = "Привязка к верхней части экрана";
                        else if (radioButton.Name == "radioButton3")
                            toolStripStatusLabel1.Text = "Привязка к нижней части экрана";
                        else if (radioButton.Name == "radioButton6")
                            toolStripStatusLabel1.Text = "Привязка к правой части экрана";
                        else if (radioButton.Name == "radioButton4")
                            toolStripStatusLabel1.Text = "Привязка к левой части экрана";
                        break;
                    }
                case StatusStrip statusStrip:
                    {
                            toolStripStatusLabel1.Text = "Строка состояния";
                        break;
                    }
            }
        }

        private void MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }


    }
}
