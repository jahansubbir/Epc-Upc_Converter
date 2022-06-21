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
using System.Windows.Shapes;

namespace LeviEpcUpcConverter.UIComponents
{
    /// <summary>
    /// Interaction logic for NotificationBar.xaml
    /// </summary>
    public partial class NotificationBar : Window
    {
        public NotificationBar(string text)
        {
            InitializeComponent();
            NotificationBlock.Text = text;

            this.Show();
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
