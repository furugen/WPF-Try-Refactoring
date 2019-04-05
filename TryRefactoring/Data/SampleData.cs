using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TryRefactoring.Data
{
    public class SampleData : INotifyPropertyChanged
    {
        private static int GenerateId = 1;

        public int Id { get; private set; }

        private string _Name;
        public string Name
        {
            get { return _Name; }
            set { _Name = value; OnPropertyChanged(); }
        }

        private int _Age;
        public int Age
        {
            get { return _Age; }
            set { _Age = value; OnPropertyChanged(); }
        }

        public SampleData()
        {
            this.Id = GenerateId++;
            this.Name = "name:" + this.Id;
            this.Age = 1;
        }

        /// <summary>
        /// プロパティ値の変更をクライアントに通知する。
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// PropertyChanged イベント を発生させる。
        /// </summary>
        /// <param name="propertyName">変更されたプロパティ名</param>
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
