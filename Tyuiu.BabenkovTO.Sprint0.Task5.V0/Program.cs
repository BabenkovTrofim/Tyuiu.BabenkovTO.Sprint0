using Tyuiu.BabenkovTO.Sprint0.Task5.V0.Lib;
class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("A + B = " + DataService.Addiction(5, 5));
        Console.WriteLine("A - B = " + DataService.Subtraction(6, 3));
        Console.WriteLine("A * B = " + DataService.Multiplication(8, 3));
        Console.WriteLine("A / B = " + DataService.Division(45, 0));
    }
}