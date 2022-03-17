using UnityEngine;
private sealed class DOTweenModuleUI.<>c__DisplayClass29_0
{
    // Fields
    public UnityEngine.RectTransform target;
    public float startPosY;
    public bool offsetYSet;
    public float offsetY;
    public DG.Tweening.Sequence s;
    public UnityEngine.Vector2 endValue;
    
    // Methods
    public DOTweenModuleUI.<>c__DisplayClass29_0()
    {
    
    }
    internal UnityEngine.Vector2 <DOJumpAnchorPos>b__0()
    {
        UnityEngine.Vector2 val_1 = anchoredPosition;
        return new UnityEngine.Vector2() {x = val_1.x, y = val_1.y};
    }
    internal void <DOJumpAnchorPos>b__1(UnityEngine.Vector2 x)
    {
        this.target.anchoredPosition = new UnityEngine.Vector2() {x = x.x, y = x.y};
    }
    internal void <DOJumpAnchorPos>b__2()
    {
        float val_2;
        UnityEngine.Vector2 val_1 = anchoredPosition;
        this.startPosY = val_2;
    }
    internal UnityEngine.Vector2 <DOJumpAnchorPos>b__3()
    {
        UnityEngine.Vector2 val_1 = anchoredPosition;
        return new UnityEngine.Vector2() {x = val_1.x, y = val_1.y};
    }
    internal void <DOJumpAnchorPos>b__4(UnityEngine.Vector2 x)
    {
        this.target.anchoredPosition = new UnityEngine.Vector2() {x = x.x, y = x.y};
    }
    internal void <DOJumpAnchorPos>b__5()
    {
        float val_2;
        var val_3;
        if(this.offsetYSet != true)
        {
                this.offsetYSet = true;
            this.offsetY = S0 - this.startPosY;
        }
        
        UnityEngine.Vector2 val_1 = anchoredPosition;
        float val_5 = DG.Tweening.DOVirtual.EasedValue(from:  DG.Tweening.TweenExtensions.ElapsedDirectionalPercentage(t:  this.s), to:  val_1.y, lifetimePercentage:  this.startPosY, easeType:  0);
        uint val_6 = 0;
        val_6 = val_3 + val_6;
        this.target.anchoredPosition = new UnityEngine.Vector2() {x = val_2};
    }

}
