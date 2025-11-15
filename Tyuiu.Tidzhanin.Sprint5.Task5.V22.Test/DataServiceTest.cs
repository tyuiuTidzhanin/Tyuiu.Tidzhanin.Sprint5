using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.Tidzhanin.Sprint5.Task5.V22.Lib;

namespace Tyuiu.Tidzhanin.Sprint5.Task5.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestLoadFromDataFile()
        {
            DataService ds = new DataService();

            // Создаем тестовый файл с данными из примера
            string path = Path.Combine(Path.GetTempPath(), "TestFileTask5V22.txt");
            File.WriteAllText(path, "19.03 11 6.55 5.46 5 1 -6.05 -4.77 -3.4 16 18 -2 11 17 8.63 1 7.56 -6.78 -10 19.91");

            double result = ds.LoadFromDataFile(path);

            // В тестовых данных целые числа, делящиеся на 4: 16, 18, -2, -10
            // Минимальное из них: -10
            double expected = 16;

            Assert.AreEqual(expected, result);

            File.Delete(path);
        }

     
        }
    }
