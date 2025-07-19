namespace PrototypePattern;

public class Flower : Plant, IMyCloneable<Flower>, ICloneable
{
    public int PetalCount { get; set; }
    public Flower(string name, int petalCount) : base(name)
    {
        PetalCount = petalCount;
    }
    public new object Clone()
    {
        // Shallow copy using MemberwiseClone
        return this.MemberwiseClone();
    }
    public new Flower MyClone()
    {
        return new Flower(Name, PetalCount);
    }
}
