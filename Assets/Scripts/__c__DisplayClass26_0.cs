using UnityEngine;
private sealed class DOTweenModuleUI.<>c__DisplayClass26_0
{
    // Fields
    public UnityEngine.RectTransform target;
    
    // Methods
    public DOTweenModuleUI.<>c__DisplayClass26_0()
    {
    
    }
    internal UnityEngine.Vector3 <DOPunchAnchorPos>b__0()
    {
        UnityEngine.Vector2 val_1 = anchoredPosition;
        return new UnityEngine.Vector3() {x = val_1.x, y = val_1.y};
    }
    internal void <DOPunchAnchorPos>b__1(UnityEngine.Vector3 x)
    {
        this.target.anchoredPosition = new UnityEngine.Vector2() {x = x.x, y = x.y};
    }

}
