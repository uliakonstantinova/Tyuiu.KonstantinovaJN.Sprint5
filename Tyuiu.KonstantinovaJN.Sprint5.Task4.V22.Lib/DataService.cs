using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.KonstantinovaJN.Sprint5.Task4.V22.Lib
{
    public class DataService : ISprint5Task4V22
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            double r = Math.Sin(5.23) - 4 * 5.23;
            double y = Math.Pow(5.23, 3) * r;
            double res = Math.Round(y, 3);

            return res;
        }
    }
}
