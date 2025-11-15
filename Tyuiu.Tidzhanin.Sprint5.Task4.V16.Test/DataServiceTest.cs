using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.Tidzhanin.Sprint5.Task4.V16.Lib;

namespace Tyuiu.Tidzhanin.Sprint5.Task4.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestLoadFromDataFile()
        {
            DataService ds = new DataService();

            // Создаем тестовый файл
            string path = Path.Combine(Path.GetTempPath(), "TestFileTask4V16.txt");
            File.WriteAllText(path, "3.5");

            double result = ds.LoadFromDataFile(path);

            // Проверяем вычисление для x = 3.5:
            // cos(3.5) + 3.5² - (2*3.5 / 1.2) 
            // = -0.936 + 12.25 - (7 / 1.2)
            // = 11.314 - 5.833 = 5.481
            double expected = 5.48;

            Assert.AreEqual(expected, result);

            File.Delete(path);
        }


    }
}