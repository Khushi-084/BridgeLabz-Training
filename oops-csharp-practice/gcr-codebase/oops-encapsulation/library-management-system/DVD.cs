// DVD class derived from LibraryItem
public class DVD : LibraryItem{
    public DVD(string title) : base(title) { }
    public override int GetLoanDuration() => 3;
}
