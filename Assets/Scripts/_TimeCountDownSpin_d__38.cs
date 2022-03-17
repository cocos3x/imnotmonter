using UnityEngine;
private sealed class SpinManager.<TimeCountDownSpin>d__38 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public SpinManager <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public SpinManager.<TimeCountDownSpin>d__38(int <>1__state)
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
        
        this.<>4__this.SetTime();
        float val_8 = -1f;
        val_8 = (this.<>4__this.timeRemaining) + val_8;
        this.<>4__this.timeRemaining = val_8;
        goto label_4;
        label_1:
        this.<>1__state = 0;
        if((this.<>4__this) == 0)
        {
            goto label_5;
        }
        
        System.Collections.IEnumerator val_1 = this.<>4__this.TimeCountDownSpin();
        val_9 = this.<>4__this;
        goto label_6;
        label_3:
        0.SetTime();
        mem[152] = (3.915561E-38f) + (-1f);
        label_4:
        if((this.<>4__this) > 0)
        {
                UnityEngine.WaitForSecondsRealtime val_3 = 536896855;
            val_3 = new UnityEngine.WaitForSecondsRealtime(time:  mem[152]);
            this.<>2__current = val_3;
            val_8 = 1;
            this.<>1__state = val_8;
            return (bool)val_8;
        }
        
        UnityEngine.GameObject val_4 = this.<>4__this.btnSpin.gameObject;
        this.<>4__this.btnSpin.SetActive(value:  true);
        UnityEngine.GameObject val_5 = this.<>4__this.btnSpinAds.gameObject;
        val_8 = 0;
        this.<>4__this.btnSpinAds.SetActive(value:  false);
        this.<>4__this.txtNumberSpin.text = -1610605047;
        return (bool)val_8;
        label_5:
        System.Collections.IEnumerator val_6 = 0.TimeCountDownSpin();
        val_9 = 0;
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
