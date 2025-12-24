using System;
class FactorsOfArray{
    public static void Main(string[] args){
        //taking input from the user
       Console.Write("Enter a number:");
       int number=int.Parse(Console.ReadLine());

        //initializing the array
        int maxFactor=10;
        int[] factors=new int[maxFactor];
        int index=0;
        for(int i=1;i<=number;i++){
            if(number%i==0){
                if(index==maxFactor){
                    maxFactor *=2;
                    int[] temp=new int[maxFactor];
                    Array.Copy(factors,temp,factors.Length);
                    factors=temp;
                }
                factors[index++]=i;
            }
        }

        //output
        Console.WriteLine("Factors: ");
        for(int i=0;i<index;i++){
            Console.Write(factors[i] + " ");
        }



    }
}