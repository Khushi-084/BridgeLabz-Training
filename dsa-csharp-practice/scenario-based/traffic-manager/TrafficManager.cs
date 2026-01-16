class TrafficManager{
    private Roundabout roundabout = new Roundabout();
    private VehicleQueue queue = new VehicleQueue(10);

    public void VehicleArrives(){
        Console.Write("Enter vehicle number: ");
        string number = Console.ReadLine();

        if (roundabout.IsEmpty()){
            roundabout.AddVehicle(new Vehicle(number));
            Console.WriteLine("Vehicle entered roundabout.");
        }
        else{
            queue.Enqueue(new Vehicle(number));
        }
    }

    public void VehicleExits(){
        Console.Write("Enter exiting vehicle number: ");
        string number = Console.ReadLine();

        if (roundabout.RemoveVehicle(number)){
            Console.WriteLine("Vehicle exited roundabout.");

            Vehicle next = queue.Dequeue();
            if (next != null){
                roundabout.AddVehicle(next);
                Console.WriteLine("Waiting vehicle entered roundabout.");
            }
        }
        else{
            Console.WriteLine("Vehicle not found in roundabout.");
        }
    }

    public void DisplayState(){
        Console.WriteLine("Roundabout Status:");
        roundabout.Display();

        Console.WriteLine("Waiting Queue:");
        queue.Display();
    }
}
