using System;
using System.Collections.Generic;

List<AuctionItem> auctionItems = new List<AuctionItem>
{
    new AuctionItem("불꽃 반지",28000,15,"장신구"),
    new AuctionItem("만능 물약",5000,30,"소비"),
    new AuctionItem("전설의 검",50000,12,"무기"),
    new AuctionItem("미스릴 갑옷",35000,8,"방어구"),
    new AuctionItem("회복 물약",5000,3,"소비"),
};


Console.WriteLine("=== 입찰가 기준 정렬 (BidComparer) ===");
auctionItems.Sort(new BidComparer());
foreach (var item in auctionItems)
{
    Console.WriteLine($"{item.Name}[{item.Category}] - 입찰가: {item.CurrentBid}골드 (입찰 {item.BidCount}회)");
}


Console.WriteLine();
Console.WriteLine("=== 입찰 횟수 기준 정렬 (Create 람다) ===");
auctionItems.Sort(Comparer<AuctionItem>.Create((x, y) => y.BidCount - x.BidCount));
foreach (var item in auctionItems)
{
    Console.WriteLine($"{item.Name}[{item.Category}] - 입찰가: {item.CurrentBid}골드 (입찰 {item.BidCount}회)");
}
