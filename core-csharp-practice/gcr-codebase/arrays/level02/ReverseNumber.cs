using System;


class ReverseNumber{
    public static void Main(string[] args){
        

        //take input from the user
        Console.Write("Enter the number: ");
        int number=int.Parse(Console.ReadLine());

        int temp=num;
        int count=0;
 
        //calculating the length of the number
        while(temp!=0){
            count++;
            temp=temp/10;
        }
        int[] digit=new int[count];
        //reversing the number
        for(int i=0;i<count;i++){
            digit[i]=number%10;
            number=number/10;
        }
        //output
        Console.Write("Reversed Number: ");
        for(int i=0;i<count;i++){
            Console.Write(digit[i]);
        }
    } 
}