using System;
class EvenOdd{
    public static void Main(string[] args){

        //taking input from the user
        Console.Write("Enter a natural number: ");
        int n = int.Parse(Console.ReadLine());
        if (n <= 0){
            Console.WriteLine("Invalid input");
            return;
        }
        //initializing the arrays
        int[] even = new int[n / 2 + 1];
        int[] odd = new int[n/ 2 + 1];

        int evenI = 0, oddI = 0;
        for (int i = 1; i <= n; i++){
            if (i % 2 == 0){
                even[evenI++] = i;
            }
            else{
                odd[oddI++] = i;
            }
        }

        Console.WriteLine("Odd Numbers: ");
        for (int i = 0; i < oddI; i++)
            Console.Write(odd[i] + " ");

        Console.WriteLine("Even Numbers: ");
        for (int i = 0; i < evenI; i++)
            Console.Write(even[i] + " ");
    }
}
