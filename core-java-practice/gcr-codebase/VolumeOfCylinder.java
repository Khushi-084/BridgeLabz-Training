import java.util.Scanner;
public class VolumeOfCylinder {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        //Enter the radius of the cylinder
        int radius = sc.nextInt() ; 
        //Enter the height of the cylinder
        int height = sc.nextInt();

        double volume = Math.PI * Math.pow(radius, 2) * height;

        System.out.println("The volume of the cylinder is: "+ volume);
    }
    
}
