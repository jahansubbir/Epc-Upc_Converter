
using LeviEpcUpcConverter.DataAccessLayer;
using LeviEpcUpcConverter.Models;
using LeviEpcUpcConverter.Services;
using LeviEpcUpcConverter.UIComponents;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace LeviEpcUpcConverter
{
    /// <summary>
    /// Interaction logic for ConverterWindow.xaml
    /// </summary>
    public partial class ConverterWindow : Window
    {
        private OpenFileDialog fileDialog;
        SummaryDataAccess summaryDataAccess;
        CsvDataAccess csvDataAccess;
        Epc2UpcConverter converter;
        ReportingService reportingService;
        public ConverterWindow()
        {
            summaryDataAccess = new SummaryDataAccess();
            csvDataAccess = new CsvDataAccess();
            converter = new Epc2UpcConverter();
             reportingService = new ReportingService();
            InitializeComponent();
            LoadCheckDigitCombo();


        }
        private void LoadCheckDigitCombo()
        {
            CheckDigit.ItemsSource = Enum.GetValues(typeof(Epc2UpcConverter.CheckDigitFormat));
            CheckDigit.SelectedItem = CheckDigit.Items[0];
        }
        private void BrowseSummaryButton_Click(object sender, RoutedEventArgs e)
        {
            fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Excel| *.xls;*.xlsx;";
            fileDialog.FileOk += FileDialog_FileOk;
            fileDialog.ShowDialog();
        }

        private void FileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            fileDialog = (OpenFileDialog)sender;
            SummmaryTextBox.Text = fileDialog.FileName;

        }



        private void BrowseEpcButton_Click(object sender, RoutedEventArgs e)
        {
            fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Excel | *.csv";
            fileDialog.FileOk += BrowseEpcFile;
            fileDialog.ShowDialog();
        }

        private void BrowseEpcFile(object sender, CancelEventArgs e)
        {
            fileDialog = (OpenFileDialog)sender;
            //EpcBrowser.FilePath = fileDialog.FileName;
        }

        private void AddMoreButton_Click(object sender, RoutedEventArgs e)
        {
            if (!string.Equals(EpcBrowser.EpcTextBox.Text, String.Empty))
            {
                if (!IsEpcFileDuplicate(EpcBrowser.EpcTextBox.Text))
                {
                    AddEpcLabel();
                    MoveFileBrowser();
                    this.UpdateLayout();
                }
            }
        }
        private bool IsEpcFileDuplicate(string fileName)
        {
            bool duplicate = false;
            foreach (UIElement element in EpcGrid.Children)
            {
                if (element.GetType() == typeof(FilePathLabel))
                {
                    if (((FilePathLabel)element).FileName.Text == fileName)
                    {
                        return true;
                    }
                }
            }
            return duplicate;
        }
        private void AddEpcLabel()
        {

            FilePathLabel label = new FilePathLabel();
            label.Label.Content = "EPC File:";
            label.FileName.Text = EpcBrowser.EpcTextBox.Text;

            label.HorizontalAlignment = HorizontalAlignment.Left;
            label.VerticalAlignment = VerticalAlignment.Top;
            label.Margin = EpcBrowser.Margin;
            label.Width = 500;

            EpcGrid.Children.Add(label);
        }
        private void MoveFileBrowser()
        {
            var margin = EpcBrowser.Margin;
            var addMoreButtonMargin = AddMoreButton.Margin;

            EpcBrowser.Margin = new Thickness(margin.Left, margin.Top + 30, margin.Right, margin.Bottom);
            AddMoreButton.Margin = new Thickness(addMoreButtonMargin.Left, addMoreButtonMargin.Top + 30, addMoreButtonMargin.Right, addMoreButtonMargin.Bottom);
            EpcBrowser.EpcTextBox.Text = String.Empty;
        }

        private void ConvertButton_Click(object sender, RoutedEventArgs e)
        {
            var summaryFileName = SummmaryTextBox.Text;
            var csvFiles = GetCsvFiles();
            var checkDigitType = (Epc2UpcConverter.CheckDigitFormat)CheckDigit.SelectedItem;
            var summaries = summaryDataAccess.GetSummaries(summaryFileName);

            foreach (Summary summary in summaries)
            {
                var csvFile = csvFiles.Find(a => a.Contains(summary.PoNumber));
                if (csvFile != null)
                {
                    var poModel = csvDataAccess.GetPoModel(csvFile);
                    foreach (Model model in poModel.EpcList)
                    {
                        model.Upc = converter.Convert2Upc(model.Epc, checkDigitType);
                    }
                    summary.PoModel = poModel;
                }

            }
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.DefaultExt = ".xlsx";
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName!=String.Empty)
            {
                reportingService.CreateReport(summaries, saveFileDialog.FileName);
            }
            new NotificationBar("Completed Task!");
        }

        private List<string> GetCsvFiles()
        {
            List<string> epcFiles = new List<string>();
            foreach (UIElement element in EpcGrid.Children)
            {
                if (element.GetType().Equals(typeof(FilePathLabel)))
                {
                    var fileName = ((FilePathLabel)element).FileName.Text;
                    epcFiles.Add(fileName);
                }
            }
            return epcFiles;
        }
    }
}
