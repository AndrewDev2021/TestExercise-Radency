namespace TestExercise;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"{Recalculation.Order("2000 11 11 10003 22 123 1234000")}" + // Valid data
                          $"\n{Recalculation.Order("45 34 24 108 36 76 58 64 130 80")}" +
                          $"\n{Recalculation.Order("    2022 70 123    3344 13 ")}" +
                          $"\n{Recalculation.Order("45 34 24 d108 76 58 64 130 80")}" + //Invalid data
                          $"\n{Recalculation.Order("45 34 24 -108 76 58 64 130 80")}");
    }
}