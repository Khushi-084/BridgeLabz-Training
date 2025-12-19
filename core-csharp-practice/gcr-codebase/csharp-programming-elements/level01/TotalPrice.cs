using System;
public class TotalPrice{
  public static void Main(String [] args){

    //taking input from user
    Console.WriteLine("Enter the unit price of the item: ");
    float unitprice = float.Parse(Console.ReadLine());
    Console.WriteLine("Enter the Quantity to be baught: ");
    int quant = int.Parse(Console.ReadLine());
    //formulating the total price
    float total = unitprice*quant;
    //output
    Console.WriteLine("The total purchase in INR " + total + " if the quantity " + quant + " and unit price is INR " + unitprice);
  }
}