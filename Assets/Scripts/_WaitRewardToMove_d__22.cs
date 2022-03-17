using UnityEngine;
private sealed class LotterySlotController.<WaitRewardToMove>d__22 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public LotterySlotController <>4__this;
    public int value;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LotterySlotController.<WaitRewardToMove>d__22(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_25;
        int val_26;
        var val_27;
        var val_28;
        if((this.<>1__state) != 1)
        {
                val_25 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_25;
        }
        
            this.<>1__state = 0;
            if((SingletonMonoBehaviour<TransitionFX>.Exists()) != false)
        {
                WorldTimeAPI val_2 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            -1073701113.Shot(clip:  -1610605587, volume:  null);
        }
        
            UnityEngine.WaitForSecondsRealtime val_4 = 536896855;
            val_4 = new UnityEngine.WaitForSecondsRealtime(time:  this.<>4__this.GetTimeDurationBoxAnimation(name:  -1610598931));
            this.<>2__current = val_4;
            val_25 = 1;
            this.<>1__state = val_25;
            return (bool)val_25;
        }
        
        this.<>1__state = 0;
        UnityEngine.GameObject val_5 = this.<>4__this.textQuestionMark.gameObject;
        this.<>4__this.textQuestionMark.SetActive(value:  false);
        if((this.<>4__this.typeItemLottery) == 2)
        {
            goto label_10;
        }
        
        if((this.<>4__this.typeItemLottery) == 1)
        {
            goto label_11;
        }
        
        if((this.<>4__this.typeItemLottery) != 0)
        {
            goto label_31;
        }
        
        string val_6 = this.value.ToString();
        string val_7 = -1610611917(-1610611917) + this.value;
        this.<>4__this.rewardCoinValueText.text = -1610611917;
        this.<>4__this.rewardCoin.SetActive(value:  true);
        Weight val_8 = this.<>4__this.rewardCoin.GetComponent<Weight>();
        object val_9 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883) == 0)
        {
            goto label_17;
        }
        
        val_26 = -1073708883.Coin;
        val_27 = mem[this.value];
        val_27 = this.value;
        goto label_18;
        label_10:
        System.Collections.IEnumerator val_11 = this.<>4__this.SetSkinRewardAnimation(skinId:  this.value);
        UnityEngine.Coroutine val_12 = this.<>4__this.StartCoroutine(routine:  this.<>4__this);
        this.<>4__this.rewardSkin.SetActive(value:  true);
        Weight val_13 = this.<>4__this.rewardSkin.GetComponent<Weight>();
        object val_14 = AFramework.ManualSingletonMono<System.Object>.I;
        val_26 = this.value;
        -1073708883.UnlockSkin(id:  val_26);
        object val_15 = AFramework.ManualSingletonMono<System.Object>.I;
        -1073708883.SkinSelectedID = this.value;
        GameTool.EventDispatcherExtension.PostEvent(sender:  this.<>4__this, eventID:  10);
        goto label_31;
        label_11:
        string val_16 = this.value.ToString();
        string val_17 = -1610611917(-1610611917) + this.value;
        this.<>4__this.rewardTapeValueText.text = -1610611917;
        this.<>4__this.rewardTape.SetActive(value:  true);
        Weight val_18 = this.<>4__this.rewardTape.GetComponent<Weight>();
        object val_19 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883) == 0)
        {
            goto label_29;
        }
        
        val_26 = -1073708883.Diamond;
        val_28 = mem[this.value];
        val_28 = this.value;
        goto label_30;
        label_17:
        val_26 = -1073708883.Coin;
        val_27 = mem[this.value];
        val_27 = this.value;
        label_18:
        -1073708883.Coin = val_26 + val_27;
        goto label_31;
        label_29:
        val_26 = -1073708883.Diamond;
        val_28 = mem[this.value];
        val_28 = this.value;
        label_30:
        -1073708883.Diamond = val_26 + val_28;
        label_31:
        val_25 = 0;
        GameTool.EventDispatcherExtension.PostEvent(sender:  this.<>4__this, eventID:  8);
        return (bool)val_25;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
    
    }
    private void System.Collections.IEnumerator.Reset()
    {
        22713476 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
    
    }

}
