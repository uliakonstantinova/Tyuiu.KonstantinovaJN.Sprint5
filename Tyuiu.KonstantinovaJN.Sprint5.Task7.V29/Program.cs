using Tyuiu.KonstantinovaJN.Sprint5.Task7.V29.Lib;

namespace Tyuiu.KonstantinovaJN.Sprint5.Task7.V29
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт 5 | Выполнила: Константинова Ю. Н.| ИСПБ-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту.                *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #29                                                             *");
            Console.WriteLine("* Выполнила: Константинова Юлия Николаевна | ИСПБ-24-1                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл С:\\DataSprint5\\InPutDataFileTask7V29.txt, в котором есть     *");
            Console.WriteLine("* набор символьных данных. Удалить все однозначные числа из файла.        *");
            Console.WriteLine("* Полученный результат сохранить в файл OutPutDataFileTask7V29.txt.       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string pathSaveFile = Path.Combine(Path.GetTempPath(), "InPutDataFileTask7V29.txt");
            string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask7V29.txt");
            Console.WriteLine("Данные хранятся в файле: " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Находится в файле: ");
            pathSaveFile = ds.LoadDataAndSave(path);

            Console.WriteLine();
            Console.ReadKey();
        }
    }  
}