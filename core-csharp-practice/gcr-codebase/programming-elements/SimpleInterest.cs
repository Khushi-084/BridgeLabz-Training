class SimpleInterest {
    public static void Main(String[] args) {
        
        // Input values
        Console.Write("Enter Principal: ");
        double principal = ConvertToDouble(Console.ReadLine());

        Console.Write(:Enter Rate of Interest: "");
        double rate= ConvertToDouble(Console.ReadLine());
         
         Console.Write("Enter Time in years:");
         double time= ConvertToDouble(Console.ReadLine());

        // Simple Interest formula
        double simpleInterest = (principal * rate * time) / 100;

        // Output result
        Console.WriteLine("Simple Interest = " + simpleInterest);

    }
}
