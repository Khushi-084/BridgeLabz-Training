class Factorial{
    static void Main(string[] args)
    {
        // Input number
        Console.Write("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        long factorial = 1;

        // Factorial logic
        for (int i = 1; i <= n; i++)
        {
            factorial = factorial * i;
        }

        // Output
        Console.WriteLine("Factorial of " + n + " is: " + factorial);
    }
}
