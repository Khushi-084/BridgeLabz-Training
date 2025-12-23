using System;
class AbundantNumber{
    public static void Main(string[] args){
        //taking input from user
        Console.WriteLine("Enter a number: ");
        int num=int.Parse(Console.ReadLine());
        int sum=0;

        //iteration to find sum of factors
        for(int i=1;i<num;i++){
            if(num%i==0){
                sum+=i;
            }
        }

        //output
        if(sum>num){
            Console.WriteLine("Abundant Number");
        }
        else{
            Console.WriteLine("Not an Abundant Number")
        }
    }
}