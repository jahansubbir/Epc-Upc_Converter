using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LeviEpcUpcConverter.UIComponents
{
    /// <summary>
    /// Interaction logic for FileBrowser.xaml
    /// </summary>
    public partial class FileBrowser : UserControl
    {
        OpenFileDialog fileDialog;// new OpenFileDialog();
        public string FilePath { get; set; }
        public FileBrowser()
        {
            InitializeComponent();
        }
      
        private void BrowseEpcButton_Click(object sender, RoutedEventArgs e)
        {
            fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Excel | *.csv";
            fileDialog.FileOk += FileDialog_FileOk;
            fileDialog.ShowDialog();
        }

        private void FileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            fileDialog = (OpenFileDialog)sender;
            EpcTextBox.Text = fileDialog.FileName;
        }

        private void AddMoreButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
