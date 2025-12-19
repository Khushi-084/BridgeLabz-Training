using System;

class DiscountedAmountAndDiscountedFee
{
  public static void Main(string[] args){
    //initializing variables
    double fee=125000;
    double discountPercent=10;

    //formula to calculate discount amount and fees
    double discount=(discountPercent/100)*fee;
    double discountedfee=fee-discount;

    //output
    Console.WriteLine("The discount amount is INR " +discount+ " and final dicounted fee is INR " +discountedfee);
  }
}