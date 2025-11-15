using System;
using System.IO;
using System.Linq;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.Tidzhanin.Sprint5.Task6.V10.Lib
{
    public class DataService : ISprint5Task6V10
    {
        public int LoadFromDataFile(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException($"Файл не найден: {path}");

            string text = File.ReadAllText(path);

            char[] separators = new char[] { ' ', ',', '.', '!', '?', ';', ':', '\t', '\n', '\r' };
            string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            int count = words.Count(word => word.Length == 4);

            return count;
        }
    }
}