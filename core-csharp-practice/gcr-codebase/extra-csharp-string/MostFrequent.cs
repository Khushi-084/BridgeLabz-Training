using System;
class MostFrequent{
    public static void Main(string[] args){
        //taking input from the user
        Console.WriteLine("Enter a string:");
        string str = Console.ReadLine();

        int maxCount = 0;
        char result = str[0];
        //count
        for (int i = 0; i < str.Length; i++){
            int count = 0;
            for (int j = 0; j < str.Length; j++){
                if (str[i] == str[j])
                    count++;
            }
        //max
            if (count > maxCount){
                maxCount = count;
                result = str[i];
            }
        }
        
        //output
        Console.WriteLine("Most Frequent Character: " + result);
    }
}
