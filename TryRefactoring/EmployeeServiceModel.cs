using Newtonsoft.Json;
using System;
using System.Collections.Generic;
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

        public List<SampleData> Employees { get; set; }

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
        private List<SampleData> LoadJsonFile()
        {
            // Jsonファイルを読み込み、デシリアライズ化し、SampleDataに設定します。
            string fileContent = System.IO.File.ReadAllText(JSON_FILE_PATH);
            return JsonConvert.DeserializeObject<List<SampleData>>(fileContent);
        }


    }
}
