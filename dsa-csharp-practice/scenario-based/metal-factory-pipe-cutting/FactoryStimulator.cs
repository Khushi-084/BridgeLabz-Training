using System;

class FactorySimulator{
    public static void Main(string[] args){
        // Input rod length
        Console.Write("Enter rod length: ");
        int rodLength = int.Parse(Console.ReadLine());
        Rod rod = new Rod(rodLength);

        Console.Write("Enter number of price entries: ");
        int n = int.Parse(Console.ReadLine());
        
        // Input price chart
        PriceChart chart = new PriceChart(n);

        for (int i = 0; i < n; i++){
            Console.Write("Enter cut length: ");
            int length = int.Parse(Console.ReadLine());

            Console.Write("Enter price: ");
            int price = int.Parse(Console.ReadLine());

            chart.AddPrice(length, price);
        }

        // Scenario A
        CuttingStrategy optimized = new OptimizedCuttingStrategy();
        Console.WriteLine("\nScenario A - Optimized Revenue: " + optimized.CalculateRevenue(rod, chart) );

        // Scenario B
        Console.Write("\nEnter custom cut length: ");
        int customLength = int.Parse(Console.ReadLine());

        Console.Write("Enter custom cut price: ");
        int customPrice = int.Parse(Console.ReadLine());

        chart.AddPrice(customLength, customPrice);

        Console.WriteLine("Scenario B - Revenue after custom order: " + optimized.CalculateRevenue(rod, chart));

        // Scenario C
        CuttingStrategy nonOptimized = new NonOptimizedCuttingStrategy();
        Console.WriteLine("Scenario C - Non-Optimized Revenue: " + nonOptimized.CalculateRevenue(rod, chart)
        );
    }
}
