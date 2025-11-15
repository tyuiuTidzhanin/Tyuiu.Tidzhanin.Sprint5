using System;
using System.IO;
using Tyuiu.Tidzhanin.Sprint5.Task5.V22.Lib;

namespace Tyuiu.Tidzhanin.Sprint5.Task5.V22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Нгаргондо Тиджани | Вариант #22";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Чтение набора данных из текстового файла                          *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #22                                                             *");
            Console.WriteLine("* Выполнил: Нгаргондо Тиджани | ИСТНб-25-1                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл, в котором есть набор значений. Найти минимальное целое число *");
            Console.WriteLine("* в файле, которое делится на 4. Полученный результат вывести на консоль.*");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask5V22.txt";

            Console.WriteLine($"* Путь к файлу: {path}");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            try
            {
                DataService ds = new DataService();
                double result = ds.LoadFromDataFile(path);

                // Выводим содержимое файла для наглядности
                if (File.Exists(path))
                {
                    Console.WriteLine("Содержимое файла:");
                    string fileContent = File.ReadAllText(path);
                    Console.WriteLine(fileContent);
                    Console.WriteLine("-----------------------------------------------------------------------");
                }

                Console.WriteLine($"Минимальное целое число, делящееся на 4: {result}");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
                Console.WriteLine("Убедитесь, что файл существует по пути: C:\\DataSprint5\\InPutDataFileTask5V22.txt");
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