namespace Tyuiu.BabenkovTO.Sprint0.Task5.V0.Lib
{
    public class DataService
    {
        public static int Addiction(int a, int b)
        {
            return a + b;
        }
        public static int Subtraction(int a, int b)
        {
            return a - b;
        }
        public static int Multiplication(int a, int b)
        {
            return a * b;
        }
        public static int Division(int a, int b)
        {
            if(b != 0)
            {
                return a / b;
            }
            else
            {
                Console.WriteLine($"Переменная b = {b}, на {b} делить нельзя");
                return -1;
            }
        }
    }
}
