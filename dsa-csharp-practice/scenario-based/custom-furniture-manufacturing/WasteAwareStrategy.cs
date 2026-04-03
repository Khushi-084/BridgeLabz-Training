// Implements a cutting strategy that accounts for allowable waste in wooden rods.
class WasteAwareStrategy : CuttingStrategy{
    // Allowed waste length for each cut.
    private int allowedWaste;
    
    // Initializes the strategy with a specified allowable waste.
    public WasteAwareStrategy(int waste){
        allowedWaste = waste;     // Set allowable waste
    }
   
    // Calculates the maximum revenue for cutting the wooden rod with allowable waste.
    public override int CalculateRevenue(WoodRod rod, PriceChart chart){
        return MaxRevenueWithWaste(rod.Length, chart);
    }
    
    // Recursive function to calculate the maximum revenue considering allowable waste.
    private int MaxRevenueWithWaste(int length, PriceChart chart){
        if (length <= allowedWaste)
            return 0;

        int max = 0;    // Initialize max revenue

        for (int cut = 1; cut <= length - allowedWaste; cut++){      // Try all possible cuts considering waste
            int value = chart.GetPrice(cut) + MaxRevenueWithWaste(length - cut, chart);

            if (value > max)   // Update max if value is better
                max = value;
        }
        return max;
    }
}
