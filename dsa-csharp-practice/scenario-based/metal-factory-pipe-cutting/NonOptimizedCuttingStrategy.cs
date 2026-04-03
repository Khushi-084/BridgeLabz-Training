// Implements a non-optimized cutting strategy that does not cut the rod.
class NonOptimizedCuttingStrategy : CuttingStrategy{
    // Returns the price of the rod without any cuts.
    public override int CalculateRevenue(Rod rod, PriceChart chart){
        return chart.GetPrice(rod.Length);
    }
}
