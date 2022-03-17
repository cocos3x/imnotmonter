using UnityEngine;
public class RecolorTree.TreePoint
{
    // Fields
    public UnityEngine.Vector3 point;
    public UnityEngine.Color data;
    
    // Methods
    public RecolorTree.TreePoint(UnityEngine.Vector3 aPoint, UnityEngine.Color aData)
    {
        this.point = aPoint;
        mem[1152921510131943100] = aPoint.y;
        mem[1152921510131943104] = aPoint.z;
        this.data = aData;
    }

}
