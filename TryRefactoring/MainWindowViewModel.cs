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
        private EmployeeServiceModel employeeServiceModel;

        public ObservableCollection<SampleData> EmployeeData { get; set; }

        public AddCommand AddCommand { get; set; }

        public MainWindowViewModel()
        {
            // 社員情報サービスのModelを生成
            employeeServiceModel = new EmployeeServiceModel();
            //社員情報プロパティへデータを設定
            EmployeeData = employeeServiceModel.Employees;

            // コマンドを追加
            this.AddCommand = new AddCommand(this);
        }

        public void OnAddRecord()
        {
            // 社員情報のModelに社員情報を追加する。
            this.employeeServiceModel.AddEmployee();
        }

    }
}
