namespace PrototypePattern;

public class Tree : Plant, IMyCloneable<Tree>, ICloneable
{
    public int Height { get; set; }
    public string LeafType { get; set; }
    public Tree(string name, int height, string leaftype) : base(name)
    {
        Height = height;
        LeafType = leaftype;
    }
    public new object Clone()
    {
        return this.MemberwiseClone();
    }

    public new Tree MyClone()
    {
        return new Tree(Name, Height, LeafType);
    }
}
