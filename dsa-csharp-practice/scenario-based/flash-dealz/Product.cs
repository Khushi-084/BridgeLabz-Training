using System;
// encapsulated class
class Product
{
    // attributes of the product class 
    private string name;
    private int discount;

    // consrtructor 
    public Product(string name, int discount){
        this.name = name;
        this.discount = discount;
    }
    
    // to get the discount
    public int GetDiscount(){
        return discount;
    }

    // to display the price with the discount
    public void Display(){
        Console.WriteLine(name + " - " + discount + "% OFF");
    }
}
