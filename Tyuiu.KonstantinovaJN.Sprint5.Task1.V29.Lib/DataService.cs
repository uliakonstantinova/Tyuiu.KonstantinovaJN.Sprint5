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
                if (t == 0)
                {
                    f = 0;
                }
                else
                {
                    f = (r / t) + Math.Cos(x) + 7 * x - 2;
                }
                strF = Math.Round(f, 2).ToString();

                if (x != stopValue)
                {
                    File.AppendAllText(path, strF + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, strF);
                }
            }
            return path;

        }
    }
}
