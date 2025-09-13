using System.Numerics;
using Tyuiu.BabenkovTO.Sprint0.Task7.V0.Lib;
internal class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Спринт #0 | Выполнил: Бабенков Т. О. | ИИПб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #0                                                               *");
        Console.WriteLine("* Тема: Создание итогового решения по спринту                             *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #0                                                              *");
        Console.WriteLine("* Выполнил: Бабенков Трофим Олегович | ИИПб-25-1                          *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать консольную программу на С#, которая суммирует значения двух    *");
        Console.WriteLine("* одинаковых массивов по длинне.                                          *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");


        Console.WriteLine("Значение элементов массива #1: ");
        var num1 = new int[] { 1, 2, 3, 4, 5 };
        for (int i = 0; i < num1.Length; i++)
        {
            if(i != num1.Length - 1)
            {
                Console.Write(num1[i] + ", ");
            }
            else
            {
                Console.Write(num1[i]);
            }
        }
        Console.WriteLine();
        Console.WriteLine("Значение элементов массива #2: ");
        var num2 = new int[] { 1, 2, 3, 4, 5 };
        for (int i = 0; i < num2.Length; i++)
        {
            if (i != num2.Length - 1)
            {
                Console.Write(num2[i] + ", ");
            }
            else
            {
                Console.Write(num2[i]);
            }
        }
        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        if(num1.Length == num2.Length)
        {
            var result = DataService.AdditionArrays(num1, num2);
            Console.WriteLine("Сумма элементов массивов равна:");
            for (int i = 0; i < result.Length; i++)
            {
                if (i != result.Length - 1)
                {
                    Console.Write(result[i] + ", ");
                }
                else
                {
                    Console.Write(result[i]);
                }
            }
        }
        else
        {
            Console.WriteLine("Оштбка ! Исходные массивы имеют разное количество элементов");
        }
    }
}