using System;
class QuadraticEquation{
public static void Main(string[] args){

  //taking inputs
  Console.Write("Enter value of a: ");
  double a = Convert.ToDouble(Console.ReadLine());
  Console.Write("Enter value of b: ");
  double b = Convert.ToDouble(Console.ReadLine());
  Console.Write("Enter value of c: ");
  double c = Convert.ToDouble(Console.ReadLine());
  double[] roots = QuadraticRoots(a, b, c);

  //output
  if (roots.Length == 2){
    Console.WriteLine("Two real roots:");
    Console.WriteLine("Root 1 = " + roots[0]);
    Console.WriteLine("Root 2 = " + roots[1]);
  }else if (roots.Length == 1){
    Console.WriteLine("One real root:");
    Console.WriteLine("Root = " + roots[0]);
  }else{
    Console.WriteLine("No real roots exist (delta is negative).");
  }
}

// Method to find roots of a quadratic equation
public static double[] QuadraticRoots(double a, double b, double c){

  //applying formula ( D = b^2 - 4ac)
  double d = Math.Pow(b, 2) - (4 * a * c);
  if (d > 0){
    double root1 = (-b + Math.Sqrt(d)) / (2 * a);
    double root2 = (-b - Math.Sqrt(d)) / (2 * a);
    return new double[] { root1, root2 };
  }else if (d == 0){
    double root = -b / (2 * a);
    return new double[] {root};
  }else{
    return new double[] { };
  }
}
}
