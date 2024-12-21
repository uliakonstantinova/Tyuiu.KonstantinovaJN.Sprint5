﻿using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KonstantinovaJN.Sprint5.Task2.V23.Lib;

public class DataService : ISprint5Task2V23
{
    public string SaveToFileTextData(int[,] matrix)
    {
        string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.csv");

        FileInfo fileinfo = new FileInfo(path);
        bool fileExists = fileinfo.Exists;

        if (fileExists)
        {
            File.Delete(path);
        }

        int rows = matrix.GetUpperBound(0) + 1;
        int columns = matrix.Length / rows;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                if (matrix[i, j] % 2 != 0)
                {
                    matrix[i, j] = 0;
                }
            }
        }

        string str = "";
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                if (j != columns - 1)
                {
                    str += matrix[i, j] + ";";
                }
                else
                {
                    str += matrix[i, j];
                }
            }
            if (i != rows - 1)
            {
                File.AppendAllText(path, str + Environment.NewLine);
            }
            else
            {
                File.AppendAllText(path, str);
            }
            str = "";
        }
        return path;
    }
}
