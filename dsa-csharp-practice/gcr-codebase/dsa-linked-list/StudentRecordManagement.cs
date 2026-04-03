using System;

class StudentNode{
    // Data members of the class
    public int Roll;
    public string Name;
    public int Age;
    public string Grade;
    public StudentNode Next;
    
    // Constructor of the class 
    public StudentNode(int roll, string name, int age, string grade){
        Roll = roll;
        Name = name;
        Age = age;
        Grade = grade;
        Next = null;
    }
}
// Class StudentList
class StudentList{
    // Data members of the class
    private StudentNode head;
    
    // Add a student at the beginning of the list 
    public void AddAtEnd(int roll, string name, int age, string grade){
        // Creates a new node
        StudentNode newNode = new StudentNode(roll, name, age, grade);
        if (head == null){         // If the list is empty
            head = newNode;
            return;
        }
        StudentNode temp = head;        // Traversing the list 
        while (temp.Next != null)
            temp = temp.Next;
        temp.Next = newNode;
    }
    // Delete a student from the list
    public void DeleteByRoll(int roll){
        if (head == null) return;    // If the list is empty

        if (head.Roll == roll){         // If the first student is to be deleted
            head = head.Next;
            return;
        }

        StudentNode temp = head;
        while (temp.Next != null && temp.Next.Roll != roll)   // Traversing the list
            temp = temp.Next;

        if (temp.Next != null)      // If the student is found
            temp.Next = temp.Next.Next;
    }
    // Search for a student by roll
    public void Search(int roll){
        StudentNode temp = head;
        while (temp != null){         // Traversing the list
            if (temp.Roll == roll){      // If the student is found
                Console.WriteLine($"{temp.Name} | {temp.Age} | {temp.Grade}");
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("Student not found");
    }
    // Update the grade of a student by roll
    public void UpdateGrade(int roll, string newGrade){
        StudentNode temp = head;
        while (temp != null){    // Traversing the list
            if (temp.Roll == roll){
                temp.Grade = newGrade;
                return;
            }
            temp = temp.Next;
        }
    }
    

    // Display the list of students
    public void Display(){
        StudentNode temp = head;
        while (temp != null){
            Console.WriteLine($"{temp.Roll} {temp.Name} {temp.Age} {temp.Grade}");
            temp = temp.Next;
        }
    }
}
