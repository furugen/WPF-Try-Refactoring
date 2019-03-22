using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryRefactoring.Data
{
    public class SampleData
    {
        private static int GenerateId = 1;

        public int Id { get; private set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public SampleData()
        {
            this.Id = GenerateId++;
            this.Name = "name:" + this.Id;
            this.Age = 1;
        }
    }
}
