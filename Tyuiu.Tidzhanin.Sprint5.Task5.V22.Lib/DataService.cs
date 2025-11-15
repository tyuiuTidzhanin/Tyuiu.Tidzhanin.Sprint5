using System;
using System.Globalization;
using System.IO;
using System.Linq;
using tyuiu.cources.programming.interfaces.Sprint5;


namespace Tyuiu.Tidzhanin.Sprint5.Task5.V22.Lib
{
    public class DataService : ISprint5Task5V22
    {
        public double LoadFromDataFile(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException($"Файл не найден: {path}");

            // Читаем все строки из файла
            string[] lines = File.ReadAllLines(path);

            int? minDivisibleBy4 = null;

            foreach (string line in lines)
            {
                // Разделяем строку на числа по пробелам
                string[] numbers = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string numberStr in numbers)
                {
                    try
                    {
                        // Парсим число, заменяя точку на запятую для корректного парсинга
                        string normalizedNumber = numberStr.Replace(".", ",");
                        double number = double.Parse(normalizedNumber);

                        // Проверяем, является ли число целым и делится ли на 4
                        if (number == Math.Floor(number) && (int)number % 4 == 0)
                        {
                            int intNumber = (int)number;

                            // Находим минимальное число
                            if (minDivisibleBy4 == null || intNumber < minDivisibleBy4)
                            {
                                minDivisibleBy4 = intNumber;
                            }
                        }
                    }
                    catch (FormatException)
                    {
                        // Пропускаем некорректные данные
                        continue;
                    }
                }
            }

            if (minDivisibleBy4 == null)
                throw new Exception("В файле нет целых чисел, делящихся на 4");

            return (double)minDivisibleBy4;
        }
    }
}