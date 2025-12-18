
class KilometerToMiles {
    public static void Main(String[] args) {
      
        // Input distance in kilometers
        Console.Write("Enter distance in kilometers: ");
        double kilometers= ConvertToDouble(Console.ReadLine());

        //Conversion Formula
        double miles=kilometers * 0.621371;

        //Output 
        Console.WriteLine("Distance in miles: " + miles);
    
    }
}
