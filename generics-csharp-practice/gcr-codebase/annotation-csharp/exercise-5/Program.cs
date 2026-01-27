using System.Reflection;

class Program{
    public static void Main(string[] args){
        var bugs =
            typeof(CodeBase)
            .GetMethod("ProcessData")
            .GetCustomAttributes<BugReportAttribute>();
        foreach (var bug in bugs)
            Console.WriteLine(bug.Description);
    }
}
