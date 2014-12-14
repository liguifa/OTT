using OTT.Common;
using System;
using System.Collections.Generic;
using System.Linq;
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

namespace OTT
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //frame.Navigate(Uris.Home);
        }

        private void SetItemStandard(object sender, RoutedEventArgs e)
        {
            //frame.Navigate(Uris.SetItemStandard);
        }

        private void SetProjectStandard(object sender, RoutedEventArgs e)
        {
            //frame.Navigate(Uris.SetProjectStandard);
        }

        private void ComputeGroupResult(object sender, RoutedEventArgs e)
        {
            //frame.Navigate(Uris.ComputeGroupResult);
        }

        private void SetPersonResult(object sender, RoutedEventArgs e)
        {
            //frame.Navigate(Uris.ComputePersonResult);
        }

        private void Close(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("gb");
            this.Close();
        }
    }
}
