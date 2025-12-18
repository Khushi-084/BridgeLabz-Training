class PrimeNumber
{
    static void Main(string[] args)
    {
        // Input number
        Console.Write("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        bool isPrime = true;

        // Prime logic
        if (n <= 1)
        {
            isPrime = false;
        }
        else
        {
            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
        }

        // Output
        if (isPrime)
        {
            Console.WriteLine(n + " is a Prime number.");
        }
        else
        {
            Console.WriteLine(n + " is NOT a Prime number.");
        }
    }
}
