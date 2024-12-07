using Tyuiu.KonstantinovaJN.Sprint5.Task1.V29.Lib;

namespace Tyuiu.KonstantinovaJN.Sprint5.Task1.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");

            FileInfo fileinfo = new FileInfo(path);

            bool fileExists = fileinfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}