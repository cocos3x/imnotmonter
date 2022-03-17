using UnityEngine;
private sealed class DOTweenModuleUnityVersion.<>c__DisplayClass8_0
{
    // Fields
    public UnityEngine.Material target;
    public int propertyID;
    
    // Methods
    public DOTweenModuleUnityVersion.<>c__DisplayClass8_0()
    {
    
    }
    internal UnityEngine.Vector2 <DOOffset>b__0()
    {
        UnityEngine.Vector2 val_1 = GetTextureOffset(nameID:  R1 + 8);
        return new UnityEngine.Vector2() {x = val_1.x, y = val_1.y};
    }
    internal void <DOOffset>b__1(UnityEngine.Vector2 x)
    {
        this.target.SetTextureOffset(nameID:  this.propertyID, value:  new UnityEngine.Vector2() {x = x.x, y = x.y});
    }

}
