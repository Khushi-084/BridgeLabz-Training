using System;
class Handshake{

    //method to calculate maximum number of handshakes
    public static void maxShakes(int num){
        int handshakes = (num * (num - 1)) / 2;
        return handshakes;
    }
    public static void Main(string[] args){

        //taking input
        Console.Write("Number:"); 
        int num = int.Parse(Console.ReadLine());

        //calling the method
        int result = maxShakes(num);

        //output
        Console.WriteLine("The max number of handshakes are " + result);
    }
}