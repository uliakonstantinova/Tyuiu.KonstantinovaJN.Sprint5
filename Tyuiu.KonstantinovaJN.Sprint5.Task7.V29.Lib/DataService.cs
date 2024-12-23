using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.KonstantinovaJN.Sprint5.Task7.V29.Lib
{
    public class DataService : ISprint5Task7V29
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = Path.Combine(Path.GetTempPath(), "InPutDataFileTask7V29.txt");

            FileInfo fileinfo = new FileInfo(pathSaveFile);
            bool fileExists = fileinfo.Exists;


            if (fileExists)
            {
                File.Delete(pathSaveFile);
            }

            string strLine = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string strNum = "";
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (line[i] >= '0' && line[i] <= '9')
                        {
                            strNum += line[i];
                        }
                        else
                        {
                            if (strNum.Length > 0)
                            {
                                strLine += strNum + " ";
                                strNum = "";
                            }
                            strLine += line[i];
                        }
                    }
                    if (strNum.Length > 0)
                    {
                        strLine += strNum + " ";
                    }

                    File.AppendAllText(pathSaveFile, strLine + Environment.NewLine);
                    strLine = "";
                }
            }
            return pathSaveFile;
        }
    }
}