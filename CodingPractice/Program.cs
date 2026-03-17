using System;
using System.Collections.Generic;


Console.WriteLine();
Console.WriteLine("1. 참조 동등성과 값 동등성");

string s1 = "hello";
string s2 = "hello";
string s3 = new string("hello".ToCharArray());

Console.WriteLine(s1 == s2);
Console.WriteLine(s1 == s3);
Console.WriteLine(object.ReferenceEquals(s1, s2));
Console.WriteLine(object.ReferenceEquals(s1, s3));



Console.WriteLine();
Console.WriteLine("2. 클래스의 기본 동등성 비교");

Player p1 = new Player { Name="A", Level=1 };
Player p2 = new Player { Name = "A", Level = 1 };
Player p3 = p1;

Console.WriteLine($"p1 == p2: {p1 == p2}");
Console.WriteLine($"p1 == p3: {p1 == p3}");
Console.WriteLine($"p1.Equals(p2): {p1.Equals(p2)}");
Console.WriteLine($"p1.Equals(p3): {p1.Equals(p3)}");



Console.WriteLine();
Console.WriteLine("3. 구조체의 기본 동등성 비교");

Position po1 = new Position(10, 20);
Position po2 = new Position(10, 20);
Position po3 = new Position(30, 40);


Console.WriteLine($"pos1.Equals(pos2): {po1.Equals(po2)}");
Console.WriteLine($"pos1.Equals(pos3): {po1.Equals(po3)}");



Console.WriteLine();
Console.WriteLine("4. IEquatable 구현하기");

Item item1 = new Item("aa", 1);
Item item2 = new Item("aa", 1);
Item item3 = new Item("aad", 1);
Console.WriteLine($"item1.Equals(item2): {item1.Equals(item2)}");
Console.WriteLine($"item1.Equals(item3): {item1.Equals(item3)}");

HashSet<Item> inventory = new HashSet<Item>
{
    item1
};

Console.WriteLine($"inventory.Contains(item2): {inventory.Contains(item2)}");



Console.WriteLine();
Console.WriteLine("5. GetHashCode의 중요성");

BadItem b1 = new BadItem("aa", 1);
BadItem b2 = new BadItem("aa", 1);

Console.WriteLine($"b1.Equals(b2): {b1.Equals(b2)}");
Dictionary<BadItem, int> stock = new()
{
    { b1,1 }
};
Console.WriteLine($"stock.ContainsKey(b2): {stock.ContainsKey(b2)}");



Console.WriteLine();
Console.WriteLine("6. IComparable 구현하기");

List<Monster> monsters = new List<Monster>
{
    new Monster{ Name = "Goblin", Power=30 },
    new Monster{ Name = "Dragon", Power=100 },
    new Monster{ Name = "Slime", Power=10 },
    new Monster{ Name = "Orc", Power=50 },
};

Console.WriteLine("정렬 전:");
Console.WriteLine(string.Join('\n',monsters));


Console.WriteLine();
Console.WriteLine("정렬 후:");
monsters.Sort();
Console.WriteLine(string.Join('\n', monsters));



Console.WriteLine();
Console.WriteLine("");
Console.WriteLine();
Console.WriteLine("");
Console.WriteLine();
Console.WriteLine("");
Console.WriteLine();
Console.WriteLine("");
Console.WriteLine();
Console.WriteLine("");
Console.WriteLine();
Console.WriteLine("");
Console.WriteLine();
Console.WriteLine("");
Console.WriteLine();
Console.WriteLine("");
Console.WriteLine();
Console.WriteLine("");
Console.WriteLine();
Console.WriteLine("");
Console.WriteLine();
Console.WriteLine("");
