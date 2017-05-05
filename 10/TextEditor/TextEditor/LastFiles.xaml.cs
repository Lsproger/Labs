using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace TextEditor
{
    /// <summary>
    /// Логика взаимодействия для LastFiles.xaml
    /// </summary>
    public partial class LastFiles : Window
    {
        public LastFiles()
        {
            InitializeComponent();
            _lastFiles.SelectionChanged += _lastFiles_Selected;
            XDocument doc = XDocument.Load("legend.xml");
            Style st = new Style();
            _lastFiles.FontSize = 22;
            foreach (var file in doc.Root.Elements("path"))
            {
                _lastFiles.Items.Add(file.Value);
            }
        }

        private void _lastFiles_Selected(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            TextRange tr = new TextRange(
                mw.richTextBox.Document.ContentStart, mw.richTextBox.Document.ContentEnd);

            using (FileStream fs = File.Open(_lastFiles.SelectedValue.ToString(), FileMode.Open))
            {
                if (Regex.IsMatch(_lastFiles.SelectedValue.ToString(), ".rtf"))
                    tr.Load(fs, DataFormats.Rtf);
                else tr.Load(fs, DataFormats.Xaml);
            }
            mw.Title = _lastFiles.SelectedValue.ToString();
            mw.Show();
            this.Close();

        }
    }
}
