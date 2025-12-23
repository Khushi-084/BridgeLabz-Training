using System;
class CountDigit{
    public static void Main(string[] args){

        //taking input from user
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());
        int count = 0;
        if (number == 0){
            count = 1;
        }
        else{
            // handling negative numbers
            number = Math.Abs(number); 

            while (number != 0)
            {
                number /= 10;
                count++;
            }
        }

        Console.WriteLine("Number of digits = " + count);
    }
}
