using System;

class TaskNode{
    // TaskId, Name, Priority, DueDate
    public int TaskId;
    public string Name, Priority, DueDate;
    public TaskNode Next;
    
    // Constructor of the class 
    public TaskNode(int id, string name, string priority, string date){
        TaskId = id;
        Name = name;
        Priority = priority;
        DueDate = date;
    }
}

// TaskScheduler class
class TaskScheduler{
    // head of the list
    private TaskNode head;

    // Add a task at the end of the list
    public void AddTask(int id, string name, string priority, string date){
        TaskNode node = new TaskNode(id, name, priority, date);   // Creating a new node
        if (head == null){         // If the list is empty
            head = node;            // Adding at the beginning 
            node.Next = head;        // Adding at the end
            return;
        }
         // Adding at the end
        TaskNode temp = head;
        while (temp.Next != head)      // Traversing the list
            temp = temp.Next;

        temp.Next = node;
        node.Next = head;
    }
    
    // Display the list of tasks
    public void Display(){
        if (head == null) return;      // If the list is empty
        TaskNode temp = head;          // Traversing the list
        do{
            Console.WriteLine($"{temp.TaskId} {temp.Name} {temp.Priority}");    // Displaying the task
            temp = temp.Next;          // Moving to the next task
        } while (temp != head);        // Until the head is reached
    }
}
