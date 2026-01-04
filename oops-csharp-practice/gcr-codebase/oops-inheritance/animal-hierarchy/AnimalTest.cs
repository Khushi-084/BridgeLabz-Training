using System;
class AnimalTest{
    // Main method
    public static void Main(string[] args){
        Animal a1 = new Dog();   
        Animal a2 = new Cat();
        Animal a3 = new Bird();
        // Make sound of each animal
        a1.MakeSound();
        a2.MakeSound();
        a3.MakeSound();
    }
}
