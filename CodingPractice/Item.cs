using System;

class Item:IEquatable<Item>
{
    public string Name { get; set; }
    public int Id { get; set; }

    public Item(string name, int id)
    {
        Name = name;
        Id = id;
    }

    public bool Equals(Item other)
    {
        return Name == other.Name && Id == other.Id;
    }

    public override bool Equals(object obj)
    {
        if(obj is Item)
        {
            return Equals(obj as Item);
        }
        return base.Equals(obj);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Name.GetHashCode(), Id.GetHashCode());
    }
}
