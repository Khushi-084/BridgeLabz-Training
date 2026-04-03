using System;

// Given a set of petrol pumps with petrol and distance to the next pump, 
//determine the starting point for completing a circular tour.

class PetrolPump{
    // Petrol and Distance
    public int Petrol;
    public int Distance;
    
    // Constructor to initialize petrol and distance
    public PetrolPump(int petrol, int distance){
        Petrol = petrol;
        Distance = distance;
    }
}

class CircularTour{
    // Function to find the starting point of the circular tour
    static int FindStartingPoint(PetrolPump[] pumps){
        Queue<int> queue = new Queue<int>();    // To store the indices of petrol pumps
        int surplus = 0;
        int i = 0;
        int n = pumps.Length;
        
        // Traversing the list
        while (queue.Count < n && i < n * 2){
            int index = i % n;      // Index of the petrol pump
            queue.Enqueue(index);

            surplus += pumps[index].Petrol - pumps[index].Distance;       // Updating the surplus petrol 

            while (surplus < 0 && queue.Count > 0){           // Removing the petrol pumps
                int removed = queue.Dequeue();                // that are not part of the circular tour
                surplus -= pumps[removed].Petrol - pumps[removed].Distance;        // Updating the surplus petrol
            }

            i++;
        }

        return queue.Count == n ? queue.Peek() : -1;        // Returning the starting point
    }

    public static void Main(string[] args){
        // Input
        Console.Write("Enter number of petrol pumps: ");
        int n = int.Parse(Console.ReadLine());

        PetrolPump[] pumps = new PetrolPump[n];      // Array to store petrol pumps

        for (int i = 0; i < n; i++){
            Console.WriteLine($"\nPetrol Pump {i}:");
            Console.Write("Enter petrol amount: ");
            int petrol = int.Parse(Console.ReadLine());

            Console.Write("Enter distance to next pump: ");
            int distance = int.Parse(Console.ReadLine());

            pumps[i] = new PetrolPump(petrol, distance);
        }
        
        // Output
        int start = FindStartingPoint(pumps);

        if (start != -1)
            Console.WriteLine($"\nStart at petrol pump index: {start}");
        else
            Console.WriteLine("\nNo possible circular tour");
    }
}
