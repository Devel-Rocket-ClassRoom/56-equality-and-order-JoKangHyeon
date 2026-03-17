using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

class ItemGradeComparer : EqualityComparer<Item>
{
    public override bool Equals(Item x, Item y)
    {
        return x.Grade == y.Grade;
    }

    public override int GetHashCode([DisallowNull] Item obj)
    {
        return obj.Grade.GetHashCode();
    }
}