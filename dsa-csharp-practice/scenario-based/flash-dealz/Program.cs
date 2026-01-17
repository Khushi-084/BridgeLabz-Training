class Program
{
    public static void Main(string[] args)
    {
        // interface reference 
        IFlashDealz utility = new FlashDealzUtility();
        FlashDealzMenu menu = new FlashDealzMenu(utility);
        // display the menu
        menu.ShowMenu();      
    }
}
