using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

class CustomerNameComparer : EqualityComparer<Customer>
{
    public override bool Equals(Customer x, Customer y)
    {
        return x.LastName.Equals(y.LastName) && x.FirstName.Equals(y.FirstName);
    }

    public override int GetHashCode([DisallowNull] Customer obj)
    {
        return HashCode.Combine(obj.LastName, obj.FirstName);
    }
}
