﻿using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.KonstantinovaJN.Sprint5.Task5.V10.Lib
{
    public class DataService : ISprint5Task5V10
    {
        public double LoadFromDataFile(string path)
        {
            double res = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (Convert.ToDouble(line) % 2 == 0)
                    {
                        res += Convert.ToDouble(line);
                    }
                }
            }
            return Math.Round(res, 3);
        }
    }
}