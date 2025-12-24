using System;
class MeanHeight{
    public static void Main(string[] args){

        //initializing the array
        double[] heights= new double[11];
        double sum=0.0;

        //taking heights as input from the user
        for(int i=0;i<heights.Length;i++){
            Console.Write("Enter the height of the player " + (i+1) + ": ");
            heights[i]= double.Parse(Console.ReadLine());
            sum+= heights[i];      //calculate the sum of heights
        }

        //calculating the mean height
        double mean= sum/11;

        //output
        Console.WriteLine("The mean height of the football team is " + mean);
    }
}