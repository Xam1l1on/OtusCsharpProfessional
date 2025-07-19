namespace PrototypePattern;

public class Plant : IMyCloneable<Plant>, ICloneable
{
    public string Name { get; set; }
    public Plant(string name)
    {
        Name = name;
    }
    public object Clone()
    {
        return this.MemberwiseClone();
    }
    public Plant MyClone()
    {
        return new Plant(Name);
    }
}
