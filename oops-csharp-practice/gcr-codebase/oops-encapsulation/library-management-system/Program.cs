using System;
class Program{
    public static void Main(string[] args){
        // Creating three library items
        LibraryItem b = new Book("C#");
        LibraryItem m = new Magazine("Tech");
        LibraryItem d = new DVD("Movie");
        
        // Displaying loan durations 
        System.Console.WriteLine(b.GetLoanDuration());
        System.Console.WriteLine(m.GetLoanDuration());
        System.Console.WriteLine(d.GetLoanDuration());
    }
}
