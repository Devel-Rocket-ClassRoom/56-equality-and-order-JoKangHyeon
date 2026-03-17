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
Console.WriteLine("7. 다중 기준 정렬");

List<Student> students = new List<Student>()
{
    new("최동훈",2,90),
    new("이영희",1,92),
    new("박민수",2,85),
    new("정수진",1,88),
    new("김철수",2,85),
};

students.Sort();
Console.WriteLine("정렬 결과:");
foreach(Student student in students)
{
    Console.WriteLine($"  {student.Grade}학년 {student.Name} ({student.Score}점)");
}



Console.WriteLine();
Console.WriteLine("8. EqualityComparer 상속하기");

Customer c1 = new Customer() { LastName="l", FirstName="f"};
Customer c2 = new Customer() { LastName = "l", FirstName = "f" };

Dictionary<Customer,string> dicNormal = new Dictionary<Customer,string>();
Dictionary<Customer, string> dicCustom = new Dictionary<Customer, string>(new CustomerNameComparer());

dicNormal.Add(c1, "");
dicCustom.Add(c1, "");

Console.WriteLine($"기본 Dictionary - c2 검색: {dicNormal.ContainsKey(c2)}");
Console.WriteLine($"커스텀  Dictionary - c2 검색: {dicCustom.ContainsKey(c2)}");



Console.WriteLine();
Console.WriteLine("9. 대소문자 무시 문자열 비교기");

Dictionary<string, int> dicStringNormal = new Dictionary<string, int>() 
{
    {"Apple",100 },
    {"Banana",200 },
};

Dictionary<string, int> dicStringIgnoreCase = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase)
{
    {"Apple",100 },
    {"Banana",200 },
};

Console.WriteLine($"apple 검색: {dicStringIgnoreCase["apple"]}");
Console.WriteLine($"Banana 검색: {dicStringIgnoreCase["Banana"]}");


Console.WriteLine();
Console.WriteLine($"일반 Dictionary에서 'apple' 존재 여부: {dicStringNormal.ContainsKey("apple")}");



Console.WriteLine();
Console.WriteLine("10. Comparer 상속하기");

List<Quest> quests = new()
{
    new("마을 방어",   2, 500),
    new("드래곤 처치", 1, 10000),
    new("약초 수집",   3, 100),
    new("보물 찾기",   2, 3000),
};


Console.WriteLine("우선순위 기준 정렬:");
quests.Sort(new QuestPriorityComparer());
foreach(Quest quest in quests)
{
    Console.WriteLine(quest.ToString());
}


Console.WriteLine();
Console.WriteLine("보상 기준 정렬 (내림차순):");
quests.Sort(new QuestRewardComparer());
foreach (Quest quest in quests)
{
    Console.WriteLine(quest.ToString());
}



Console.WriteLine();
Console.WriteLine("11. StringComparer 정렬");

List<string> strs = new(){ "apple", "Banana", "CHERRY", "date", "Elderberry" };


Console.WriteLine("Ordinal 정렬 (대소문자 구분):");
strs.Sort(StringComparer.Ordinal);
Console.WriteLine(string.Join(", ",strs));


Console.WriteLine();
Console.WriteLine("OrdinalIgnoreCase 정렬:");
strs.Sort(StringComparer.OrdinalIgnoreCase);
Console.WriteLine(string.Join(", ", strs));



Console.WriteLine();
Console.WriteLine("12. Comparer.Create() 메서드");

List<Product> products = new List<Product>()
{
    new Product(){ Name="마우스", Price=30000},
    new Product(){ Name="키보드", Price=50000},
    new Product(){ Name="헤드셋", Price=80000},
    new Product(){ Name="모니터", Price=300000},
};

Console.WriteLine("가격 오름차순:");
products.Sort(Comparer<Product>.Create((x,y)=>x.Price-y.Price));
Console.WriteLine(string.Join('\n',products));

Console.WriteLine();
Console.WriteLine("이름 내림차순:");
products.Sort(Comparer<Product>.Create((x, y) => y.Name.CompareTo(x.Name)));
Console.WriteLine(string.Join('\n', products));



Console.WriteLine();
Console.WriteLine("13. SortedDictionary와 비교기");

SortedDictionary<int, string> sortedDict = new(Comparer<int>.Create((x, y) => y.CompareTo(x)))
{
    { 92, "Choi" },
    { 85, "Kim" },
    { 78, "Park" }
};

Console.WriteLine("점수 순위표:");


Console.WriteLine();
Console.WriteLine("");
Console.WriteLine();
Console.WriteLine("");
Console.WriteLine();
Console.WriteLine("");
Console.WriteLine();
Console.WriteLine("");
