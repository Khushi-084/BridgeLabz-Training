using System;
// Implements a revenue maximization strategy for cutting wooden rods.
class RevenueMaximizationStrategy : CuttingStrategy{
    // Calculates the maximum revenue for cutting the wooden rod.
    public override int CalculateRevenue(WoodRod rod, PriceChart chart){
        return MaxRevenue(rod.Length, chart);
    }
    
    // Recursive function to calculate the maximum revenue for a given length of wooden rod.
    private int MaxRevenue(int length, PriceChart chart){
        if (length == 0)
            return 0;

        int max = 0;

        for (int cut = 1; cut <= length; cut++){      // Try all possible cuts
                int value = chart.GetPrice(cut) + MaxRevenue(length - cut, chart);    // Revenue from the cut plus the best revenue from the remaining length

            if (value > max)    // Update max if value is better
                max = value;
        }
        return max;
    }
}
