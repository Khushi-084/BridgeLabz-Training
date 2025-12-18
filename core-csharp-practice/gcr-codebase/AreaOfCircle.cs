
class AreaOfCircle
{
    static void Main(string[] args)
    {
        // Input the radius of the circle
        Console.Write("Enter the radius of the circle: ");
        int radius = Convert.ToInt32(Console.ReadLine());

        // Calculate area
        int area = (int)(Math.PI * radius * radius);

        // Output result
        Console.WriteLine("Area of the circle: " + area);
    }
}
