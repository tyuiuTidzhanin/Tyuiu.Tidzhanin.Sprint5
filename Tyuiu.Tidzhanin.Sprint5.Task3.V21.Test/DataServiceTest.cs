using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.Tidzhanin.Sprint5.Task3.V21.Lib;

namespace Tyuiu.Tidzhanin.Sprint5.Task3.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestSaveToFileTextData()
        {
            DataService ds = new DataService();

            int x = 3;
            string path = ds.SaveToFileTextData(x);

            Assert.IsTrue(File.Exists(path));

            // Читаем из бинарного файла
            double result;
            using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                result = double.Parse(reader.ReadString());
            }

            // Проверяем вычисление: (3² + 1) / √(4*3² - 3) = (9 + 1) / √(36 - 3) = 10 / √33 ≈ 10 / 5.744 ≈ 1.741
            double expected = 1.741;
            Assert.AreEqual(expected, result);
        }
    }
}