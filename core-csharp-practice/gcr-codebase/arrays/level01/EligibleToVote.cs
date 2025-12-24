using System;
class EligibleToVote{
    public static void Main(string[] args){

        //intializing the array
        int[] ages=new int[10];
        //taking ages as input from the users 
        for(int i=0;i<ages.Length;i++){
            Console.WriteLine("Enter the age of the student: ");
            ages[i]= int.Parse(Console.ReadLine());

        }

        //checking the eligibility of students to vote
        foreach (int  age in ages){
            if(ages>=18){
                Console.WriteLine("Eligible to vote");
            }
            else{
                Console.WriteLine("Not eligible to vote");
            }
        }

    }
}