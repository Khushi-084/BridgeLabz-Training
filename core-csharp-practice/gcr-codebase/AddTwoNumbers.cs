
class AddTwoNumbers
{
    static void Main(string[] args)
    {
        // Taking input from user
        Console.Write("Enter first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        // Calculating sum
        int sum = num1 + num2;

        // Printing result
        Console.WriteLine("Sum = " + sum);
    }
}
