class AuctionItem
{
    string _name;
    int _currentBid;
    int _bidCount;
    string _category;

    public string Name => _name;
    public int CurrentBid => _currentBid;
    public int BidCount => _bidCount;
    public string Category => _category;

    public AuctionItem(string name, int currentBid, int bidCount, string category)
    {
        _name = name;
        _currentBid = currentBid;
        _bidCount = bidCount;
        _category = category;
    }
}
