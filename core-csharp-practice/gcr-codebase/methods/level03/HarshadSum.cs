using System;
class HarshadSum{
    //method to calculate the sum of digits
    public static int SumOfDigits(int[] arr) {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
            sum += arr[i];
        return sum;
    }

    //method to calculate the sum of squares
    public static double SumOfSquares(int[] arr){
        double sum = 0;
        for (int i = 0; i < arr.Length; i++)
            sum += Math.Pow(arr[i], 2);
        return sum;
    }
 
    //method to check if the number is a Harshad number
    public static bool IsHarshad(int num, int[] arr){
        return num % SumOfDigits(arr) == 0;
    }

    //method to calculate the frequency of digits
    public static int[,] DigitCount(int[] arr){
        int[,] freq = new int[10, 2];
        for (int i = 0; i < 10; i++){
            freq[i, 0] = i;
            freq[i, 1] = 0;
        }
        for (int i = 0; i < arr.Length; i++){
            freq[arr[i], 1]++;
        }

        return freq;
    }
    
    public static void Main(string[] args){
        int number = int.Parse(Console.ReadLine());
        int[] digits = StoreDigits(number);
        // Sum of digits
        int sum = SumOfDigits(digits);
        Console.WriteLine("Sum of Digits: " + sum);
        // Sum of squares of digits
        double sumSquares = SumOfSquares(digits);
        Console.WriteLine("Sum of Squares of Digits: " + sumSquares);
        // Harshad Number check
        if (IsHarshad(number, digits))
            Console.WriteLine("The number is a Harshad Number");
        else
            Console.WriteLine("The number is NOT a Harshad Number");

        // Digit Frequency
        int[,] frequency = DigitCount(digits);

        Console.WriteLine("Digit Frequency");
        for (int i = 0; i < 10; i++){
            if (frequency[i, 1] > 0){
                Console.WriteLine(frequency[i, 0] + " " + frequency[i, 1]);
            }
        }
    }
}
