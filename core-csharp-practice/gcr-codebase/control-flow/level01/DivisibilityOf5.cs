using System;
class DivisibilityOf5{
	public static void Main(string[] args){
		//Taking input from user
		Console.WriteLine("Enter the number");
		int x=int.Parse(Console.ReadLine());
		
		//divisibility test 
		if(x%5==0){
			Console.WriteLine("The number is divisible by 5");
		}
		else{
			Console.WriteLine("The number is not divisible by 5");
		}
	}
}