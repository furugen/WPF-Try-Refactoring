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
    /// <summary>
    /// 社員情報(SampleData)を取り扱うサービスです。(Model層)
    /// </summary>
    public class EmployeeServiceModel
    {
        private string JSON_FILE_PATH = "./Assets/sampledata.json";

        public ObservableCollection<SampleData> Employees { get; set; }

        public EmployeeServiceModel()
        {
            InitializeData();
        }

        /// <summary>
        /// 初期データを読み込みます。
        /// </summary>
        public void InitializeData()
        {
            Employees = LoadJsonFile();
        }

        /// <summary>
        /// Jsonファイルを読み込み、社員情報(SampleData)へデシリアライズします。
        /// </summary>
        /// <returns></returns>
        private ObservableCollection<SampleData> LoadJsonFile()
        {
            // Jsonファイルを読み込み、デシリアライズ化し、SampleDataに設定します。
            string fileContent = System.IO.File.ReadAllText(JSON_FILE_PATH);
            return JsonConvert.DeserializeObject<ObservableCollection<SampleData>>(fileContent);
        }


        public void AddEmployee()
        {
            this.Employees.Add(new SampleData());
        }


    }
}
