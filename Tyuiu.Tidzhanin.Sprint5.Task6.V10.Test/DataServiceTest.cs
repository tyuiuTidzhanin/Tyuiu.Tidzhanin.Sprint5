using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.Tidzhanin.Sprint5.Task6.V10.Lib;

namespace Tyuiu.Tidzhanin.Sprint5.Task6.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestLoadFromDataFile()
        {
            DataService ds = new DataService();

            // Создаем тестовый файл с данными из примера
            string path = Path.Combine(Path.GetTempPath(), "TestFileTask6V10.txt");
            File.WriteAllText(path, "Утро, день, вечер, ночь.");

            int result = ds.LoadFromDataFile(path);

            // В тестовых данных слова длиной 4 символа: "Утро" (4), "день" (4), "ночь" (4)
            // "вечер" - 5 символов
            int expected = 3;

            Assert.AreEqual(expected, result);

            File.Delete(path);
      
        }
    }
}