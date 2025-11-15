using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.Tidzhanin.Sprint5.Task1.V4.Lib;

namespace Tyuiu.Tidzhanin.Sprint5.Task1.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestSaveToFileTextData()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;
            string path = ds.SaveToFileTextData(startValue, stopValue);

            Assert.IsTrue(File.Exists(path));

            string fileContent = File.ReadAllText(path);

            // Проверяем, что файл содержит заголовки
            Assert.IsTrue(fileContent.Contains("x\tf(x)"));

            // Проверяем, что файл содержит данные для всех x от -5 до 5
            for (int x = startValue; x <= stopValue; x++)
            {
                Assert.IsTrue(fileContent.Contains(x.ToString()));
            }

            // Проверяем особый случай при x = -1 (деление на ноль)
            Assert.IsTrue(fileContent.Contains("-1\t0"));
        }
    }
}