using UnityEngine;
private sealed class API.<OnShowLoading>d__21 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public API <>4__this;
    public System.Action onClosedLoading;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public API.<OnShowLoading>d__21(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        API val_2;
        int val_3;
        float val_4;
        val_2 = this.<>4__this;
        if((this.<>1__state) != 1)
        {
                val_3 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_3;
        }
        
            this.<>1__state = 0;
            val_3 = 1;
            this.<>4__this.loadingObj.SetActive(value:  true);
            val_4 = this.<>4__this.ApiInfor.TimeLoading;
            UnityEngine.WaitForSecondsRealtime val_1 = 536896855;
            val_2 = val_1;
            val_1 = new UnityEngine.WaitForSecondsRealtime(time:  null);
            this.<>2__current = val_2;
            this.<>1__state = val_3;
            return (bool)val_3;
        }
        
        this.<>1__state = 0;
        val_4 = this.<>4__this.loadingObj;
        val_3 = 0;
        val_4.SetActive(value:  false);
        if(this.onClosedLoading == 0)
        {
                return (bool)val_3;
        }
        
        val_3 = 0;
        this.onClosedLoading.Invoke();
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
