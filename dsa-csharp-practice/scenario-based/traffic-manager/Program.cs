
class Program{
    public static void Main(static[] args)
    {
        TrafficManager manager = new TrafficManager();

        while (true){
            Console.WriteLine("1. Vehicle Arrives");
            Console.WriteLine("2. Vehicle Exits");
            Console.WriteLine("3. Display State");
            Console.WriteLine("4. Exit");
            Console.Write("Enter choice: ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice){
                case 1:
                    manager.VehicleArrives();
                    break;
                case 2:
                    manager.VehicleExits();
                    break;
                case 3:
                    manager.DisplayState();
                    break;
                case 4:
                    return;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}
