using System.Collections;
class Program{
    public static void Main(string[] args) {
#pragma warning disable
        ArrayList list = new ArrayList();
        list.Add(10);
        list.Add("Hello");
#pragma warning restore
        foreach (var item in list)
            Console.WriteLine(item);
    }
}
