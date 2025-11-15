using System;
using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;


namespace Tyuiu.Tidzhanin.Sprint5.Task7.V13.Lib
{
    public class DataService : ISprint5Task7V13
    {
        public string LoadDataAndSave(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException($"Файл не найден: {path}");

            string text = File.ReadAllText(path);

            
            StringBuilder resultBuilder = new StringBuilder();

            foreach (char c in text)
            {
                if (!(c >= 'a' && c <= 'z'))
                {
                    resultBuilder.Append(c);
                }
            }

            string resultText = resultBuilder.ToString();

            string outputPath = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V13.txt");
            File.WriteAllText(outputPath, resultText);

            return outputPath;
        }
    }
}