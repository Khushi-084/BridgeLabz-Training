class Program{
    public static void Main(string[] args){
        Calculator calc = new Calculator();
        Console.WriteLine(calc.Square(4));
        Console.WriteLine(calc.Square(4)); // cached
    }
}
