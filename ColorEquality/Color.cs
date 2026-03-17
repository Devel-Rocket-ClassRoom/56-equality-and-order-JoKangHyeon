using System;

class Color : IEquatable<Color>
{
    public int R { get; set; }
    public int G { get; set; }
    public int B { get; set; }

    public Color(int r, int g, int b)
    {
        R = r;
        G = g;
        B = b;
    }

    public bool Equals(Color other)
    {
        return other.R == R && other.G == G && other.B == B;
    }

    public override bool Equals(object obj)
    {
        if (obj is Color)
        {
            return Equals(obj as Color);
        }
        return base.Equals(obj);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(R, G, B);
    }

    public bool IsSimilar(Color other, int threshold)
    {
        return Math.Abs(R - other.R) <= threshold &&
               Math.Abs(G - other.G) <= threshold &&
               Math.Abs(B - other.B) <= threshold;
    }

    public override string ToString()
    {
        return $"RGB({R}, {G}, {B})";
    }
}