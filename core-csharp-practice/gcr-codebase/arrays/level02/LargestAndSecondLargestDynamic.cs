using System;
class LargestAndSecondLargestDynamic{
    public static void Main(string[] args){

        //take input from the user
        Console.Write("Enter the number: ");
        int num=Convert.ToInt32(Console.ReadLine());

        int maxDigit=10;
        int[] digit=new int[maxDigit];
        int index=0;

        //initialising the array dynamically
        while(num!=0){
            if(index==maxDigit){
                maxDigit+=10;
                int[] temp=new int[maxDigit];
                for(int i=0;i<digit.Length;i++){
                    temp[i]=digit[i];
                }
                digit=temp;
            }
            digit[index]=num%10;
            index++;
            num=num/10;
        }

        //finding the largest and second largest
        int largest=0;
        int secondLargest=0;
        for(int i=0;i<idx;i++){
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