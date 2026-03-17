using System.Collections.Generic;

class BidComparer : Comparer<AuctionItem>
{
    public override int Compare(AuctionItem x, AuctionItem y)
    {
        return y.CurrentBid.CompareTo(x.CurrentBid);
    }
}