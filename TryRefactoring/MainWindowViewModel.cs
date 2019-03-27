using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TryRefactoring.Data;

namespace TryRefactoring
{
    public class MainWindowViewModel
    {
        private EmployeeServiceModel employeeServiceModel;

        public List<SampleData> EmployeeData { get; set; }

        public MainWindowViewModel()
        {
            // 社員情報サービスのModelを生成
            employeeServiceModel = new EmployeeServiceModel();
            //社員情報プロパティへデータを設定
            EmployeeData = employeeServiceModel.Employees;
        }

    }
}
