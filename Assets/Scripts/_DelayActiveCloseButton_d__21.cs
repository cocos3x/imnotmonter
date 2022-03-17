using UnityEngine;
private sealed class LotteryPopup.<DelayActiveCloseButton>d__21 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public LotteryPopup <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LotteryPopup.<DelayActiveCloseButton>d__21(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_3;
        if((this.<>1__state) != 1)
        {
                val_3 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_3;
        }
        
            this.<>1__state = 0;
            UnityEngine.WaitForSecondsRealtime val_1 = 536896855;
            val_1 = new UnityEngine.WaitForSecondsRealtime(time:  null);
            this.<>2__current = val_1;
            val_3 = 1;
            this.<>1__state = val_3;
            return (bool)val_3;
        }
        
        this.<>1__state = 0;
        val_3 = 0;
        UnityEngine.GameObject val_2 = this.<>4__this.closeButton.gameObject;
        this.<>4__this.closeButton.SetActive(value:  true);
        return (bool)val_3;
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
