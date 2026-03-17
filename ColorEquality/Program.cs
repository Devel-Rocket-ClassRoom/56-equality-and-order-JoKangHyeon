using System;
using System.Collections.Generic;


Color R = new Color(255, 0, 0);
Color G = new Color(0, 255, 0);
Color B = new Color(0, 0, 255);

Console.WriteLine("=== 동등성 비교 ===");
Color compareTarget = new Color(255, 0, 0);
Console.WriteLine($"{R} == {compareTarget}: {R.Equals(compareTarget)}");
compareTarget = new Color(0, 0, 255);
Console.WriteLine($"{R} == {compareTarget}: {R.Equals(compareTarget)}");


Console.WriteLine();
Console.WriteLine("=== 유사 색상 판정 ===");
compareTarget = new Color(250, 5, 3);
Console.WriteLine($"{R}과 {compareTarget}은 유사한가 (임계값 10): {R.IsSimilar(compareTarget, 10)}");
compareTarget = new Color(200, 50, 50);
Console.WriteLine($"{R}과 {compareTarget}은 유사한가 (임계값 10): {R.IsSimilar(compareTarget, 10)}");


Console.WriteLine();
Console.WriteLine("=== HashSet 중복 제거 ===");
HashSet<Color> colorSet = new HashSet<Color>
{
    R,
    G,
    B
};

colorSet.Add(new Color(255, 0, 0));
Console.WriteLine("팔레트에 추가된 색상:");
foreach (Color color in colorSet)
{
    Console.WriteLine($"  {color}");
}
Console.WriteLine($"색상 수: {colorSet.Count}");


Console.WriteLine();
Console.WriteLine($"RGB(255, 0, 0) 포함 여부: {colorSet.Contains(new Color(255, 0, 0))}");
