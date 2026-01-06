using System;
class Program{
    public static void Main(string[] args){
        // Create an array of 5 birds
        Bird[] birds = new Bird[5];

        birds[0] = new Eagle("Rocky");
        birds[1] = new Sparrow("Chirpy");
        birds[2] = new Duck("Daffy");
        birds[3] = new Penguin("Pingu");
        birds[4] = new Seagull("Sandy");

        Console.WriteLine("=== EcoWing Bird Sanctuary ===\n");

        // Display information about each bird
        foreach (Bird bird in birds){
            bird.DisplayInfo();
            // Check if the bird can fly or swim
            if (bird is IFlyable){
                ((IFlyable)bird).Fly();
            }

            if (bird is ISwimmable){
                ((ISwimmable)bird).Swim();
            }

            Console.WriteLine();
        }
    }
}
