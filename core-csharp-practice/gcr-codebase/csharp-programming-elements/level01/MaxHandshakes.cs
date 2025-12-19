using System;
public class MaxHandshakes{
  public static void Main(String [] args){

    //taking input from user
    Console.WriteLine("Enter the number of Students: ");
    int N = int.Parse(Console.ReadLine());

    //formulating the possible number of handshakes
    int result = (N*(N-1))/2;
    //output
    Console.WriteLine("Possible no. of handshakes is : " + result);
  }
}