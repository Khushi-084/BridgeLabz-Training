// Magazine class derived from LibraryItem
public class Magazine : LibraryItem{
    public Magazine(string title) : base(title) { }
    public override int GetLoanDuration() => 7;
}
