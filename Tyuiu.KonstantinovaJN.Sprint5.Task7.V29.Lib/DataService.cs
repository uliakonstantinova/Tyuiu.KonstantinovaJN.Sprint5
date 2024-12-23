using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.Text.RegularExpressions;

namespace Tyuiu.KonstantinovaJN.Sprint5.Task7.V29.Lib
{
    public class DataService : ISprint5Task7V29
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = Path.Combine(Path.GetTempPath(), "OutPutFileTask7.txt");

            FileInfo fileinfo = new FileInfo(pathSaveFile);
            if (fileinfo.Exists)
            {
                File.Delete(pathSaveFile);
            }

            string content = File.ReadAllText(path);
            string pattern = Regex.Replace(content, @"\b[0-9]\b", string.Empty);
            string clean = Regex.Replace(pattern, @"\s+", " ").Trim();
            File.WriteAllText(pathSaveFile, clean);

            return pathSaveFile;
        }
    }
}