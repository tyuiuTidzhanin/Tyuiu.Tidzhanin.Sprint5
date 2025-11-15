using System;
using System.IO;
using Tyuiu.Tidzhanin.Sprint5.Task6.V10.Lib;

namespace Tyuiu.Tidzhanin.Sprint5.Task6.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Нгаргондо Тиджани | Вариант #10";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Обработка текстовых данных                                        *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнил: Нгаргондо Тиджани | ИСТНб-25-1                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл, в котором есть набор символьных данных. Найти количество     *");
            Console.WriteLine("* слов длиной четыре символа в заданной строке.                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask6V10.txt";

            Console.WriteLine($"* Путь к файлу: {path}");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            try
            {
                DataService ds = new DataService();
                int result = ds.LoadFromDataFile(path);

                // Выводим содержимое файла для наглядности
                if (File.Exists(path))
                {
                    Console.WriteLine("Содержимое файла:");
                    string fileContent = File.ReadAllText(path);
                    Console.WriteLine($"\"{fileContent}\"");
                    Console.WriteLine("-----------------------------------------------------------------------");
                }

                Console.WriteLine($"Количество слов длиной 4 символа: {result}");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
                Console.WriteLine("Убедитесь, что файл существует по пути: C:\\DataSprint5\\InPutDataFileTask6V10.txt");
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