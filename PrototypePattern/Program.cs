using System;

namespace PrototypePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rose originalRose = new Rose("Rose", 20, "Red");
            Rose clonedRose = originalRose.MyClone();

            Console.WriteLine($"Original Rose: {originalRose.Name}, {originalRose.PetalCount}, {originalRose.Color}");
            Console.WriteLine($"Cloned Rose: {clonedRose.Name}, {clonedRose.PetalCount}, {clonedRose.Color}");

            Tree originalTree = new Tree("Oak", 10, "Broadleaf");
            Tree clonedTree = originalTree.MyClone();
            Console.WriteLine($"Original Tree: {originalTree.Name}, {originalTree.Height}, {originalTree.LeafType}");
            Console.WriteLine($"Cloned Tree: {clonedTree.Name}, {clonedTree.Height}, {clonedTree.LeafType}");

            Rose clonedRoseObj = (Rose)((ICloneable)originalRose).Clone();
            Tree clonedTreeFromObj = (Tree)((ICloneable)originalTree).Clone();
            Console.WriteLine($"Cloned Tree from ICloneable: {clonedTreeFromObj.Name}, {clonedTreeFromObj.Height}, {clonedTreeFromObj.LeafType}");
            Console.WriteLine($"Cloned Rose from ICloneable: {clonedRoseObj.Name}, {clonedRoseObj.PetalCount}, {clonedRoseObj.Color}");
        }
    }
}
