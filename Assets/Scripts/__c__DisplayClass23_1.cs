using UnityEngine;
private sealed class GameObjectWraper.WrapPathFinder.<>c__DisplayClass23_1
{
    // Fields
    public WrappingRopeLibrary.Model.WrapPoint crossPoint;
    public WrappingRopeLibrary.Utils.GameObjectWraper.WrapPathFinder.<>c__DisplayClass23_0 CS$<>8__locals1;
    
    // Methods
    public GameObjectWraper.WrapPathFinder.<>c__DisplayClass23_1()
    {
    
    }
    internal bool <DefineWrapPatchPoint>b__1(WrappingRopeLibrary.Model.WrapPoint p)
    {
        if((this.CS$<>8__locals1.plane.GetSide(point:  new UnityEngine.Vector3() {x = mem[p.origin + (0)], y = mem[p.origin + (4)], z = mem[p.origin + (8)]})) == false)
        {
                return (bool)0;
        }
        
        0 = (p.Equals(obj:  this.crossPoint)) ^ 1;
        return (bool)0;
    }

}
