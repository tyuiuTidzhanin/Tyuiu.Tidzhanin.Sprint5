using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.Tidzhanin.Sprint5.Task2.V26.Lib;

namespace Tyuiu.Tidzhanin.Sprint5.Task2.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestSaveToFileTextData()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[3, 3]
            {
                { 2, -3, -3 },
                { -8, 8, 0 },
                { -6, 1, 0 }
            };

            string path = ds.SaveToFileTextData(matrix);

            Assert.IsTrue(File.Exists(path));

            string[] lines = File.ReadAllLines(path);

            // Проверяем количество строк
            Assert.AreEqual(3, lines.Length);

            // Проверяем содержимое
            Assert.AreEqual("1;0;0", lines[0]);
            Assert.AreEqual("0;1;0", lines[1]);
            Assert.AreEqual("0;1;0", lines[2]);
        }
    }
}