using Newtonsoft.Json;
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
using TryRefactoring.Data;

namespace TryRefactoring
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // ViewModelを設定
            this.DataContext = new MainWindowViewModel();
        }

        private void addBtnClick(object sender, RoutedEventArgs e)
        {
            // 行を追加する
            List<SampleData> records = this.xamDataGrid.DataSource as List<SampleData>;
            records.Add(new SampleData());
            this.xamDataGrid.DataSource = null;
            this.xamDataGrid.DataSource = records;
        }

        private void deleteBtnClick(object sender, RoutedEventArgs e)
        {
            // 選択行を削除する。
            List<SampleData> records = this.xamDataGrid.DataSource as List<SampleData>;
            records.Remove((SampleData)this.xamDataGrid.ActiveDataItem);
            this.xamDataGrid.DataSource = null;
            this.xamDataGrid.DataSource = records;
        }


        private void fixBtnClick(object sender, RoutedEventArgs e)
        {
            SampleData editData = this.xamPropGrid.SelectedObject as SampleData;
            List<SampleData> records = this.xamDataGrid.DataSource as List<SampleData>;
            SampleData targetData = records.First(data => data.Id == editData.Id);

            // 編集内容を反映
            targetData.Age = editData.Age;
            targetData.Name = editData.Name;

            // XamDataGridに反映
            this.xamDataGrid.DataSource = null;
            this.xamDataGrid.DataSource = records;

            // データソース反映時に選択行が解除されるため、再設定
            this.xamDataGrid.SelectedDataItem = targetData;

        }

        private void XamDataGrid_RecordActivated(object sender, Infragistics.Windows.DataPresenter.Events.RecordActivatedEventArgs e)
        {
            // 選択行のオブジェクトをXamPropertyGridに表示
            xamPropGrid.SelectedObject = this.xamDataGrid.ActiveDataItem;
        }

    }
}
