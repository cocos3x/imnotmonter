using UnityEngine;
private sealed class WinPopup.<>c__DisplayClass68_2
{
    // Fields
    public UnityEngine.GameObject coin;
    public WinPopup.<>c__DisplayClass68_0 CS$<>8__locals2;
    public DG.Tweening.TweenCallback <>9__3;
    
    // Methods
    public WinPopup.<>c__DisplayClass68_2()
    {
    
    }
    internal void <CoinMoves>b__2()
    {
        DG.Tweening.TweenCallback val_7;
        UnityEngine.Vector3 val_1 = position;
        UnityEngine.Transform val_2 = this.coin.transform;
        DG.Tweening.Tweener val_3 = DG.Tweening.ShortcutExtensions.DOMove(target:  this.coin, endValue:  new UnityEngine.Vector3() {x = R5, y = R6, z = R7}, duration:  val_1.x, snapping:  true);
        DG.Tweening.Tweener val_4 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  this.coin, ease:  7);
        val_7 = this.<>9__3;
        if(val_7 == 0)
        {
                val_7 = 536895905;
            val_7 = new DG.Tweening.TweenCallback(object:  787042960, method:  new IntPtr(1610681459));
            this.<>9__3 = val_7;
        }
        
        DG.Tweening.Tweener val_6 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  this.coin, action:  536895905);
    }
    internal void <CoinMoves>b__3()
    {
        var val_10;
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701113.Shot(clip:  -1610609309, volume:  null);
        WorldTimeAPI val_2 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701087.Despaw(go:  this.coin, delay:  null);
        DG.Tweening.Tweener val_3 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.CS$<>8__locals2.<>4__this.coinTargetPos, endValue:  new UnityEngine.Vector3() {x = 1.2f, y = 1.2f, z = 1.2f}, duration:  null);
        DG.Tweening.Tweener val_4 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  this.CS$<>8__locals2.<>4__this.coinTargetPos, ease:  1);
        DG.Tweening.Tweener val_5 = DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Tweener>(t:  this.CS$<>8__locals2.<>4__this.coinTargetPos, loops:  2, loopType:  1);
        object val_6 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883) != 0)
        {
                val_10 = -1073708883.Diamond;
        }
        else
        {
                val_10 = -1073708883.Diamond;
        }
        
        -1073708883.Diamond = val_10 + 1;
        GameTool.EventDispatcherExtension.PostEvent(sender:  this.CS$<>8__locals2.<>4__this, eventID:  8);
    }

}
