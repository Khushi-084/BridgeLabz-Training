class QueueNode{
    public Vehicle Data;
    public QueueNode Next;

    public QueueNode(Vehicle vehicle)
    {
        Data = vehicle;
        Next = null;
    }
}

class VehicleQueue{
    private QueueNode front, rear;
    private int size;
    private int capacity;

    public VehicleQueue(int capacity){
        this.capacity = capacity;
        size = 0;
    }

    public bool Enqueue(Vehicle vehicle){
        if (size == capacity){
            Console.WriteLine("Queue Overflow: Waiting area full.");
            return false;
        }

        QueueNode newNode = new QueueNode(vehicle);

        if (rear == null){
            front = rear = newNode;
        }
        else{
            rear.Next = newNode;
            rear = newNode;
        }

        size++;
        return true;
    }

    public Vehicle Dequeue(){
        if (front == null){
            Console.WriteLine("Queue Underflow: No vehicles waiting.");
            return null;
        }

        Vehicle vehicle = front.Data;
        front = front.Next;

        if (front == null)
            rear = null;

        size--;
        return vehicle;
    }

    public void Display(){
        if (front == null){
            Console.WriteLine("No vehicles in waiting queue.");
            return;
        }

        QueueNode temp = front;
        while (temp != null){
            Console.Write(temp.Data.Number + " <- ");
            temp = temp.Next;
        }
        Console.WriteLine("Rear");
    }
}
