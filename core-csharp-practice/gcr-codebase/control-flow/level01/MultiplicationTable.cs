using System;
class MultiplicationTable{
  static void Main(string [] args){

    //taking input from user
    Console.WriteLine("Enter an integer to print multiplication table from 6 to 9");
    int num=Convert.ToInt32(Console.ReadLine());


    //using for loop to find multiplication table
    for(int i=6;i<=9;i++){
      Console.WriteLine(num + " * " + i + " = " + (num*i));
    }
  }
}