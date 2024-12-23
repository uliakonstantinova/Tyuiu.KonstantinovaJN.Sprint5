using Tyuiu.KonstantinovaJN.Sprint5.Task6.V18.Lib;

namespace Tyuiu.KonstantinovaJN.Sprint5.Task6.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask6V18.txt");

            var res = ds.LoadFromDataFile(path);
            int wait = 2;

            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask6V18.txt");

            FileInfo fileinfo = new FileInfo(path);

            bool fileExists = fileinfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}