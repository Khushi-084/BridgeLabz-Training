using System;

class SimpleInterest{

    //method to calculate simple interest
     public static void Interest(int principle, int rate, int time) {
        int calculation = (principle * rate * time) / 100;
        return calculation;
    }
    public static void Main(string[] args){
        //taking inputs
        Console.Write("Principle"); 
        int principle = int.Parse(Console.ReadLine());
        Console.Write("Rate");
        int rate = int.Parse(Console.ReadLine());
        Console.Write("Time");
        int time = int.Parse(Console.ReadLine());


        //calling the method
        int simpleInt = Interest(principle, rate, time);


        //output
        Console.WriteLine("The simple interest is " + simpleInt + " for Principle " + principle + "Rate of Ineterest" + rate + "and time " + time);
    }
}