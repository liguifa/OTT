using BLL;
using Common.Lib;
using Common.Models;
using OTT.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using UserCotrol;

namespace OTT.Views
{
    /// <summary>
    /// SetItemStandardView.xaml 的交互逻辑
    /// </summary>
    public partial class SetItemStandardView : UserControl
    {
        public SetItemStandardView()
        {
            InitializeComponent();
            dataGrid.ItemsSource=LoadData();
        }

        public List<Models.ItemModels> LoadData()
        {
            return new SetItemStandardOperation().GetItemList();
        }

        private void AddScore(object sender, RoutedEventArgs e)
        {
            ItemInfo itemInfo = new ItemInfo();
            MessageBox.Show(itemInfo.ShowDialog().ToString(),"");
            dataGrid.ItemsSource = LoadData();
        }

        private void UpdateScore(object sender, RoutedEventArgs e)
        {
            ItemInfo itemInfo = new ItemInfo(2, new ProjectModel() { });
            MessageBox.Show(itemInfo.ShowDialog().ToString(), "");
            dataGrid.ItemsSource = LoadData();
        }
    }
}
