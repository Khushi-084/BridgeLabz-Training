using System;
class Person{
    // Attributes of a person
    public string Name;
    public int Age;

    // Parameterized constructor
    public Person(string name, int age){
        this.Name = name;
        this.Age = age;
    }

    // Copy constructor 
    public Person(Person p){
        this.Name = p.Name;
        this.Age = p.Age;
    }
    
    // Method to display person details
    public void Display(){
        Console.WriteLine("\nPerson Name: " + Name + ", Age: " + Age);
    }
}

class PersonClass{
    public static void Main(string[] args){
        // Creating a person
        Person p1 = new Person("Alice", 25);
        p1.Display();

        // Copying p1 to p2
        Person p2 = new Person(p1);
        // Displaying p2
        p2.Display();
    }
}
