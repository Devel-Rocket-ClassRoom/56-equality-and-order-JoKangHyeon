using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

class ItemTypeComparer : EqualityComparer<Item>
{
    public override bool Equals(Item x, Item y)
    {
        return x.Type == y.Type;
    }

    public override int GetHashCode([DisallowNull] Item obj)
    {
        return obj.Type.GetHashCode();
    }
}
