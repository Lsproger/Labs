using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using WPFColorPickerLib;
using System.Windows.Threading;
using System.Text.RegularExpressions;
using System.Globalization;

namespace TextEditor
{


    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {

        public static int numbOfWindows = 1;

        public MainWindow()
        {
            InitializeComponent();
            DispatcherTimer timer = new DispatcherTimer();
            timer.Tick += Timer_Tick;
            _ScaleSlider.ValueChanged += _ScaleSlider_ValueChanged;
            timer.Interval = new TimeSpan(1000000);
            timer.Start();
            _Editor.Loaded += Form_Loaded;
            this.Title += numbOfWindows;
            numbOfWindows++;
            richTextBox.AddHandler(RichTextBox.DragOverEvent, new DragEventHandler(RichTextBox_DragOver), true);
            richTextBox.AddHandler(RichTextBox.DropEvent, new DragEventHandler(RichTextBox_Drop), true);

            App.LanguageChanged += LanguageChanged;

            CultureInfo currLang = App.Language;

            //Заполняем меню смены языка:
            menuLanguage.Items.Clear();
            foreach (var lang in App.Languages)
            {
                MenuItem menuLang = new MenuItem();
                menuLang.Header = lang.DisplayName;
                menuLang.Tag = lang;
                menuLang.IsChecked = !lang.Equals(currLang);
                menuLang.Click += ChangeLanguageClick;
                menuLanguage.Items.Add(menuLang);
            }
            menuLanguage.Style = (Style)_Editor.FindResource("ForBoys");
        }

        private void _ScaleSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            _ScaleValue.Label = _ScaleSlider.Value + "%";
            richTextBox.HorizontalScrollBarVisibility = ScrollBarVisibility.Auto;
            richTextBox.VerticalScrollBarVisibility = ScrollBarVisibility.Auto;

            //richTextBox.RenderTransform = new ScaleTransform((1 + _ScaleSlider.Value / 100), (1 + _ScaleSlider.Value / 100), 0, 0);
            richTextBox.LayoutTransform = new ScaleTransform((_ScaleSlider.Value / 100), (_ScaleSlider.Value / 100), 0, 0);
            //richTextBox.LayoutTransform.SetValue()
        }

        private void Timer_Tick(object sender, EventArgs e)
        {

            _numbOfChar.Text = GetLength(richTextBox);

        }

        private void Cb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            richTextBox.Selection.ApplyPropertyValue(TextElement.FontFamilyProperty,
                new FontFamily(((sender as ComboBox).SelectedItem as ComboBoxItem).Content.ToString()));
        }

        private void Form_Loaded(object sender, RoutedEventArgs e)
        {
            cb.SelectedItem = cb.Items[0];
            _fontSize.Text = Convert.ToString(_fSizeSlider.Value);
            cb.SelectionChanged += Cb_SelectionChanged;
            _fSizeSlider.ValueChanged += _fSizeSlider_ValueChanged;


        }

        private void _fSizeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            _fontSize.Text = Convert.ToString(_fSizeSlider.Value);
            richTextBox.Selection.ApplyPropertyValue(TextElement.FontSizeProperty, _fSizeSlider.Value);
        }

        private void save_ButonClick(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.SaveFileDialog save = new Microsoft.Win32.SaveFileDialog();
            save.Filter =
                "Файл XAML (*.xaml)|*.xaml|RTF-файл (*.rtf)|*.rtf";

            if (save.ShowDialog() == true)
            {
                // Создание контейнера TextRange для всего документа
                TextRange documentTextRange = new TextRange(
                    richTextBox.Document.ContentStart, richTextBox.Document.ContentEnd);

                // Если такой файл существует, он перезаписывается, 
                using (FileStream fs = File.Create(save.FileName))
                {
                    if (System.IO.Path.GetExtension(save.FileName).ToLower() == ".xaml")
                    {
                        documentTextRange.Save(fs, DataFormats.Xaml);
                    }
                    else
                    {
                        documentTextRange.Save(fs, DataFormats.Rtf);
                    }
                }
            }
        }

        private void open_ButonClick(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog openFile =
                new Microsoft.Win32.OpenFileDialog();

            openFile.Filter = "RichText files (*.rtf)|*.rtf|All files (*.*)|*.*";
            if (openFile.ShowDialog() == true)
            {
                TextRange tr = new TextRange(
                    richTextBox.Document.ContentStart, richTextBox.Document.ContentEnd);

                using (FileStream fs = File.Open(openFile.FileName, FileMode.Open))
                {
                    if (Regex.IsMatch(openFile.FileName, ".rtf"))
                        tr.Load(fs, DataFormats.Rtf);
                    else tr.Load(fs, DataFormats.Xaml);
                }
                this.Title = openFile.FileName;
            }

            // Копирование содержимого документа в MemoryStream. 
            //using (MemoryStream stream = new MemoryStream())
            //{
            //    TextRange range = new TextRange(richTextBox.Document.ContentStart,
            //        richTextBox.Document.ContentEnd);
            //    range.Save(stream, DataFormats.Xaml);
            //    stream.Position = 0;

            // Чтение содержимого из потока и вывод его в текстовом поле. 

            // }
        }

        private void new_ButonClick(object sender, RoutedEventArgs e)
        {
            MainWindow newW = new MainWindow();
            newW.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Owner = this;
            if ((bool)colorDialog.ShowDialog())
            {
                richTextBox.Selection.ApplyPropertyValue(TextElement.ForegroundProperty, new SolidColorBrush(colorDialog.SelectedColor));
            }
        }

        private void RichTextBox_Drop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] docPath = (string[])e.Data.GetData(DataFormats.FileDrop);

                // By default, open as Rich Text (RTF).
                var dataFormat = DataFormats.Rtf;

                // If the Shift key is pressed, open as plain text.
                if (e.KeyStates == DragDropKeyStates.ShiftKey)
                {
                    dataFormat = DataFormats.Text;
                }

                System.Windows.Documents.TextRange range;
                System.IO.FileStream fStream;
                if (System.IO.File.Exists(docPath[0]))
                {
                    try
                    {
                        // Open the document in the RichTextBox.
                        range = new System.Windows.Documents.TextRange(richTextBox.Document.ContentStart, richTextBox.Document.ContentEnd);
                        fStream = new System.IO.FileStream(docPath[0], System.IO.FileMode.OpenOrCreate);
                        range.Load(fStream, dataFormat);
                        fStream.Close();
                    }
                    catch (System.Exception)
                    {
                        MessageBox.Show("File could not be opened. Make sure the file is a text file.");
                    }
                }
            }
        }

        private void RichTextBox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effects = DragDropEffects.None;

            if (e.Data.GetDataPresent(DataFormats.Rtf))
            {
                e.Effects = DragDropEffects.Copy;
            }
        }

        private void RichTextBox_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effects = DragDropEffects.All;
            }
            else
            {
                e.Effects = DragDropEffects.None;
            }
            e.Handled = false;
        }

        string GetLength(RichTextBox rtb)
        {
            var textRange = new TextRange(rtb.Document.ContentStart, rtb.Document.ContentEnd);

            return (textRange.Text.Length - 2).ToString();
        }

        private void MinusButton_Click(object sender, RoutedEventArgs e)
        {
            _ScaleSlider.Value -= 10;
        }

        private void PlusButton_Click(object sender, RoutedEventArgs e)
        {
            _ScaleSlider.Value += 10;
        }

        private void LanguageChanged(Object sender, EventArgs e)
        {
            CultureInfo currLang = App.Language;

            //Отмечаем нужный пункт смены языка как выбранный язык
            foreach (MenuItem i in menuLanguage.Items)
            {
                CultureInfo ci = i.Tag as CultureInfo;
                i.IsChecked = ci != null && ci.Equals(currLang);
            }
        }

        private void ChangeLanguageClick(Object sender, EventArgs e)
        {
            MenuItem mi = sender as MenuItem;
            if (mi != null)
            {
                CultureInfo lang = mi.Tag as CultureInfo;
                if (lang != null)
                {
                    App.Language = lang;
                }
            }

        }
    }

}



