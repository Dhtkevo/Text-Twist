using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using KevinMaduProject2.Model;
using static System.Windows.Forms.Design.AxImporter;

namespace KevinMaduProject2.Utilities
{
    public class DataImporter
    {

        private readonly JsonSerializerOptions _options = new()
        {
            PropertyNameCaseInsensitive = true
        };


        public List<Dictionary> ReadFile()
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select a File";
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "json files (*.json)|*.json";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;

                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }

            if (!string.IsNullOrWhiteSpace(fileContent))
            {
                var dictionaries = JsonSerializer.Deserialize<List<Dictionary>>(fileContent, _options)!;
                MessageBox.Show($"Successfully read: {dictionaries.Count} dictionaries");
                return dictionaries;

            }

            return null;
        }
    }
}
