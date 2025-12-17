import java.util.Scanner;
public class KilometerToMiles {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        // Input distance in kilometers
        System.out.print("Enter distance in kilometers: ");
        double kilometers = sc.nextDouble();
        // Conversion formula
        double miles = kilometers * 0.621371;
        // Output result
        System.out.println("Distance in miles = " + miles);

    }
}
