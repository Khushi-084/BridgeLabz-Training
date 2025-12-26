using System;
class PerfectStrong{

    //method to find sum
    public static int Sum(int[] arr){
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        return sum;
    }
    //method to find factors
    public static int[] Factors(int num){
        int count = 0;
        for (int i = 1; i <= num; i++)
            if (num % i == 0) {
                count++;
            }
        int[] arr = new int[count];
        int index = 0;
        for (int i = 1; i <= num; i++)
            if (num % i == 0)
                arr[index++] = i;
        return arr;
    }

 //method to find product
    public static long Product(int[] arr){
        long product = 1;
        for (int i = 0; i < arr.Length; i++)
        {
            product *= arr[i];
        }
        return product;
    }
    //method to find greatest
    public static int Greatest(int[] arr){
        int max = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }
        return max;
    }

    

   

    //method to find product of cube
    public static double ProductOfCube(int[] arr){
        double product = 1;
        for (int i = 0; i < arr.Length; i++)
        {
            product *= Math.Pow(arr[i], 3);
        }
        return product;
    }
 
  //method to check if the number is abundant
    public static bool IsAbundant(int num, int[] arr){
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
            if (arr[i] != num)
            {
                sum += arr[i];
            }
        return sum > num;
    }

//method to check if the number is strong
    public static bool IsStrong(int num){
        int temp = num, sum = 0;

        while (temp > 0)
        {
            int d = temp % 10;
            sum += Factorial(d);
            temp /= 10;
        }
        return sum == num;
    }


 //method to check if the number is deficient
    public static bool IsDeficient(int num, int[] arr){
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
            if (arr[i] != num)
            {
                sum += arr[i];
            }
        return sum < num;
    }

     //method to check if the number is perfect
    public static bool IsPerfect(int num, int[] arr){
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] != num)
            {
                sum += arr[i];
            }
        }
        return sum == num;
    }

      //method to check if the number is strong
    static int Factorial(int num){
        int fact = 1;
        for (int i = 1; i <= num; i++)
        {
            fact *= i;
        }
        return fact;
    }
    
    
    //main method
    public static void Main(string[] args){
        //input
        int num = int.Parse(Console.ReadLine());

        // Find factors
        int[] factors = Factors(num);

        Console.Write("Factors: ");
        for (int i = 0; i < factors.Length; i++){
            Console.Write(factors[i] + " ");
        }
        Console.WriteLine();

        // Greatest factor
        Console.WriteLine("Greatest Factor: " + Greatest(factors));

        // Sum of factors
        Console.WriteLine("Sum of Factors: " + Sum(factors));

        // Product of factors
        Console.WriteLine("Product of Factors: " + Product(factors));

        // Product of cube of factors
        Console.WriteLine("Product of Cube of Factors: " + ProductOfCube(factors));


        // Perfect number  
        if (IsPerfect(num, factors)){
            Console.WriteLine("Perfect Number");
        }
        else{
            Console.WriteLine("Not Perfect Number");
        }


        // Abundant number  
        if (IsAbundant(num, factors)){
            Console.WriteLine("Abundant Number");
        }
        else{
            Console.WriteLine("Not Abundant Number");
        }


        // Deficient number  
        if (IsDeficient(num, factors)){
            Console.WriteLine("Deficient Number");
        }
        else{
            Console.WriteLine("Not Deficient Number");
        }


        // Strong number check
        if (IsStrong(num)){
            Console.WriteLine("Strong Number");
        }
        else
        {
            Console.WriteLine("Not Strong Number");
        }
    }
}
