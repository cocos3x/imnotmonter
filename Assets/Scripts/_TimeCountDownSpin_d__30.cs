using UnityEngine;
private sealed class SpinPopup.<TimeCountDownSpin>d__30 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public SpinPopup <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public SpinPopup.<TimeCountDownSpin>d__30(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_8;
        var val_9;
        PickerWheel val_10;
        var val_11;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        val_8 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_8;
        }
        
        this.<>1__state = 0;
        if((this.<>4__this) == 0)
        {
            goto label_3;
        }
        
        val_9 = this.<>4__this;
        val_10 = this.<>4__this.wheel;
        goto label_4;
        label_1:
        this.<>1__state = 0;
        if((this.<>4__this) == 0)
        {
            goto label_5;
        }
        
        System.Collections.IEnumerator val_1 = this.<>4__this.TimeCountDownSpin();
        val_11 = this.<>4__this;
        goto label_6;
        label_3:
        val_9 = 36;
        val_10 = 83886592;
        label_4:
        string val_2 = AbbrevationUtility.AbbrevationTimeHMS(time:  null);
        val_10.SetNotifText(value:  this.<>4__this.timeRemaining);
        float val_8 = -1f;
        val_8 = (this.<>4__this.timeRemaining) + val_8;
        this.<>4__this.timeRemaining = val_8;
        if(val_10 > 0)
        {
                UnityEngine.WaitForSecondsRealtime val_3 = 536896855;
            val_3 = new UnityEngine.WaitForSecondsRealtime(time:  val_8);
            this.<>2__current = val_3;
            val_8 = 1;
            this.<>1__state = val_8;
            return (bool)val_8;
        }
        
        UnityEngine.GameObject val_4 = this.<>4__this.spinButton.gameObject;
        this.<>4__this.spinButton.SetActive(value:  true);
        UnityEngine.GameObject val_5 = this.<>4__this.spinAdsButton.gameObject;
        val_8 = 0;
        this.<>4__this.spinAdsButton.SetActive(value:  false);
        val_9.SetNotifText(value:  -1610605047);
        this.<>4__this.isFreeSpin = true;
        return (bool)val_8;
        label_5:
        System.Collections.IEnumerator val_6 = 0.TimeCountDownSpin();
        val_11 = 0;
        label_6:
        val_8 = 0;
        UnityEngine.Coroutine val_7 = this.<>4__this.StartCoroutine(routine:  0);
        return (bool)val_8;
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
