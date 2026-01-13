using System;

// Program to find the first negative number in an array
class FirstNegativeNumber{
    public static void Main(String[] args){
        // Get array size from user
        Console.Write("Enter array size: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];      // Declare array
        // Get array elements from user
        Console.WriteLine("Enter array elements:");
        for (int i = 0; i < n; i++)        
            arr[i] = int.Parse(Console.ReadLine());

        int index = -1;     // Initialize index for first negative number

        for (int i = 0; i < n; i++){
            if (arr[i] < 0){        // Check for negative number
                index = i;         // Store index
                break;
            }
        }

        if (index != -1)
            Console.WriteLine("First negative number at index: " + index);
        else
            Console.WriteLine("No negative number found");
    }
}
