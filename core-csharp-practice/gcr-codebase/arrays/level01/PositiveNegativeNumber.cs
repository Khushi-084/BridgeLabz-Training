using System;
class PositiveNegativeNumber{
    public static void Main(string[] args){

        //intializing the array
        int[] numbers=new int[5];

        //taking numbers as input from the users 
        for(int i=0;i<numbers.Length;i++){
            Console.WriteLine("Enter a number number: ");
            numbers[i]= int.Parse(Console.ReadLine());

        }

        //checking whether the number is positive or negative
        foreach (int  num in numbers){
            if(num>0){
                Console.WriteLine("Positive");
            } else if(num==0){
                Console.WriteLine("Zero");
            }
            else{
                Console.WriteLine("Negative");
            }

        // comparison of first and last number of the given array 
        if(numbers[0]>numbers[4]){
            Console.WriteLine("First number is greater than the last number.");
        } else if(numbers[0]<numbers[4]){
            Console.WriteLine("Last number is greater than the first number.");
        }
        else{
            Console.WriteLine("First number is equal to last number.");
        }
    }
  }
}