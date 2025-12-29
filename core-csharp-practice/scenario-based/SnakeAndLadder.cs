using System;

class SnakeAndLadder{
    // Player data for the game 
    private static int[] positions = new int[4];
    private static string[] names = new string[4];
    private static int playerCount = 0;
    
    // Random number generator
    private static Random random = new Random();

    // Game borad set up using array
    private static int[] board = new int[101];

    // Snake & Ladder configuration using arrays
    private static int[] ladderStart = { 4, 9, 20, 28, 40 };
    private static int[] ladderEnd   = { 14, 31, 38, 84, 59 };

    private static int[] snakeStart  = { 17, 54, 62, 64, 98 };
    private static int[] snakeEnd    = { 7, 34, 19, 60, 79 };

    static void Main(string[] args){
        // Initialize board
        InitializeBoard();

        int choice;
        
        //Main menu loop to start the game as per user's choice 
        do{
            Console.WriteLine("\n=== SNAKE & LADDER ===");
            Console.WriteLine("1. Start Game");
            Console.WriteLine("2. Exit");
            Console.Write("Enter choice: ");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice){
                case 1:
                    SetupPlayers();
                    PlayGame();
                    break;

                case 2:
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }

        } while (choice != 2);
    }

    // Initializing the board using arrays
    private static void InitializeBoard() {
        for (int i = 0; i <= 100; i++)
            board[i] = i;

        for (int i = 0; i < ladderStart.Length; i++)
            board[ladderStart[i]] = ladderEnd[i];        // ladders setup using the already initialized arrays

        for (int i = 0; i < snakeStart.Length; i++)
            board[snakeStart[i]] = snakeEnd[i];       // // snakes setup using the already initialized arrays
    }

    // Player setup
    private static void SetupPlayers(){
        Console.Write("\nEnter number of players (2-4): ");
        playerCount = Convert.ToInt32(Console.ReadLine());

        if (playerCount < 2 || playerCount > 4){           //players should be from 2 to 4
            Console.WriteLine("Invalid count — defaulting to 2 players");
            playerCount = 2;
        }

        for (int i = 0; i < playerCount; i++) {          //player details
            positions[i] = 0;

            Console.Write($"Enter Player {i + 1} Name: ");
            names[i] = Console.ReadLine();

            if (string.IsNullOrEmpty(names[i]))
                names[i] = "Player" + (i + 1);
        }

        Console.WriteLine("\nPlayers Ready!");
        for (int i = 0; i < playerCount; i++)
            Console.WriteLine($"{names[i]} starts at 0");      //players ready to play and their staring position is 0
    }

    // Game execution
    private static void PlayGame(){
        bool win = false;

        Console.WriteLine("\nGame Started! Reach EXACT 100 to win.\n");

        while (!win){
            for (int i = 0; i < playerCount; i++){                    //giving chances to each player one by one 
                Console.WriteLine($"\n{names[i]}'s turn — Press ENTER to roll dice");
                Console.ReadLine();

                int dice = RollDice();
                Console.WriteLine($"{names[i]} rolled: {dice}");

                int oldPos = positions[i];
                int newPos = oldPos + dice;           //updating the new position after the dice is rolled 

                if (newPos > 100){
                    Console.WriteLine("Move exceeds 100 — turn skipped");
                    continue;
                }

                positions[i] = newPos;

                ApplySnakeOrLadder(i);

                Console.WriteLine($"Position: {oldPos} -> {positions[i]}");

                if (CheckWin(positions[i])){               //wining condition
                    Console.WriteLine($"\n {names[i]} WINS THE GAME! \n");       
                    win = true;
                    break;
                }
            }
        }
    }

    // Dice roll
    private static int RollDice(){     //dice roll method
        return random.Next(1, 7);
    }

    // Snake & Ladder logic via board array
    private static void ApplySnakeOrLadder(int index){
        int current = positions[index];
        int finalPos = board[current];

        if (finalPos > current)           //snake and ladder logic
            Console.WriteLine("Ladder Up!");
        else if (finalPos < current)
            Console.WriteLine("Snake Down!");

        positions[index] = finalPos;
    }

    // Win check
    private static bool CheckWin(int position){     //winning condition
        return position == 100;
    }
}
