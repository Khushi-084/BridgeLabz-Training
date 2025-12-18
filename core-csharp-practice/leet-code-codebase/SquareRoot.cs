class SquareRootExample
{
    static void Main(String[] args)
    {
        Console.Write("Enter a number: ");
        double num = Convert.ToDouble(Console.ReadLine());

        double result = Math.Sqrt(num);

        Console.WriteLine("Square root = " + result);
    }
}
