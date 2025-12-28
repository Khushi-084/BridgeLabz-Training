using System;
class NumberGuessing{
    public static void Main(string[] args) {
        int low = 1, high = 100;
        bool guessedCorrectly = false;
        

        // taking user input
        Console.WriteLine("Think of a number between 1 and 100.");
        Console.WriteLine("Enter H (High), L (Low), or C (Correct)");
         
        // guessing the number
        while (!guessedCorrectly){
            int guess = GenerateGuess(low, high);
            Console.WriteLine("Computer guesses: " + guess);
            char feedback = GetFeedback();

            if (feedback == 'C'){
                Console.WriteLine("Computer guessed correctly!");
                guessedCorrectly = true;
            }
            else if (feedback == 'H'){
                high = guess - 1;
            }
            else if (feedback == 'L'){
                low = guess + 1;
            }
        }
    }

    // Function to generate a guess
    static int GenerateGuess(int low, int high){
        return (low + high) / 2;
    }
    

    // Function to get user feedback
    static char GetFeedback(){
        return char.ToUpper(Console.ReadLine()[0]);
    }
}
