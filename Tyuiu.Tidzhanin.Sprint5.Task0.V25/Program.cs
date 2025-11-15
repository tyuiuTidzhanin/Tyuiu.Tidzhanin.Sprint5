using System;
using System.IO;
using Tyuiu.Tidzhanin.Sprint5.Task0.V25.Lib;

namespace Tyuiu.Tidzhanin.Sprint5.Task0.V25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Нгаргондо Тиджани | Вариант #25";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Запись данных в текстовый файл                                    *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #25                                                             *");
            Console.WriteLine("* Выполнил: Нгаргондо Тиджани | ИСТНб-25-1                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дано выражение вычислить его значение при x = 3, результат сохранить    *");
            Console.WriteLine("* в текстовый файл OutPutFileTask0.txt и вывести на консоль.              *");
            Console.WriteLine("* Округлить до трёх знаков после запятой.                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            int x = 3;
            string path = ds.SaveToFileTextData(x);

            Console.WriteLine($"* При x = {x}                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Результат сохранен в файл: {path}");
            Console.WriteLine("***************************************************************************");

            // Выведем содержимое файла
            string result = File.ReadAllText(path);
            Console.WriteLine($"Содержимое файла: {result}");
            Console.WriteLine("***************************************************************************");

            Console.ReadKey();
        }
    }
}