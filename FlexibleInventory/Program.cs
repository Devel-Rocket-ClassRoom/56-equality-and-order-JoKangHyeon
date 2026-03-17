using System;
using System.Collections.Generic;

List<Item> items = new()
{
    new Item("불꽃 검", "무기","전설"),
    new Item("얼음 단검", "무기","희귀"),
    new Item("철 갑옷", "방어구","일반"),
    new Item("미스릴 방패", "방어구","희귀"),
    new Item("체력 물약", "소비","일반"),
};


Console.WriteLine("=== 타입별 그룹핑 ===");
Dictionary<Item, List<Item>> itemDictType = new(new ItemTypeComparer());
foreach (Item item in items)
{
    if (!itemDictType.ContainsKey(item))
    {
        itemDictType.Add(item, new List<Item>());
    }
    itemDictType[item].Add(item);
}

foreach (var itemKvp in itemDictType)
{
    Console.WriteLine($"[{itemKvp.Key.Type}]");
    foreach (var item in itemKvp.Value)
    {
        Console.WriteLine($" - {item.Name} ({item.Grade})");
    }
}


Console.WriteLine();
Console.WriteLine("=== 등급별 그룹핑 ===");
Dictionary<Item, List<Item>> itemDictGrade = new(new ItemGradeComparer());
foreach (Item item in items)
{
    if (!itemDictGrade.ContainsKey(item))
    {
        itemDictGrade.Add(item, new List<Item>());
    }
    itemDictGrade[item].Add(item);
}

foreach (var itemKvp in itemDictGrade)
{
    Console.WriteLine($"[{itemKvp.Key.Grade}]");
    foreach (var item in itemKvp.Value)
    {
        Console.WriteLine($" - {item.Name} ({item.Grade})");
    }
}
