using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.Tidzhanin.Sprint5.Task7.V13.Lib;

namespace Tyuiu.Tidzhanin.Sprint5.Task7.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestLoadDataAndSave()
        {
            DataService ds = new DataService();

            // Создаем тестовый файл с данными из примера
            string inputPath = Path.Combine(Path.GetTempPath(), "TestInputFileTask7V13.txt");
            File.WriteAllText(inputPath, "Hello, Мир! Это Is My First Program.");

            string outputPath = ds.LoadDataAndSave(inputPath);

            Assert.IsTrue(File.Exists(outputPath));

            // Проверяем содержимое результирующего файла
            string resultText = File.ReadAllText(outputPath);
            string expected = "H, Мир! Это I M F P.";

            Assert.AreEqual(expected, resultText);

            File.Delete(inputPath);
            File.Delete(outputPath);
        }

      
    }
}