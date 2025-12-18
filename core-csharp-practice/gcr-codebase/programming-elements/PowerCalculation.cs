class PowerCalculation
{
    static void Main(string[] args)
    {
        // Input base and exponent
        Console.Write("Enter base: ");
        double baseValue = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter exponent: ");
        double exponent = Convert.ToDouble(Console.ReadLine());

        // Calculate power
        double result = Math.Pow(baseValue, exponent);

        // Output result
        Console.WriteLine("Result = " + result);
    }
}
