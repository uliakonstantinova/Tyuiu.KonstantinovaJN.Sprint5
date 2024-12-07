using Tyuiu.KonstantinovaJN.Sprint5.Task1.V29.Lib;

namespace Tyuiu.KonstantinovaJN.Sprint5.Task1.V29
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт 5 | Выполнила: Константинова Ю. Н.| ИСПБ-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема:                        *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #29                                                             *");
            Console.WriteLine("* Выполнила: Константинова Юлия Николаевна | ИСПБ-24-1                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана функция F(x) = (sin(x) / x + 1.2) + cos(x) * 7x - 2 на диапазоне   *");
            Console.WriteLine("* [-5, 5] с шагом 1. Произвести проверку деления на ноль, в случае деления*");
            Console.WriteLine("*  на ноль вернуть значение 0. Результат сохранить в текстовый файл и     *");
            Console.WriteLine("* вывести в таблицу. Значения округлить до 2 знаков после запятой.        *");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("startValue = " + startValue);
            Console.WriteLine("stopValue = " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(startValue, stopValue);

            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан.");

            Console.ReadKey();
        }
    }
}