using UnityEngine;
[Serializable]
public class Piece.NodeArray
{
    // Fields
    public WrappingRopeLibrary.Model.Node[] _array;
    
    // Properties
    public WrappingRopeLibrary.Model.Node Item { get; }
    public WrappingRopeLibrary.Model.Node[] SourceArray { get; }
    
    // Methods
    public Piece.NodeArray(WrappingRopeLibrary.Model.Node[] array)
    {
        this._array = array;
    }
    public WrappingRopeLibrary.Model.Node get_Item(int i)
    {
        var val_1 = R2 + (R2 << 1);
        val_1 = (i + 8) + (val_1 << 4);
        val_1 = val_1 + 16;
        return new WrappingRopeLibrary.Model.Node() {_vertex = new UnityEngine.Vector3() {x = ((i + 8 + ((R2 + (R2) << 1)) << 4) + 16) + (24), y = mem[((i + 8 + ((R2 + (R2) << 1)) << 4) + 16) + (24) + (0)], z = mem[((i + 8 + ((R2 + (R2) << 1)) << 4) + 16) + (24) + (4)]}, _uv = new UnityEngine.Vector2() {x = mem[((i + 8 + ((R2 + (R2) << 1)) << 4) + 16) + (24) + (8)]}, _averageNormal = new UnityEngine.Vector3()};
    }
    public WrappingRopeLibrary.Model.Node[] get_SourceArray()
    {
    
    }
    public static WrappingRopeLibrary.Model.Node[] op_Implicit(WrappingRopeLibrary.Scripts.Piece.NodeArray nodeArray)
    {
        if(nodeArray != 0)
        {
                return;
        }
    
    }

}
