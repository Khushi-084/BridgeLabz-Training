
using System;
class Factorial{  
  static void Main(string [] args){ 
    //initializing fact variable 
    int fact=1;  

    //taking input from user
    Console.WriteLine("Enter a positive integer");  
    int number=Convert.ToInt32(Console.ReadLine());

    //checking whether the number is positive integer
    if(number<0){
      Console.WriteLine("Wrong input");
    }else{
      int i=1;  
      //calculating factorial using while loop
      while(i<=number){    
        fact=fact*i;    
        i++;    
      }  
      //output  
      Console.WriteLine("The factorial of " + number + " is: " + fact);  
    }  
  }  
}