class Program{
    public static void Main(string[] args){
        User user = new User();
        Console.WriteLine(JsonSerializer.ToJson(user));
    }
}
