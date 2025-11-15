using System;
using System.IO;
using Tyuiu.Tidzhanin.Sprint5.Task7.V13.Lib;

namespace Tyuiu.Tidzhanin.Sprint5.Task7.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Нгаргондо Тиджани | Вариант #13";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Обработка текстовых данных                                        *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнил: Нгаргондо Тиджани | ИСТНб-25-1                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл, в котором есть набор символьных данных. Удалить все строчные *");
            Console.WriteLine("* латинские буквы из файла. Полученный результат сохранить в файл        *");
            Console.WriteLine("* OutPutDataFileTask7V13.txt.                                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string inputPath = @"C:\DataSprint5\InPutDataFileTask7V13.txt";

            Console.WriteLine($"* Исходный файл: {inputPath}");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            try
            {
                DataService ds = new DataService();
                string outputPath = ds.LoadDataAndSave(inputPath);

                // Выводим содержимое исходного файла
                if (File.Exists(inputPath))
                {
                    Console.WriteLine("Исходный текст:");
                    string originalText = File.ReadAllText(inputPath);
                    Console.WriteLine($"\"{originalText}\"");
                    Console.WriteLine("-----------------------------------------------------------------------");
                }

                // Выводим содержимое результирующего файла
                if (File.Exists(outputPath))
                {
                    Console.WriteLine("Текст после удаления строчных латинских букв:");
                    string resultText = File.ReadAllText(outputPath);
                    Console.WriteLine($"\"{resultText}\"");
                    Console.WriteLine("-----------------------------------------------------------------------");
                }

                Console.WriteLine($"Результат сохранен в файл: {outputPath}");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
                Console.WriteLine("Убедитесь, что файл существует по пути: C:\\DataSprint5\\InPutDataFileTask7V13.txt");
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