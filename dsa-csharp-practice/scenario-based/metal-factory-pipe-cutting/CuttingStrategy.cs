// Strategy pattern for cutting rods to maximize revenue.
abstract class CuttingStrategy{
    // Calculates the maximum revenue for cutting the rod based on the price chart.
    public abstract int CalculateRevenue(Rod rod, PriceChart chart);
}
