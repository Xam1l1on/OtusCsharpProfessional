namespace PrototypePattern;

public class Rose : Flower, IMyCloneable<Rose>, ICloneable
{
    public string Color { get; set; }
    public Rose(string name, int petalCount, string color) : base(name, petalCount)
    {
        Color = color;
    }
    public new object Clone()
    {
        return this.MemberwiseClone();
    }
    public new Rose MyClone()
    {
        return new Rose(Name, PetalCount, Color);
    }
}
