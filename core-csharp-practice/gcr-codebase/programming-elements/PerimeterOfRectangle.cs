class PerimeterOfRectangle
{
    static void Main(string[] args)
    {
        // Input length and breadth
        Console.Write("Enter length: ");
        double length = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter breadth: ");
        double breadth = Convert.ToDouble(Console.ReadLine());

        // Perimeter formula
        double perimeter = 2 * (length + breadth);

        // Output result
        Console.WriteLine("Perimeter of Rectangle = " + perimeter);
    }
}
