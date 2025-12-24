using System;
class StoreNumber{
    public static void Main(string[] args){

        //initializing the array
        double[] numbers= new double[10];
        double total = 0.0;
        int index=0;
        
        //taking numbers as input from the user =till a non-positive number is entered or the array is full
        while(true){
            Console.Write("Enter a number: ");
            double input= double.Parse(Console.ReadLine());
            if(input<=0 || index==10){
                break;
            numbers[index++]= input;
            }
             for(int i=0;i< index;i++){           
                Console.WriteLine(numbers[i]);
                total+= numbers[i];         //calculate the sum
             }
            
            //output 
             Console.WriteLine("Sum= " + total);
        }
    }
}