using UnityEngine;
private sealed class WinPopup.<>c__DisplayClass83_0
{
    // Fields
    public int valueCoin;
    public int valueTape;
    public WinPopup <>4__this;
    
    // Methods
    public WinPopup.<>c__DisplayClass83_0()
    {
    
    }
    internal void <OpenChestAds>b__1()
    {
        float val_14;
        int val_24;
        var val_25;
        var val_26;
        int val_27;
        int val_1 = this.<>4__this.GetLockedSkinID();
        if(val_1 != 1)
        {
                val_24 = 22740800;
            object val_2 = AFramework.ManualSingletonMono<System.Object>.I;
            -1073708883.UnlockSkin(id:  val_1);
            object val_3 = AFramework.ManualSingletonMono<System.Object>.I;
            -1073708883.SkinSelectedID = val_1;
            object val_4 = AFramework.ManualSingletonMono<System.Object>.I;
            val_25 = -1073708883;
            if(val_25.IndexGetSkinProgress == 1)
        {
                WorldTimeAPI val_6 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            val_25 = -1073700919;
            val_25.LoadSceneHome();
        }
        
            UnityEngine.Coroutine val_7 = this.<>4__this.StartCoroutine(methodName:  -1610604625, value:  536888987);
            return;
        }
        
        UnityEngine.GameObject val_8 = this.<>4__this.freeChestReward.gameObject;
        this.<>4__this.freeChestReward.SetActive(value:  true);
        UnityEngine.Transform val_9 = this.<>4__this.freeChestReward.transform;
        UnityEngine.Vector3 val_10 = val_1.position;
        DG.Tweening.Tweener val_11 = DG.Tweening.ShortcutExtensions.DOMove(target:  this.<>4__this.freeChestReward, endValue:  new UnityEngine.Vector3() {x = val_1}, duration:  val_10.x, snapping:  false);
        UnityEngine.Transform val_12 = this.<>4__this.freeChestReward.transform;
        UnityEngine.Vector2 val_13 = UnityEngine.Vector2.one;
        DG.Tweening.Tweener val_15 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.<>4__this.freeChestReward, endValue:  new UnityEngine.Vector3() {x = val_1, y = val_14, z = 0f}, duration:  val_13.x);
        object val_16 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883) != 0)
        {
                val_26 = -1073708883.Coin;
            val_27 = this.valueCoin;
        }
        else
        {
                val_26 = -1073708883.Coin;
            val_27 = this.valueCoin;
        }
        
        -1073708883.Coin = val_26 + (val_27 << 1);
        object val_20 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883) != 0)
        {
                val_25 = -1073708883.Diamond;
            val_24 = this.valueTape;
        }
        else
        {
                val_25 = -1073708883.Diamond;
            val_24 = this.valueTape;
        }
        
        -1073708883.Diamond = val_25 + (val_24 << 1);
        GameTool.EventDispatcherExtension.PostEvent(sender:  this.<>4__this, eventID:  8);
    }
    internal void <OpenChestAds>b__2()
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
        
        -1073708883.Coin = val_18 + (val_19 << 1);
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
        
        -1073708883.Diamond = val_20 + (val_21 << 1);
        GameTool.EventDispatcherExtension.PostEvent(sender:  this.<>4__this, eventID:  8);
    }

}
