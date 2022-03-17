using UnityEngine;
private sealed class LotteryPopup.<DelayShowHome>d__15 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public LotteryPopup <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LotteryPopup.<DelayShowHome>d__15(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_4;
        if((this.<>1__state) != 1)
        {
                val_4 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_4;
        }
        
            this.<>1__state = 0;
            UnityEngine.GameObject val_1 = this.<>4__this.closeButton.gameObject;
            this.<>4__this.closeButton.SetActive(value:  false);
            UnityEngine.WaitForSeconds val_2 = 536896849;
            val_2 = new UnityEngine.WaitForSeconds(seconds:  null);
            this.<>2__current = val_2;
            val_4 = 1;
            this.<>1__state = val_4;
            return (bool)val_4;
        }
        
        this.<>1__state = 0;
        val_4 = 0;
        UnityEngine.GameObject val_3 = this.<>4__this.closeButton.gameObject;
        this.<>4__this.closeButton.SetActive(value:  true);
        return (bool)val_4;
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
