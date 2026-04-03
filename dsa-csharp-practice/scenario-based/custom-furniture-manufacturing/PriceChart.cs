// Manages the price chart for wooden rod lengths.
class PriceChart{
    // Arrays to store lengths and their corresponding prices.
    private int[] lengths;
    private int[] prices;
    private int count;
    
    // Initializes the price chart with a specified size.
    public PriceChart(int size){
        lengths = new int[size];       // Initialize arrays
        prices = new int[size];
        count = 0;
    }
    
    // Adds a price entry for a specific cut length.
    public void AddPrice(int length, int price) {
        lengths[count] = length;   // Store length
        prices[count] = price;     // Store price
        count++;                    // Increment count
    }
    
    // Retrieves the price for a given cut length.
    public int GetPrice(int length){
        for (int i = 0; i < count; i++){      // Search for the length
            if (lengths[i] == length)         // If found return the price
                return prices[i];
        }
        return 0;
    }
}
