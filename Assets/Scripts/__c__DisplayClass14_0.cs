using UnityEngine;
private sealed class DOTweenModuleUI.<>c__DisplayClass14_0
{
    // Fields
    public UnityEngine.RectTransform target;
    
    // Methods
    public DOTweenModuleUI.<>c__DisplayClass14_0()
    {
    
    }
    internal UnityEngine.Vector2 <DOAnchorPosX>b__0()
    {
        UnityEngine.Vector2 val_1 = anchoredPosition;
        return new UnityEngine.Vector2() {x = val_1.x, y = val_1.y};
    }
    internal void <DOAnchorPosX>b__1(UnityEngine.Vector2 x)
    {
        this.target.anchoredPosition = new UnityEngine.Vector2() {x = x.x, y = x.y};
    }

}
