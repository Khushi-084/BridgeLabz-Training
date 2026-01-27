using System.Threading;

public class PerformanceTest{
    [LogExecutionTime]
    public static void FastMethod(){
        Thread.Sleep(200);
    }

    [LogExecutionTime]
    public static void SlowMethod(){
        Thread.Sleep(600);
    }
}
