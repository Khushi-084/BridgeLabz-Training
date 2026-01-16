class RoundNode{
    public Vehicle Data;
    public RoundNode Next;

    public RoundNode(Vehicle vehicle)
    {
        Data = vehicle;
        Next = null;
    }
}

class Roundabout{
    private RoundNode tail;

    public void AddVehicle(Vehicle vehicle){
        RoundNode newNode = new RoundNode(vehicle);

        if (tail == null) {
            tail = newNode;
            tail.Next = tail;
            return;
        }

        newNode.Next = tail.Next;
        tail.Next = newNode;
        tail = newNode;
    }

    public bool RemoveVehicle(string number){
        if (tail == null)
            return false;

        RoundNode current = tail.Next;
        RoundNode prev = tail;

        do{
            if (current.Data.Number == number) {
                if (current == tail && current.Next == tail){
                    tail = null;
                }
                else{
                    prev.Next = current.Next;
                    if (current == tail)
                        tail = prev;
                }
                return true;
            }

            prev = current;
            current = current.Next;

        } while (current != tail.Next);

        return false;
    }

    public void Display(){
        if (tail == null){
            Console.WriteLine("Roundabout is empty.");
            return;
        }

        RoundNode temp = tail.Next;
        do{
            Console.Write(temp.Data.Number + " -> ");
            temp = temp.Next;
        } while (temp != tail.Next);

        Console.WriteLine("Back to Start");
    }

    public bool IsEmpty(){
        return tail == null;
    }
}
