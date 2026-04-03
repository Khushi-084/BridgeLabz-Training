// Abstract class LibraryItem 
public abstract class LibraryItem{
    protected string title;
    
    // Constructor with parameter 
    protected LibraryItem(string title){
        this.title = title;
    }
    
    // Abstract method 
    public abstract int GetLoanDuration();
}
