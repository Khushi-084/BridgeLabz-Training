using System;
class CompareTwoStrings{
    public static void Main(string[] args){
        //taking input from the user
        Console.WriteLine("Enter first string:");
        string s1 = Console.ReadLine();

        Console.WriteLine("Enter second string:");
        string s2 = Console.ReadLine();

        int min = Math.Min(s1.Length, s2.Length);
         
         //comparing
        for (int i = 0; i < min; i++){
            if (s1[i] < s2[i]){
                Console.WriteLine(s1 + " comes before " + s2);
                return;
            }
            else if (s1[i] > s2[i]){
                Console.WriteLine(s2 + " comes before " + s1);
                return;
            }
        }
        
        //output on based of comparison
        if (s1.Length == s2.Length)
            Console.WriteLine("Both strings are equal");
        else if (s1.Length < s2.Length)
            Console.WriteLine(s1 + " comes before " + s2);
        else
            Console.WriteLine(s2 + " comes before " + s1);
    }
}
