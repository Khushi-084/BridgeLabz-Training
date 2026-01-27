using System.Reflection;
class Program{
    public static void Main(string[] args){
        MethodInfo method =
            typeof(TaskManager).GetMethod("DeploySystem");
        TaskInfoAttribute attr =
            method.GetCustomAttribute<TaskInfoAttribute>();
        Console.WriteLine($"Priority: {attr.Priority}");
        Console.WriteLine($"Assigned To: {attr.AssignedTo}");
    }
}
