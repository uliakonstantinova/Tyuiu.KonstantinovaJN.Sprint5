using System.Globalization;
using System.IO;
using System.Runtime.Serialization.Formatters;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KonstantinovaJN.Sprint5.Task1.V29.Lib
{
    public class DataService : ISprint5Task1V29
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");

            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            double f;
            string strF;
            for (int x = startValue; x <= stopValue; x++)
            {
                double r = Math.Sin(x);
                double t = x + 1.2;

                f = (t != 0) ? (r / t) + Math.Cos(x) + 7 * x - 2 : 0;

                strF = f.ToString("F2", CultureInfo.InvariantCulture);
                strF = Math.Round(f, 2).ToString();

                File.AppendAllText(path, strF + Environment.NewLine);
            }
            return path;
        }
    }
}
