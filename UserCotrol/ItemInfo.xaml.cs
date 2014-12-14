using BLL;
using Common.Models;
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
using System.Windows.Shapes;

namespace UserCotrol
{
    /// <summary>
    /// ItemInfo.xaml 的交互逻辑
    /// </summary>
    public partial class ItemInfo : Window
    {
        public ItemInfo(int OperationModel = 1,ProjectModel project=null)
        {
            if (OperationModel == 1)
            {
                this.LoadAddProject();
            }
            else
            {
                this.LoadUpdateProject(project);
            }
        }
        public ItemInfo()
        {
            InitializeComponent();
        }

        private void Close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Save(object sender, RoutedEventArgs e)
        {
            Models.ItemModels item = new Models.ItemModels()
            {
                Item_ProjectID = itemId.Text,
                Item_ResultMin = itemMaxScore.Text,
                Item_ResultMax = itemMaxScore.Text,
                Item_Score = itemScore.Text,
                Item_Level = itemLevel.Text,
                Item_Sex = "1"
            };

            try
            {
                new BLL.SetItemStandardOperation().AddItem(item);
                this.Close();
            }
            catch
            {
                MessageBox.Show("数据在添加时发生了未知的错误，这可能是非法的数据引的，如果确定数据正确，请再次重试！", "添加失败", MessageBoxButton.OKCancel, MessageBoxImage.Error);
            }

        }

        private void LoadAddProject()
        {
            ProjectOperation POeration = new ProjectOperation();
            List<ProjectModel> projectList = POeration.GetProject();
            List<string> list = new List<string>();
            foreach (ProjectModel project in projectList)
            {
                list.Add(project.Project_Name);
            }
            itemId.ItemsSource = list;
        }

        private void LoadUpdateProject(ProjectModel project)
        {
 
        }
    }
}
