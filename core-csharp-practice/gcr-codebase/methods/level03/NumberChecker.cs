using System;
class NumberChecker{
    // Method to find count of digits
    public static int CountDigits(int number){
    if (number == 0)
        return 1;
    int count = 0;
    int temp = number;
    while (temp != 0){
        count++;
        temp /= 10;
    }
    return count;
}

    // Method to store digits in an array
    public static int[] StoreDigits(int number) {
        int count = CountDigits(number);
        int[] digits = new int[count];
        int temp = number;
        for (int i = count - 1; i >= 0; i--){
            digits[i] = temp % 10;
            temp /= 10;
        }
        return digits;
    }

    

    // Method to check Armstrong Number
    public static bool IsArmstrongNumber(int number, int[] digits){
        int sum = 0;
        int power = digits.Length;
        foreach (int digit in digits){
            sum += (int)Math.Pow(digit, power);
        }
        return sum == number;
    }

    // Method to find largest and second largest digits
    public static void LargestAndSecondLargest(int[] digits){
        int largest = Int32.MinValue;
        int secondLargest = Int32.MinValue;
        foreach (int digit in digits){
            if (digit > largest) {
                secondLargest = largest;
                largest = digit;
            }
            else if (digit > secondLargest && digit != largest) {
                secondLargest = digit;
            }
        }

        Console.WriteLine("Largest Digit: " + largest);
        Console.WriteLine("Second Largest Digit: " + secondLargest);
    }

    // Method to find smallest and second smallest digits
    public static void SmallestAndSecondSmallest(int[] digits) {
        int smallest = Int32.MaxValue;
        int secondSmallest = Int32.MaxValue;
        foreach (int digit in digits){
            if (digit < smallest){
                secondSmallest = smallest;
                smallest = digit;
            }
            else if (digit < secondSmallest && digit != smallest){
                secondSmallest = digit;
            }
        }

        Console.WriteLine("Smallest Digit: " + smallest);
        Console.WriteLine("Second Smallest Digit: " + secondSmallest);
    }

    // Method to check Duck Number
    public static bool IsDuckNumber(int[] digits){
    for (int i = 1; i < digits.Length; i++) {
        if (digits[i] == 0)
            return true;
    }
    return false;
}


    public static void Main(string[] args){

        // Taking input
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());

        // Counting digits
        int count = NumberChecker.CountDigits(number);
        Console.WriteLine("Number of Digits: " + count);

        // Storing digits
        int[] digits = NumberChecker.StoreDigits(number);

        Console.WriteLine("Digits of the number:");
        foreach (int d in digits)
        {
            Console.Write(d + " ");
        }
         Console.WriteLine();


        // Duck number check
        if (NumberChecker.IsDuckNumber(digits))
            Console.WriteLine("It is a Duck Number");
        else
            Console.WriteLine("It is NOT a Duck Number");


        // Armstrong number check
        if (NumberChecker.IsArmstrongNumber(number, digits))
            Console.WriteLine("It is an Armstrong Number");
        else
            Console.WriteLine("It is NOT an Armstrong Number");


        // Largest and second largest
        NumberChecker.LargestAndSecondLargest(digits);


        // Smallest and second smallest
        NumberChecker.SmallestAndSecondSmallest(digits);
    }
}
    

