class Fibonacci
{
    static void Main(string[] args)
    {
        Console.Write("Enter number of terms: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int a = 0, b = 1;

        Console.WriteLine("Fibonacci Series:");

        for (int i = 1; i <= n; i++)
        {
            Console.Write(a + " ");
            int next = a + b;
            a = b;
            b = next;
        }
    }
}
