using System;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace Lab6_v10
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// #40fd14
    /// #1a1a1a
    /// #f2fd14
    /// #ffffff

    // Ростовский Александр Евгеньевич вариант 10 повышеный уровень

    public partial class MainWindow
    {
        private string _vert = "Center_V";
        private string _horiz = "Center";
        private string FontAll { get; set; }
        private bool AltI = false;
        private bool AltX = false;
        private CheckBox FontsBlock;
        private CheckBox PosBlock;

        public MainWindow()
        {
            var checkBox = new CheckBox();
            checkBox.Name = "FontsBlock";
            checkBox.Content = "Шрифта";
            checkBox.Margin = new Thickness(0, 3, 5, 0);
            checkBox.IsChecked = false;
            var checkBox1 = new CheckBox();
            checkBox1.Name = "PosBlock";
            checkBox1.Content = "Положения окна";
            checkBox1.Margin = new Thickness(0, 3, 5, 0);
            checkBox1.IsChecked = false;
            InitializeComponent();
            this.FontsBlock = checkBox;
            this.PosBlock = checkBox1;
            StackBlock.Children.Add(checkBox);
            StackBlock.Children.Add(checkBox1);
            if (this.FindName("Main") is Window mainWindow) mainWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            var c = this.FindName(_horiz) as RadioButton;
            c.IsChecked = true;
            c = this.FindName(_vert) as RadioButton;
            c.IsChecked = true;
            InitComboBox();
            // InitListBox1();
        }
        private void InitComboBox()
        {
            var comboFonts = this.FindName("ComboFonts") as ComboBox;
            var fontFamilies = Fonts.SystemFontFamilies.ToList();
            for (int i = 0; i < 8; i++)
                comboFonts?.Items.Add(fontFamilies[i].Source);
            comboFonts!.SelectedIndex = 0;
            FontAll = comboFonts.Text;
        }

        private void InitListBox1()
        {
            Random random = new Random();
            for (int i = 0; i < 10; i++)
                ListBox1.Items.Add(Convert.ToString(random.Next(-15,15) + random.NextDouble()));
        }

        private void RadioButton_Horizontal_Checked(object sender, RoutedEventArgs e)
        {
            var pressed = (RadioButton)sender;
            var mainWindow = this.FindName("MainWindow1") as Window;
            if (!(bool)PosBlock.IsChecked)
                switch (pressed.Content)
                {
                    case "Слева":
                    {
                        mainWindow!.Left = 0;
                        _horiz = pressed.Name;
                        break;
                    }
                    case "По центру":
                    {
                        mainWindow!.Left = (SystemParameters.WorkArea.Width - mainWindow.Width) / 2;
                        _horiz = pressed.Name;
                        break;
                    }
                    case "Справа":
                    {
                        mainWindow!.Left = SystemParameters.WorkArea.Width - mainWindow.Width;
                        _horiz = pressed.Name;
                        break;
                    }
                }
            else
            {
                var c = this.FindName(_horiz) as RadioButton;
                c.IsChecked = true;
            }
        }

        private void RadioButton_Vertical_Checked(object sender, RoutedEventArgs e)
        {
            var pressed = (RadioButton)sender;
            var mainWindow = this.FindName("MainWindow1") as Window;
            var checkPos = this.FindName("PosBlock") as CheckBox;
            if (!(bool)PosBlock.IsChecked)
                switch (pressed.Content)
                {
                    case "Вверху":
                    {
                        mainWindow!.Top = 0;
                        _vert = pressed.Name;
                        break;
                    }
                    case "По центру":
                    {
                        mainWindow!.Top = (SystemParameters.WorkArea.Height - mainWindow.Height) / 2;
                        _vert = pressed.Name;
                        break;
                    }
                    case "Внизу":
                    {
                        mainWindow!.Top = SystemParameters.WorkArea.Height - mainWindow.Height;
                        _vert = pressed.Name;
                        break;
                    }
                }
            else
            {
                var c = this.FindName(_vert) as RadioButton;
                c.IsChecked = true;
            }
        }

        private void ComboBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if ((bool)FontsBlock.IsChecked) return;
            ComboFonts.IsEditable = true;
        }

        private void ComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (sender is ComboBox comboBox && e.Key == Key.Return)
            {
                var fontFamilies = Fonts.SystemFontFamilies.ToList();
                if (!comboBox.Items.Contains(comboBox.Text) && comboBox.Text != "" &&
                    fontFamilies.Exists(p => p.Source == comboBox.Text))
                {
                    comboBox.Items.Add(comboBox.Text);
                }
                else
                {
                    comboBox.Text = FontAll;
                }

                comboBox.IsEditable = false;
                comboBox.SelectedIndex = comboBox.Items.IndexOf(comboBox.Text);
            }
        }
        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if( e.Key == Key.Enter)
            {
                NumberFormatInfo provider = new();
                provider.NumberDecimalSeparator = ".";
                provider.NumberGroupSeparator = "";
                if (IsDouble(TextBox1.Text))
                    ListBox1.Items.Add(Convert.ToDouble(TextBox1.Text, provider).ToString());
            }
        }
        private void TextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (sender is TextBox textBox && e.Key == Key.Return)
            {
                var textBox2 = sender as TextBox;
                ListBox3.Items.Add(textBox2.Text);
            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var comboBox = sender as ComboBox;
            if ((bool)FontsBlock.IsChecked)
            {
                comboBox!.Text = FontAll;
                comboBox.SelectedIndex = comboBox.Items.IndexOf(comboBox.Text);
            }
            else if (!comboBox!.IsEditable && comboBox.SelectedItem != null)
            {
                FontAll = comboBox.SelectedItem.ToString()!;
                var fontFamilies = Fonts.SystemFontFamilies.ToList();
                var selectFont = comboBox.SelectedValue.ToString();
                MainWindow1.FontFamily = fontFamilies.First(s => s.Source == selectFont);
            }
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
                return Regex.IsMatch(s, @"-?\d+(?:\.\d+)?") && s1.Length>1?((s1[0]=='0'&&s1[1]=='.')||s1[0]!='0'):true;
            }
            catch
            {
                return false;
            }
        }
        private void Main_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyboardDevice.Modifiers == ModifierKeys.Alt && e.SystemKey == Key.I)
                AltI = true;
            if (e.KeyboardDevice.Modifiers == ModifierKeys.Alt && e.SystemKey == Key.X)
                AltX = true;
        }
        private void Main_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyboardDevice.Modifiers == ModifierKeys.Alt || e.Key == Key.I)
                AltI = false;
            if (e.KeyboardDevice.Modifiers == ModifierKeys.Alt || e.Key == Key.X)
                AltX = false;
        }
        private void MenuItem_Click1(object sender, RoutedEventArgs e)
        {
            var menuItem = sender as MenuItem;
            NumberFormatInfo provider = new ();
            provider.NumberDecimalSeparator = ".";
            provider.NumberGroupSeparator = "";
            switch (menuItem.Tag)
            {
                case "Add":
                    {
                        if (TextBox1.Text == "")
                            resBlock.Text = "Текстбокс пуст";
                        else if (IsDouble(TextBox1.Text)) { 
                            ListBox1.Items.Add(Convert.ToDouble(TextBox1.Text, provider).ToString());
                            TextBox1.Text = "";
                        }
                        else
                            resBlock.Text = "Текстбокс не содержит действительного числа";
                        break;
                    }
                case "Delete":
                    {
                        if (ListBox1.Items.Count == 0)
                            resBlock.Text = "Листбокс пуст";
                        else
                        {
                            var count = ListBox1.SelectedItems.Count;
                            if (count > 0) { 
                                for (int i = 0; i < count; i++)
                                {
                                    ListBox1.Items.Remove(ListBox1.SelectedItems[0]);
                                }
                                resBlock.Text = "Элементы удалены из Листбокс1";
                            }
                            else
                                resBlock.Text = "Нет выделенных элементов";
                        }
                    break;
                    }
                case "A":
                    {
                        int count = 0;
                        double sum = 0;
                        ListBox2.Items.Clear();
                        if ( ListBox1.Items.Count > 0) {
                            foreach (var item in ListBox1.Items)
                            {
                                if (Convert.ToInt32(Math.Truncate(Convert.ToDouble(item))) % 2 == 0)
                                {
                                    sum += Convert.ToDouble(item);
                                    count++;
                                    ListBox2.Items.Add(item);
                                }
                            }

                            if (count > 0)
                            {
                                resBlock.Text = $"Сумма: {sum}, количество: {count}";
                            }
                            else
                            {
                                resBlock.Text = "Нет элементов с четной целой честью";
                            }
                        }
                        else
                        {
                            resBlock.Text = "Нет элементов";
                        }
                        break;
                    }
                case "D":
                    {
                        ListBox2.Items.Clear();
                        double pro = 1.0;
                        int count = 0;
                        if (ListBox1.Items.Count > 0)
                        {
                            foreach (var item in ListBox1.Items)
                            {
                                if (Convert.ToDouble(item) > 0)
                                {
                                    pro *= Convert.ToDouble(item) - Math.Truncate(Convert.ToDouble(item));
                                    count++;
                                    ListBox2.Items.Add(item);
                                }
                            }
                            if (count > 0)
                            {
                                // ListBox2.Items.Add(sum);
                                // ListBox2.Items.Add(count);
                                resBlock.Text = $"Среднее геометрическое: {Math.Pow(pro, 1.0 / count)}";
                            }
                            else
                            {
                                resBlock.Text = "нет положительных элементов";
                            }
                        }
                        else
                            resBlock.Text = "Нет элементов";

                        break;
                    }
                case "Delete2":
                    {
                        var count = ListBox2.SelectedItems.Count;
                        if (ListBox2.Items.Count == 0)
                            resBlock.Text = "Листбокс пуст";
                        else
                        {
                            if (count > 0)
                            {
                                for (int i = 0; i < count; i++)
                                {
                                    logBlock.Text += ListBox2.SelectedItems[0].ToString();
                                    ListBox2.Items.Remove(ListBox2.SelectedItems[0]);
                                }
                                resBlock.Text = "Элементы удалены из Листбокс2";
                            }
                            else
                                resBlock.Text = "Нет выделенных элементов";
                        }
                        break;
                    }
            }
        }
        private void MenuItem_Click2(object sender, RoutedEventArgs e)
        {
            var menuItem = sender as MenuItem;
            var textBox2 = this.FindName("TextBox2") as TextBox;
            switch (menuItem.Tag)
            {
                case "Add":
                    {
                        ListBox3.Items.Add(textBox2.Text);
                        break;
                    }
                case "Delete":
                    {
                        if (ListBox3.Items.Count == 0)
                            resBlock.Text = "Листбокс пуст";
                        else
                        {
                            var count = ListBox3.SelectedItems.Count;
                            if (count > 0)
                            {
                                for (int i = 0; i < count; i++)
                                {
                                    ListBox3.Items.Remove(ListBox3.SelectedItems[0]);
                                }
                                resBlock.Text = "Элементы удалены из Листбокс3";
                            }
                            else
                                resBlock.Text = "Нет выделенных элементов";
                        }
                        break;
                    }
                case "A":
                    {
                        if (ListBox3.Items.Count == 0)
                            resBlock.Text = "Листбокс пуст";
                        else
                        {
                            int c = 0;
                            foreach (string item in ListBox3.Items)
                                if (!Regex.IsMatch(item, @".*\d.*"))
                                    c++;
                            resBlock.Text = $"Количество строк без цифр: {c}";
                        }
                        break;
                    }
                case "D":
                    {
                        if (ListBox3.Items.Count == 0)
                            resBlock.Text = "Листбокс пуст";
                        else
                        {
                            for (int i = 0; i < ListBox3.Items.Count; i++)
                            {
                                if (i % 2 == 0)
                                    ListBox3.Items[i] = ListBox3.Items[i].ToString().Replace(" ", "");
                                else
                                    ListBox3.Items[i] = ListBox3.Items[i].ToString().Replace(" ", "  ");
                            }
                            resBlock.Text = $"Операция завершена";
                        }
                        break;
                    }
            }
        }

        private void Main_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (AltI)
            {
                var FontsBlock = this.FindName("FontsBlock") as CheckBox;
                var textBox2 = this.FindName("TextBox2") as TextBox;
                var V = this.FindName("Center_V") as RadioButton;
                var H = this.FindName("Center") as RadioButton;
                PosBlock.IsChecked = false;
                FontsBlock.IsChecked = false;
                ComboFonts.Items.Clear();
                ListBox1.Items.Clear();
                ListBox2.Items.Clear();
                ListBox3.Items.Clear();
                logBlock.Text = "";
                TextBox1.Text = "";
                textBox2.Text = "";
                H.IsChecked = true;
                V.IsChecked = true;
                InitComboBox();
            }
        }

        private void Main_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (AltX)
            {
                Close();
            }
        }

        private void MouseEnter(object sender, MouseEventArgs e)
        {
            switch (sender)
            {
                case TextBox textBox:
                    {
                        if (textBox.Name == "TextBox1")
                            logBlock.Text = "Поле для добавления действительных чисел в список 1";
                        else if (textBox.Name == "TextBox2")
                            logBlock.Text = "Поле для добавления строк в список 3";
                        break;
                    }
                case ComboBox comboBox:
                    {
                        if (comboBox.Name == "ComboFonts")
                            logBlock.Text = "Выбирите шрифт для окна или добавьте свой";
                        break;
                    }
                case ListBox listBox:
                    {
                        if (listBox.Name == "ListBox1")
                            logBlock.Text = "Список №1, содержащий в себе действительные числа";
                        else if (listBox.Name == "ListBox2")
                            logBlock.Text = "Список №2, хранящий результаты работы со списком №1";
                        else if (listBox.Name == "ListBox3")
                            logBlock.Text = "Список №3, содержащий в строки. Действия выбираются через контекстное меню";
                        break;
                    }
                case GroupBox groupBox:
                    {
                        if (groupBox.Name == "GroupBoxVert")
                            logBlock.Text = "Выбор положения окна по вертикали";
                        else if (groupBox.Name == "GroupBoxHoriz")
                            logBlock.Text = "Выбор положения окна по горизонтали";
                        else if (groupBox.Name == "GroupBoxBlock")
                            logBlock.Text = "Блокировка изменения шрифта и положения через переключатели";
                        else if (groupBox.Name == "GroupBoxStatus")
                            logBlock.Text = "Строка состояния";
                        else if (groupBox.Name == "GroupBoxResult")
                            logBlock.Text = "Строка результатов";
                        break;
                    }
                case Menu menu:
                    {
                        logBlock.Text = "Меню для работы со списками №1 и №2";
                        break;
                    }
                case ContextMenu contextMenu:
                    {
                        logBlock.Text = "Меню для работы со списком №3";
                        break;
                    }
                case MenuItem menuItem:
                    {

                        if (menuItem.Name == "MenuAdd")
                            logBlock.Text = "Добавить число из поля №1 в список №1";
                        else if (menuItem.Name == "MenuDel1")
                            logBlock.Text = "Удалить выделеные  элементы из списка №1";
                        else if (menuItem.Name == "MenuDel2")
                            logBlock.Text = "Удалить выделеные  элементы из списка №2";
                        else if (menuItem.Name == "CMenuDel")
                            logBlock.Text = "Удалить выделеные  элементы из списка №3";
                        else if (menuItem.Name == "MenuSum")
                            logBlock.Text = "Найти сумму и количество чисел с четной целой частью";
                        else if (menuItem.Name == "MenuGeo")
                            logBlock.Text = "Найти среднее геометрическое дробной части положительных чисел";
                        else if (menuItem.Name == "CMenuAdd")
                            logBlock.Text = "Добавить число из поля №2 в список №3";
                        else if (menuItem.Name == "CMenuNum")
                            logBlock.Text = "Найти количество строк без цифр";
                        else if (menuItem.Name == "CMenuSpace")
                            logBlock.Text = "Убрать пробелы в нечетных строках и удвоить в четных ";
                        break;
                    }
                case CheckBox checkBox:
                    {
                        if (checkBox.Name == "FontsBlock")
                            logBlock.Text = "Блокировка изменения шрифта формы";
                        else if (checkBox.Name == "PosBlock")
                            logBlock.Text = "Блокировка изменения переключателей положения";
                        break;
                    }
                case RadioButton radioButton:
                    {
                        if (radioButton.Name == "Center")
                            logBlock.Text = "Центрирование по горизонтали";
                        else if (radioButton.Name == "Center_V")
                            logBlock.Text = "Центрирование по вертикали";
                        else if (radioButton.Name == "Top")
                            logBlock.Text = "Привязка к верхней части экрана";
                        else if (radioButton.Name == "Bottom")
                            logBlock.Text = "Привязка к нижней части экрана";
                        else if (radioButton.Name == "Right")
                            logBlock.Text = "Привязка к правой части экрана";
                        else if (radioButton.Name == "Left")
                            logBlock.Text = "Привязка к левой части экрана";
                        break;
                    }
            }
        }

        private void MouseLeave(object sender, MouseEventArgs e)
        {
            logBlock.Text = "";
        }

        private void TextBox1_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (TextBox1.Text.Length == 0 && (e.Text == "-" || Char.IsDigit(e.Text[0]))) return;
            else if (IsDouble(TextBox1.Text + e.Text)) return;
            else e.Handled = true;
        }
    }
}