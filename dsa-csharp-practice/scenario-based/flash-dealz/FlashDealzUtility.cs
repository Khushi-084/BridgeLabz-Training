// utility classs that implements the interface
class FlashDealzUtility : IFlashDealz{
    // array of products of size 20
    private Product[] products = new Product[20];
    private int count = 0;

    // method to add the product
    public void AddProduct(){
        Console.Write("Enter product name: ");
        string name = Console.ReadLine();

        Console.Write("Enter discount (%): ");
        int discount = int.Parse(Console.ReadLine());

        products[count++] = new Product(name, discount);
        Console.WriteLine("Product added successfully.");
    }
    
    // method to sort the products
    public void SortProducts() {
        QuickSort(products, 0, count - 1);
        Console.WriteLine("Products sorted by discount.");
    }
    
    // method to display all the products
    public void DisplayProducts(){
        if (count == 0){
            Console.WriteLine("No products available.");
            return;
        }

        Console.WriteLine("\n--- Product List ---");
        for (int i = 0; i < count; i++){
            products[i].Display();
        }
    }
    
    // method to sort the product using quick sort algorithm
    private void QuickSort(Product[] arr, int low, int high){
        if (low < high){
            int p = Partition(arr, low, high);
            QuickSort(arr, low, p - 1);
            QuickSort(arr, p + 1, high);
        }
    }

    // method to partition the product array
    private int Partition(Product[] arr, int low, int high) {
        int pivot = arr[high].GetDiscount();
        int i = low - 1;

        for (int j = low; j < high; j++){
            if (arr[j].GetDiscount() > pivot){
                i++;
                Swap(arr, i, j);
            }
        }

        // recursive call to swap the products
        Swap(arr, i + 1, high);
        return i + 1;
    }

    // method to swap the products
    private void Swap(Product[] arr, int i, int j){
        Product temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }
}
