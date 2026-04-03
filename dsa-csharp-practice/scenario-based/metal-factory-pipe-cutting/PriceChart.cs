class PriceChart{
    // Arrays to store lengths and their corresponding prices
    private int[] lengths;
    private int[] prices;
    private int count;

    // Constructor to initialize the price chart with a given size
    public PriceChart(int size){
        lengths = new int[size];
        prices = new int[size];
        count = 0;
    }

    // Method to add a new price entry
    public void AddPrice(int length, int price) {
        lengths[count] = length;
        prices[count] = price;
        count++;
    }
 
    // Method to get the price for a given length
    public int GetPrice(int length){
        for (int i = 0; i < count; i++)
        {
            if (lengths[i] == length)
                return prices[i];
        }
        return 0;
    }
}
