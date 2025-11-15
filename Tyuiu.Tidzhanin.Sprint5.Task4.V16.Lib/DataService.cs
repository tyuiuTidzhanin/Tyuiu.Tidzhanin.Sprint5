using System;
using System.Globalization;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.Tidzhanin.Sprint5.Task4.V16.Lib
{
    public class DataService : ISprint5Task4V16
    {
        public double LoadFromDataFile(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException($"Файл не найден: {path}");

            // Читаем значение из файла
            string text = File.ReadAllText(path);

            // Заменяем запятую на точку для корректного парсинга
            string numberText = text.Replace(",", ".");
            double x = double.Parse(numberText, CultureInfo.InvariantCulture);

            // Вычисляем значение по формуле: y = cos(x) + x² - (2x / 1.2)
            double y = Math.Cos(x) + Math.Pow(x, 2) - (2 * x / 1.2);

            // Округляем до трех знаков после запятой
            return Math.Round(y, 3);
        }
    }
}