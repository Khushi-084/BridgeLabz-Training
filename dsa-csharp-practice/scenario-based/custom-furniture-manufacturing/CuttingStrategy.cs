// Defines the abstract strategy for cutting wooden rods.
abstract class CuttingStrategy{
    
    // Calculates the maximum revenue for cutting the wooden rod based on the price chart.
    public abstract int CalculateRevenue(WoodRod rod, PriceChart chart);
}
