class ParcelLinkedList {
    private ParcelNode head;

    public void AddDefaultStages(){
        AddAtEnd("Packed");
        AddAtEnd("Shipped");
        AddAtEnd("In Transit");
        AddAtEnd("Delivered");
    }

    public void AddAtEnd(string stage){
        ParcelNode newNode = new ParcelNode(stage);

        if(head == null){
            head = newNode;
            return;
        }

        ParcelNode temp = head;
        while(temp.next != null){
            temp = temp.next;
        }
        temp.next = newNode;
    }

    public void AddAfterStage(string oldStage, string newStage){
        ParcelNode temp = head;

        while(temp != null && temp.stage != oldStage){
            temp = temp.next;
        }

        if(temp == null){
            Console.WriteLine("Stage not found!");
            return;
        }

        ParcelNode newNode = new ParcelNode(newStage);
        newNode.next = temp.next;
        temp.next = newNode;

        Console.WriteLine("Checkpoint added successfully!");
    }

    public void TrackParcel(){
        if(head == null){
            Console.WriteLine("Parcel missing (null reference)");
            return;
        }

        ParcelNode temp = head;
        while(temp != null){
            Console.Write(temp.stage + " -> ");
            temp = temp.next;
        }
        Console.WriteLine("END");
    }
}
