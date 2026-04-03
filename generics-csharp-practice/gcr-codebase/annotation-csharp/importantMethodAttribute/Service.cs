public class Service{
    [ImportantMethod]
    public static void SaveData() { }

    [ImportantMethod("LOW")]
    public static void LogData() { }

    public static void HelperMethod() { }
}

