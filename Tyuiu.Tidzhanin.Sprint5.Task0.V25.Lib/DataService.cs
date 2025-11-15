using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.Tidzhanin.Sprint5.Task0.V25.Lib
{
    public class DataService : ISprint5Task0V25
    {
        public string SaveToFileTextData(int x)
        {
            double y = (3 * Math.Pow(x, 4) + 1) / Math.Pow(x, 3);
            y = Math.Round(y, 3);

            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");
            File.WriteAllText(path, y.ToString());

            return path;
        }
    }
}