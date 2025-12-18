class PalindromeNumber
{
    public bool IsPalindrome(int x)
    {
        if (x < 0)
            return false;

        long reversed = 0;
        int y = x;

        while (y > 0)
        {
            reversed = reversed * 10 + y % 10;
            y /= 10;
        }

        return reversed == x;
    }

    static void Main(string[] args)
    {
        PalindromeNumber obj = new PalindromeNumber();

        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (obj.IsPalindrome(num))
            Console.WriteLine("Palindrome Number");
        else
            Console.WriteLine("Not a Palindrome Number");
    }
}
