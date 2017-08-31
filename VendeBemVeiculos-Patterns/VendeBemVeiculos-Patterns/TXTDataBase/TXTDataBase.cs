using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using VendeBemVeiculos_Patterns.Interfaces;

namespace VendeBemVeiculos_Patterns.TXTDataBase
{
    public abstract class TXTDataBase<T> : IDataBase<T>
    {
        protected string FilePath { get; set; }

        public IEnumerable<T> Recover()
        {
            if (this.CheckFileIfExists() == false)
            {
                throw new FileNotFoundException();
            }

            var data = new List<T>();

            using (var reader = new StreamReader(this.FilePath))
            {
                var fileLine = reader.ReadLine();
                while (string.IsNullOrEmpty(fileLine) == false)
                {
                    data.Add(this.GetLineContent(fileLine));
                    fileLine = reader.ReadLine();
                }
            }
            return data;
        }
        
        public void Update(IEnumerable<T> values)
        {
            if (this.CheckFileIfExists() == false)
            {
                File.Create(this.FilePath);
            }

            using (var dataStream = File.Open(this.FilePath, FileMode.Create))
            using (var dataWriter = new StreamWriter(dataStream))
            {
                var fileContent = this.GenerateFileContent(values);
                dataWriter.Write(fileContent);
            }
        }

        protected string GenerateFileContent(IEnumerable<T> values)
        {
            var content = string.Empty;
            foreach (T value in values)
            {
                content += this.ConvertInstanceToText(value);
            }
            return content;
        }

        protected bool CheckFileIfExists()
        {
            return File.Exists(this.FilePath);
        }

        protected abstract T GetLineContent(string line);

        protected abstract string ConvertInstanceToText(T line);
    }
}
