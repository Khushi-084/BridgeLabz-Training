using System;
class SpringSeason{
    //method to check spring season or not
    public static bool SpringOrNot(int month, int day){ 
        if ((month == 3 && day >= 20) || (month == 4) || (month == 5) || (month == 6 && day <= 20)){
            return true;
        }
        return false;
    }
    public static void Main(string[] args){
        //taking inputs
        Console.Write("Month");
        int month = int.Parse(Console.ReadLine());
        Console.Write("Day");
        int day = int.Parse(Console.ReadLine());

        //calling the method
        if (SpringOrNot){
            Console.WriteLine("A spring season");
        }
        else{
            Console.WriteLine("NOt a spring season");
        }
    }
}