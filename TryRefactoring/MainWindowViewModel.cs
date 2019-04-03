using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TryRefactoring.Data;

namespace TryRefactoring
{
    public class MainWindowViewModel
    {
        public SampleData SelectedActiveDataItem { get; set; }

        private EmployeeServiceModel employeeServiceModel;

        public ObservableCollection<SampleData> EmployeeData { get; set; }

        public AddCommand AddCommand { get; set; }

        public RemoveCommand RemoveCommand { get; set; }

        public MainWindowViewModel()
        {
            // 社員情報サービスのModelを生成
            employeeServiceModel = new EmployeeServiceModel();
            //社員情報プロパティへデータを設定
            EmployeeData = employeeServiceModel.Employees;

            // コマンドを追加
            this.AddCommand = new AddCommand(this);
            // 行削除コマンドを追加
            this.RemoveCommand = new RemoveCommand(this);
        }

        public void OnAddRecord()
        {
            // 社員情報のModelに社員情報を追加する。
            this.employeeServiceModel.AddEmployee();
        }

        public void OnRemoveRecord()
        {
            // 社員情報のModelから社員情報を削除する。
            this.employeeServiceModel.RemoveEmployee(this.SelectedActiveDataItem);
        }

    }
}
