using System.Numerics;

namespace Tyuiu.BabenkovTO.Sprint0.Task7.V0.Lib
{
    public class DataService
    {
        public static int[] AdditionArrays(int[] numsOne, int[] numsTwo)
        {
            var res = new int[5];
            for(int i = 0; i < numsOne.Length; i++)
            {
                res[i] = (numsOne[i] + numsTwo[i]);
            }
            return res;
        }
    }
}
