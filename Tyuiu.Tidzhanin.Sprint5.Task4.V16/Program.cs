using System;
using System.IO;
using Tyuiu.Tidzhanin.Sprint5.Task4.V16.Lib;

namespace Tyuiu.Tidzhanin.Sprint5.Task4.V16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Нгаргондо Тиджани | Вариант #16";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Чтение данных из текстового файла                                 *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #16                                                             *");
            Console.WriteLine("* Выполнил: Нгаргондо Тиджани | ИСТНб-25-1                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл, в котором есть вещественное значение. Прочитать значение     *");
            Console.WriteLine("* из файла и подставить вместо X в формуле. Вычислить значение по формуле*");
            Console.WriteLine("* y = cos(x) + x² - (2x / 1.2) и вернуть полученный результат на консоль.*");
            Console.WriteLine("* Полученное значение округлить до трёх знаков после запятой.            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask4V16.txt";

            Console.WriteLine($"* Путь к файлу: {path}");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            try
            {
                DataService ds = new DataService();
                double result = ds.LoadFromDataFile(path);

                // Читаем значение x из файла для отображения
                string xValue = File.ReadAllText(path);
                Console.WriteLine($"Значение x из файла: {xValue}");
                Console.WriteLine($"Результат вычисления: {result}");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
                Console.WriteLine("Убедитесь, что файл существует по пути: C:\\DataSprint5\\InPutDataFileTask4V16.txt");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }

            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}