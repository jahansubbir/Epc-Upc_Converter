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

namespace LeviEpcUpcConverter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void PasteButton_Click(object sender, RoutedEventArgs e)
        {
            var epcList = Clipboard.GetText().Split(new[] {'\t','\r','\n','"'}, StringSplitOptions.RemoveEmptyEntries).ToList(); 
            foreach(string epc in epcList)
            {
                EpcGrid.Items.Add(new Model{ Epc = epc.Trim() });
            }

        }

        private void ConvertButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
