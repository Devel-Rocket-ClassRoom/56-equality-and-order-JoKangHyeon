using System;

class Monster : IComparable<Monster>
{
    public string Name { get; set; }
    public int Power    { get; set; }

    public int CompareTo(Monster other)
    {
        return other.Power - this.Power;
    }

    public override string ToString()
    {
        return $"  {Name}(전투력:{Power})";
    }
}
