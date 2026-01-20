class ParcelMenu {

    public void ShowMenu(ParcelLinkedList list){
        int choice;

        do{
            Console.WriteLine("\n--- Parcel Tracker Menu ---");
            Console.WriteLine("1. Track Parcel");
            Console.WriteLine("2. Add Custom Checkpoint");
            Console.WriteLine("3. Exit");
            Console.Write("Enter choice: ");

            choice = int.Parse(Console.ReadLine());

            switch(choice){
                case 1:
                    list.TrackParcel();
                    break;

                case 2:
                    Console.Write("Enter existing stage: ");
                    string oldStage = Console.ReadLine();
                    Console.Write("Enter new checkpoint: ");
                    string newStage = Console.ReadLine();
                    list.AddAfterStage(oldStage, newStage);
                    break;

                case 3:
                    Console.WriteLine("Exiting Menu...");
                    break;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }

        } while(choice != 3);
    }
}
