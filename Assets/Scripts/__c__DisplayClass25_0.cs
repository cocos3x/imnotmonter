using UnityEngine;
private sealed class DOTweenModuleUI.<>c__DisplayClass25_0
{
    // Fields
    public UnityEngine.RectTransform target;
    
    // Methods
    public DOTweenModuleUI.<>c__DisplayClass25_0()
    {
    
    }
    internal UnityEngine.Vector2 <DOSizeDelta>b__0()
    {
        UnityEngine.Vector2 val_1 = sizeDelta;
        return new UnityEngine.Vector2() {x = val_1.x, y = val_1.y};
    }
    internal void <DOSizeDelta>b__1(UnityEngine.Vector2 x)
    {
        this.target.sizeDelta = new UnityEngine.Vector2() {x = x.x, y = x.y};
    }

}
