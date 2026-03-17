using System;

class BadItem:IEquatable<BadItem>
{
    public string Name { get; set; }
    public int Id { get; set; }

    public BadItem(string name, int id)
    {
        Name = name;
        Id = id;
    }

    public bool Equals(BadItem other)
    {
        return Name == other.Name && Id == other.Id;
    }

    public override bool Equals(object obj)
    {
        if (obj is Item)
        {
            return Equals(obj as Item);
        }
        return base.Equals(obj);
    }
}
