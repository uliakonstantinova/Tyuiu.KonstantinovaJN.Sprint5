﻿using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.KonstantinovaJN.Sprint5.Task6.V18.Lib
{
    public class DataService : ISprint5Task6V18
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] words = line.Split(' ');
                    foreach (var word in words)
                    {
                        if (int.TryParse(word, out int number))
                        {
                            if (number >= 0 && number <= 9)
                            {
                                count++;
                            }
                        }
                    }
                }
                return count;
            }
        }
    }
}
