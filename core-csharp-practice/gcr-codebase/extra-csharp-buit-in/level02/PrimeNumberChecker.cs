using System;
class PrimeNumberChecker{
    public static void Main(string[] args){
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        bool isPrime = CheckPrime(number);
        //output
        Console.WriteLine(isPrime ? "Prime Number" : "Not a Prime Number");
    }
    

    //method to check whether the number is prime or not  
    static bool CheckPrime(int num){
        if (num <= 1) return false;
        for (int i = 2; i <= num / 2; i++){
            if (num % i == 0)
                return false;
        }
        return true;
    }
}
