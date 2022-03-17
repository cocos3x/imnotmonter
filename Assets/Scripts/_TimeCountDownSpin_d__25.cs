using UnityEngine;
private sealed class GachaPopup.<TimeCountDownSpin>d__25 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public GachaPopup <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public GachaPopup.<TimeCountDownSpin>d__25(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_6;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        val_6 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_6;
        }
        
        this.<>1__state = 0;
        if((this.<>4__this) == 0)
        {
            goto label_3;
        }
        
        this.<>4__this.SetTime();
        float val_6 = -1f;
        val_6 = (this.<>4__this.timeRemaining) + val_6;
        this.<>4__this.timeRemaining = val_6;
        goto label_4;
        label_1:
        this.<>1__state = 0;
        val_6 = 0;
        UnityEngine.Coroutine val_1 = this.<>4__this.StartCoroutine(methodName:  -1610603445);
        return (bool)val_6;
        label_3:
        0.SetTime();
        mem[80] = (5.605194E-45f) + (-1f);
        label_4:
        if((this.<>4__this) > 0)
        {
                UnityEngine.WaitForSecondsRealtime val_3 = 536896855;
            val_3 = new UnityEngine.WaitForSecondsRealtime(time:  mem[80]);
            this.<>2__current = val_3;
            val_6 = 1;
            this.<>1__state = val_6;
            return (bool)val_6;
        }
        
        UnityEngine.GameObject val_4 = this.<>4__this.btn_Free.gameObject;
        this.<>4__this.btn_Free.SetActive(value:  true);
        UnityEngine.GameObject val_5 = this.<>4__this.btn_AdsRoll.gameObject;
        val_6 = 0;
        this.<>4__this.btn_AdsRoll.SetActive(value:  false);
        this.<>4__this.objTimeFree.SetActive(value:  false);
        return (bool)val_6;
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
