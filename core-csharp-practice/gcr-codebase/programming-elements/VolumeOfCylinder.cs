class VolumeOfCylinder
{
    static void Main(string[] args)
    {
        // Enter the radius of the cylinder
        Console.Write("Enter radius: ");
        int radius = Convert.ToInt32(Console.ReadLine());

        // Enter the height of the cylinder
        Console.Write("Enter height: ");
        int height = Convert.ToInt32(Console.ReadLine());

        // Calculate volume
        double volume = Math.PI * Math.Pow(radius, 2) * height;

        // Output result
        Console.WriteLine("The volume of the cylinder is: " + volume);
    }
}
