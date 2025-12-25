using System;
class FootballTeam{
    public static void Main(string[] args){

        //initialising the array
        int[] heights=new int[11];
        Random random=new Random();


        //generating random heights between 150 to 250 cms
        Console.WriteLine("Height of football players(in cms): ");
        for(int i=0;i<heights.Length;i++){
            heights[i]=random.Next(150,251);
            Console.WriteLine(heights[i]+ " ");
        }
        Console.WriteLine();


        //calculating sum, mean, tallest and shortest height
        int sum=FindSum(heights);
        double mean=FindMean(heights);
        int tallest=FindTallest(heights);
        int shortest=FindShortest(heights);


        //output
        Console.WriteLine("Results: ");
        Console.WriteLine("Shortest Height: " + shortest + "cms");
        Console.WriteLine("Tsllest Height: "+ tallest + "cms");
        Console.WriteLine("Mean Height: "+ mean + "cms");

        //function to calculate the sum
        static int FindSum(int[] heights){
            int sum=0;
            for(int i=0;i<heights.Length;i++){
                sum+= heights[i];
            }
            return sum;
        }

        //function to calculate the mean
        static double FindMean(int[] heights){
            int sum=FindSum(heights);
            return (double)sum/heights.Length;
        }

        ////function to calculate the tallest height
        static int FindTallest(int[] heights){
            int max=heights[0];
            for(int i=1;i<heights.Length;i++){
                if(heights[i]>max){
                    max=heights[i];
                }
            }
            return max;
        }

        //function to calculate the shortest height
        static int FindShortest(int[] heights){
            int min=heights[0];
            for(int i=1;i<heights.Length;i++){
                if(heights[i]<min){
                    min=heights[i];
                }
            }
            return min;
        }
    }
}