using Tyuiu.KonstantinovaJN.Sprint5.Task6.V18.Lib;

namespace Tyuiu.KonstantinovaJN.Sprint5.Task6.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт 5 | Выполнила: Константинова Ю. Н.| ИСПБ-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Обработка текстовых файлов.                                       *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнила: Константинова Юлия Николаевна | ИСПБ-24-1                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл С:\\DataSprint5\\InPutDataFileTask6V18.txt, в котором есть     *");
            Console.WriteLine("* набор символьных данных. Найти количество одноразрядных чисел в строке. *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = Path.Combine(Path.GetTempPath(), "InPutFileTask6V18.txt");
            Console.WriteLine("Данные хранятся в файле: " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.LoadFromDataFile(path);

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}