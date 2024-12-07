using System.IO;
using Tyuiu.KonstantinovaJN.Sprint5.Task0.V29.Lib;

namespace Tyuiu.KonstantinovaJN.Sprint5.Task0.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\terwi\source\repos\Tyuiu.KonstantinovaJN.Sprint5\Tyuiu.KonstantinovaJN.Sprint5.Task0.V29\bin\Debug\net8.0\OutPutFileTask0.txt";

            FileInfo fileinfo = new FileInfo(path);

            bool fileExists = fileinfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);

        }
    }
    
}