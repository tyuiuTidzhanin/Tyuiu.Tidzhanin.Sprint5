using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.Tidzhanin.Sprint5.Task3.V21.Lib
{
    public class DataService : ISprint5Task3V21
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");

            // Вычисляем значение функции: y(x) = (x² + 1) / √(4x² - 3)
            double numerator = Math.Pow(x, 2) + 1;
            double denominator = Math.Sqrt(4 * Math.Pow(x, 2) - 3);
            double y = numerator / denominator;

            // Округляем до трех знаков после запятой
            y = Math.Round(y, 3);

            // Записываем в бинарный файл
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Create)))
            {
                writer.Write(y.ToString());
            }

            return path;
        }
    }
}