using UnityEngine;
private sealed class DOTweenModuleUnityVersion.<>c__DisplayClass9_0
{
    // Fields
    public UnityEngine.Material target;
    public int propertyID;
    
    // Methods
    public DOTweenModuleUnityVersion.<>c__DisplayClass9_0()
    {
    
    }
    internal UnityEngine.Vector2 <DOTiling>b__0()
    {
        UnityEngine.Vector2 val_1 = GetTextureScale(nameID:  R1 + 8);
        return new UnityEngine.Vector2() {x = val_1.x, y = val_1.y};
    }
    internal void <DOTiling>b__1(UnityEngine.Vector2 x)
    {
        this.target.SetTextureScale(nameID:  this.propertyID, value:  new UnityEngine.Vector2() {x = x.x, y = x.y});
    }

}
