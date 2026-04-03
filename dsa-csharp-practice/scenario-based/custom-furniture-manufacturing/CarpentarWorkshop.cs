using System;

class CarpenterWorkshop{
    public static void Main(string[] args){
        // Input wooden rod length
        Console.Write("Enter wooden rod length (ft): ");
        int rodLength = int.Parse(Console.ReadLine());
        WoodRod rod = new WoodRod(rodLength);

        Console.Write("Enter number of price entries: ");
        int n = int.Parse(Console.ReadLine());
        PriceChart chart = new PriceChart(n);

        // Input price chart
        for (int i = 0; i < n; i++){
            Console.Write("Enter cut length: ");
            int length = int.Parse(Console.ReadLine());

            Console.Write("Enter price: ");
            int price = int.Parse(Console.ReadLine());

            chart.AddPrice(length, price);
        }

        // Scenario A
        CuttingStrategy bestRevenue = new RevenueMaximizationStrategy();
        Console.WriteLine( "\nScenario A - Maximum Revenue: " + bestRevenue.CalculateRevenue(rod, chart)
        );

        // Scenario B
        Console.Write("\nEnter allowed waste (ft): ");
        int waste = int.Parse(Console.ReadLine());

        CuttingStrategy wasteAware = new WasteAwareStrategy(waste);
        Console.WriteLine("Scenario B - Revenue with Waste Constraint: " + wasteAware.CalculateRevenue(rod, chart));

        // Scenario C
        Console.WriteLine("Scenario C - Optimal Revenue with Minimal Waste: " + wasteAware.CalculateRevenue(rod, chart)
        );
    }
}
