using UnityEngine;
private sealed class WinPopup.<>c__DisplayClass82_0
{
    // Fields
    public WinPopup <>4__this;
    public int valueCoin;
    public int valueTape;
    
    // Methods
    public WinPopup.<>c__DisplayClass82_0()
    {
    
    }
    internal void <OpenChestFree>b__0()
    {
        float val_7;
        float val_8;
        var val_18;
        int val_19;
        var val_20;
        int val_21;
        UnityEngine.GameObject val_1 = this.<>4__this.freeChestReward.gameObject;
        this.<>4__this.freeChestReward.SetActive(value:  true);
        UnityEngine.Transform val_2 = this.<>4__this.freeChestReward.transform;
        UnityEngine.Vector3 val_3 = position;
        DG.Tweening.Tweener val_4 = DG.Tweening.ShortcutExtensions.DOMove(target:  this.<>4__this.freeChestReward, endValue:  new UnityEngine.Vector3(), duration:  val_3.x, snapping:  false);
        UnityEngine.Transform val_5 = this.<>4__this.freeChestReward.transform;
        UnityEngine.Vector2 val_6 = UnityEngine.Vector2.one;
        DG.Tweening.Tweener val_9 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.<>4__this.freeChestReward, endValue:  new UnityEngine.Vector3() {x = val_7, y = val_8, z = 0f}, duration:  val_6.x);
        object val_10 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883) != 0)
        {
                val_18 = -1073708883.Coin;
            val_19 = this.valueCoin;
        }
        else
        {
                val_18 = -1073708883.Coin;
            val_19 = this.valueCoin;
        }
        
        -1073708883.Coin = val_18 + val_19;
        object val_14 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883) != 0)
        {
                val_20 = -1073708883.Diamond;
            val_21 = this.valueTape;
        }
        else
        {
                val_20 = -1073708883.Diamond;
            val_21 = this.valueTape;
        }
        
        -1073708883.Diamond = val_20 + val_21;
        GameTool.EventDispatcherExtension.PostEvent(sender:  this.<>4__this, eventID:  8);
        this.<>4__this.Invoke(methodName:  -1610605255, time:  val_6.x);
    }

}
