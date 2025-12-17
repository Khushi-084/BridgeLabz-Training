import java.util.*;

public class AreaOfCircle {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        // Input the radius of the circle
        System.out.print("Enter the radius of the circle: ");
        int radius = sc.nextInt();

        int area= (int) (Math.PI * radius * radius);

        // Output result
        System.out.println("Area of the cirle: " + area);

        
    }
}
