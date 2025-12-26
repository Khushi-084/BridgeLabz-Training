using System;
class PalindromeRev{
    //method to count digits
    public static int CountDigits(int num){
        return num.ToString().Length;
    }

     //method to check if two arrays are equal
    public static bool AreEqual(int[] arr1, int[] arr2){
        if (arr1.Length != arr2.Length)
        {
            return false;
        }
        for (int i = 0; i < arr1.Length; i++)
            if (arr1[i] != arr2[i])
            {
                return false;
            }
        return true;
    }

    //method to store digits
    public static int[] Store(int num){
        string s = num.ToString();
        int[] arr = new int[s.Length];
        for (int i = 0; i < s.Length; i++)
            arr[i] = s[i] - '0';
        return arr;
    }

     //method to check if the number is a duck number
    public static bool IsDuckNumber(int[] arr){
        for (int i = 0; i < arr.Length; i++)
            if (arr[i] != 0)
            {
                return true;
            }
        return false;
    }

    //method to reverse
    public static int[] Reverse(int[] arr){
        int[] rev = new int[arr.Length];
        for (int i = 0; i < arr.Length; i++)
            rev[i] = arr[arr.Length - 1 - i];
        return rev;
    }
    
   
    

    //method to check if the number is a palindrome
    public static bool IsPalindrome(int[] arr){
        return AreEqual(arr, Reverse(arr));
    }

   

    //mqain method
    public static void Main(string[] args){
        Console.Write("Enter a number ");
        int num = int.Parse(Console.ReadLine());

        // Count digits
        int count = CountDigits(num);
        Console.WriteLine("Number of Digits: " + count);

        // Store digits
        int[] digits = Store(num);
        Console.Write("Digits: ");
        for (int i = 0; i < digits.Length; i++)
        {
            Console.Write(digits[i] + " ");
        }
        Console.WriteLine();

        // Reverse digits
        int[] reversed = Reverse(digits);
        Console.Write("Reversed Digits: ");
        for (int i = 0; i < reversed.Length; i++)
        {
            Console.Write(reversed[i] + " ");
        }
        Console.WriteLine();

        // Compare arrays
        if (AreEqual(digits, reversed))
        {
            Console.WriteLine("Equal");
        }
        else
        {
            Console.WriteLine("Unequal");
        }

        // Duck number 
        if (IsDuckNumber(digits))
        {
            Console.WriteLine("Duck Number");
        }
        else
        {
            Console.WriteLine("Not Duck Number");
        }

        // Palindrome 
        if (IsPalindrome(digits))
        {
            Console.WriteLine("Palindrome");
        }
        else
        {
            Console.WriteLine("Not Palindrome");
        }

       
    }
}


