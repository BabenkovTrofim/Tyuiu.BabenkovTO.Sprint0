using System.Numerics;

namespace Tyuiu.BabenkovTO.Sprint0.Task6.V0.Lib
{
    public class DataService
    {
        public static object AdditionArray(int[] numbers)
        {
            int total = 0;
            for (int index = 0; index < numbers.Length; index++)
            {
                total += numbers[index];
            }
            return total;
        }
        public static object SubtractionArray(int[] numbers)
        {
            int total = 0;
            int index = 0;
            while (index < numbers.Length)
            {
                total -= numbers[index];
                index++;
            }
            return total;
        }
        public static object MultiplicationArray(int[] numbers)
        {
            int index = 0;
            int total = 1;
            do
            {
                total *= numbers[index];
                index++;
            }
            while (index < numbers.Length);
            return total;
        }   
    }
}
