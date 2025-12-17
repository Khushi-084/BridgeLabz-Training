import java.util.Scanner;

public class CelsiusToFahrenheit {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        // Input temperature in Celsius
        System.out.print("Enter temperature in Celsius: ");
        double celsius = sc.nextDouble();

        // Conversion formula
        double fahrenheit = (celsius * 9 / 5) + 32;

        // Output result
        System.out.println("Temperature in Fahrenheit: " + fahrenheit);

        
    }
}
