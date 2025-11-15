using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.Tidzhanin.Sprint5.Task0.V25.Lib;

namespace Tyuiu.Tidzhanin.Sprint5.Task0.V25.Test
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

            string result = File.ReadAllText(path);

            // Проверяем результат для x = 3: (3*3^4 + 1)/3^3 = (3*81 + 1)/27 = (243 + 1)/27 = 244/27 ≈ 9.037
            Assert.AreEqual("9,037", result);
        }
    }
}