
class AverageOfThreeNumbers
{
    static void Main(string[] args)
    {
        // Input three numbers
        Console.Write("Enter first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter third number: ");
        double num3 = Convert.ToDouble(Console.ReadLine());

        // Calculate average
        double average = (num1 + num2 + num3) / 3;

        // Output result
        Console.WriteLine("Average = " + average);
    }
}
