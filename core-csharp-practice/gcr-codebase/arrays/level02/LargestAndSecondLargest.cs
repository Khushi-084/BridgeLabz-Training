using System;
class LargestAndSecondLargest{
    static void Main(string[] args){


        //taking input from the user
        Console.Write("Enter the number: ");
        int number=Convert.ToInt32(Console.ReadLine());

        //initialising the array
        int maxDigit=10;
        int[] digit=new int[maxDigit];
        int index=0;

        //storing the digits in array
        while(number!=0 && index<maxDigit){
            digit[index]=number%10;
            index++;
            number=number/10;
        }
         
        //searching the largest and second largest digit
        int largest=0;
        int secondLargest=0;
        for(int i=0;i<index;i++){
            if(digit[i]>largest){
                secondLargest=largest;
                largest=digit[i];
            }else if(digit[i]>secondLargest && digit[i]!=largest){
                secondLargest=digit[i];
            }
        }

        //output
        Console.WriteLine("Largest = " + largest);
        Console.WriteLine("Second Largest = " + secondLargest);

    }
}