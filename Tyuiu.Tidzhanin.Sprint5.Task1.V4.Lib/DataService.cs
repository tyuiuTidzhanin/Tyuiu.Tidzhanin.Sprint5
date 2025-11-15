using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.Tidzhanin.Sprint5.Task1.V4.Lib
{
    public class DataService : ISprint5Task1V4
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");

            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine("x\tf(x)");
                writer.WriteLine("----------------");

                for (int x = startValue; x <= stopValue; x++)
                {
                    double value;

                    // Проверка деления на ноль
                    if (x + 1 == 0)
                    {
                        value = 0;
                    }
                    else
                    {
                        value = Math.Cos(x) / (x + 1) - Math.Cos(x) * 1.3 + 3 * x;
                        value = Math.Round(value, 2);
                    }

                    writer.WriteLine($"{x}\t{value}");
                }
            }

            return path;
        }
    }
}