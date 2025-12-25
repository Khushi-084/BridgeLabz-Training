using System;
class Athlete{
    //method to calculate the number of rounds
    public static int rounds(int perimeter) {
        int rounds = 5000 / perimeter;
        return rounds;
    }
    public static void Main(string[] args) {
        //taking inputs from user
        Console.Write("Side 1");
        int side1 = int.Parse(Console.ReadLine());
        Console.Write("Side 2");
        int side2 = int.Parse(Console.ReadLine());
        Console.Write("Side 3");
        int side3 = int.Parse(Console.ReadLine());


        //calculating the perimeter
        int perimeter = side1 + side2 + side3;
        int result = rounds(perimeter);


        //output
        Console.WriteLine("The number of rounds are " + result);
    }
}