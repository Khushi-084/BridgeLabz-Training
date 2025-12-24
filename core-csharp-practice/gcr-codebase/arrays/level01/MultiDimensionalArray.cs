using System;
class MultiDimensionalArray{
    public static void Main(string[] args){

        //taking input for number of rows and columns
        Console.Write("Enter rows: ");
        int rows=int.Parse(Console.ReadLine());
        Console.Write("Enter columns: ");
        int cols=int.Parse(Console.ReadLine());

        //initializing the 2D array and 1D array
        int[,] matrix =new int[rows,cols];
        int[] array= new int[rows*cols];
        int idx=0;

        for(int i=0;i<rows;i++){
            for(int j=0;j<cols;j++){
                Console.Write("Enter element at {0} {1}: ",i,j);
                matrix[i,j]=int.Parse(Console.ReadLine());
                array[idx++]=matrix[i,j];
            }
        }
        //output the 1D array
        Console.WriteLine("1D Array elements are: ");
        foreach(int value in array){
            Console.Write(value + " ");
        }
    }
}