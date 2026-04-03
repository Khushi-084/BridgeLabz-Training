using System;
using System.Reflection;

class Program{
    public static void Main(string[] args){
        foreach (MethodInfo method in typeof(Service).GetMethods()){
            var attr = method.GetCustomAttribute<ImportantMethodAttribute>();
            if (attr != null){
                Console.WriteLine($"{method.Name} - Importance: {attr.Level}");
            }
        }
    }
}
