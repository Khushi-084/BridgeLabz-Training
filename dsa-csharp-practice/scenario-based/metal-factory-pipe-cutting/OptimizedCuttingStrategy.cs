using System;
// Implements an optimized cutting strategy using recursion to maximize revenue.
class OptimizedCuttingStrategy : CuttingStrategy{
    public override int CalculateRevenue(Rod rod, PriceChart chart){
        return MaxRevenue(rod.Length, chart);      
    }

    // Recursive function to calculate the maximum revenue for a given length of rod.
    private int MaxRevenue(int length, PriceChart chart){
        if (length == 0)
            return 0;

        int maxRevenue = 0;
        for (int cut = 1; cut <= length; cut++){     // Try all possible cuts
            int current = chart.GetPrice(cut) + MaxRevenue(length - cut, chart);     // Revenue from the cut plus the best revenue from the remaining length

            if (current > maxRevenue)    // Update maxRevenue if current is better
                maxRevenue = current;    
        }

        return maxRevenue;
    }
}
