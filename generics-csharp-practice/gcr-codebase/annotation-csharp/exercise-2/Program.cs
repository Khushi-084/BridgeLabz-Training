class Program{
    public static void Main(string[] args){
        LegacyAPI api = new LegacyAPI();
        api.OldFeature();   // warning
        api.NewFeature();
    }
}
