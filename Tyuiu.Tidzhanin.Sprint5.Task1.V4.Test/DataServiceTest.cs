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

            string fileContent = File.ReadAllText(path).Trim();
            fileContent = fileContent.Replace("\r", "");

            string expected = "-15,44\n-10,93\n-7,22\n-5,04\n0\n-0,3\n2,57\n6,4\n10,04\n12,72\n14,68";

            Assert.AreEqual(expected, fileContent);

        }
    }
}