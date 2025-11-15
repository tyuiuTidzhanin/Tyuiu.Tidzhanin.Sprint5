using System;
using System.IO;
using Tyuiu.Tidzhanin.Sprint5.Task3.V21.Lib;

namespace Tyuiu.Tidzhanin.Sprint5.Task3.V21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Нгаргондо Тиджани | Вариант #21";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Потоковый метод записи данных в бинарный файл                    *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #21                                                             *");
            Console.WriteLine("* Выполнил: Нгаргондо Тиджани | ИСТНб-25-1                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дано выражение: y(x) = (x² + 1) / √(4x² - 3)                           *");
            Console.WriteLine("* Вычислить его значение при x = 3, результат сохранить в бинарный файл  *");
            Console.WriteLine("* OutPutFileTask3.bin и вывести на консоль. Округлить до трёх знаков     *");
            Console.WriteLine("* после запятой.                                                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 3;
            Console.WriteLine($"* x = {x}                                                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            string path = ds.SaveToFileTextData(x);

            // Читаем результат из бинарного файла
            double result;
            using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                result = reader.ReadDouble();
            }

            // Вычисляем для проверки
            double numerator = Math.Pow(x, 2) + 1;
            double denominator = Math.Sqrt(4 * Math.Pow(x, 2) - 3);
            double y = numerator / denominator;
            y = Math.Round(y, 3);

            Console.WriteLine($"При x = {x}:");
            Console.WriteLine($"y({x}) = ({x}² + 1) / √(4*{x}² - 3) = ({numerator}) / √({4 * Math.Pow(x, 2) - 3}) = {y}");
            Console.WriteLine($"Результат сохранен в файл: {path}");
            Console.WriteLine($"Содержимое файла (double): {result}");
            Console.WriteLine("***************************************************************************");

            Console.ReadKey();
        }
    }
}