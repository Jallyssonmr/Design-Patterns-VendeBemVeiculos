using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using VendeBemVeiculos_Patterns.Interfaces;

namespace VendeBemVeiculos_Patterns.TXTDataBase
{
    public abstract class TXTDataBase<T> : IDataBase<T>
    {
        protected string FILE_NOT_FOUND = "Arquivo não encontrado";
        protected string FilePath { get; set; }

        public IEnumerable<T> Recover()
        {
            if (this.CheckFileIfExists() == false)
            {
                MessageBox.Show(FILE_NOT_FOUND);
                return null;
            }

            List<T> data = new List<T>();

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

        protected abstract T GetLineContent(string line);

        public void Update(IEnumerable<T> values)
        {
            if (this.CheckFileIfExists() == false)
            {
                File.Create(this.FilePath);
            }

            using (var dataStream = File.Open(this.FilePath, FileMode.Create))
            using (var dataWriter = new StreamWriter(dataStream))
            {
                var fileContent = this.GetFileContent(values);
                dataWriter.Write(fileContent);
            }
        }

        protected string GetFileContent(IEnumerable<T> values)
        {
            var content = string.Empty;
            foreach (T line in values)
            {
                content += this.ConvertInstanceToText(line);
            }
            return content;
        }

        protected abstract string ConvertInstanceToText(T line);

        protected bool CheckFileIfExists()
        {
            if (File.Exists(this.FilePath)) { return true; }
            else { return false; }
        }
    }
}
