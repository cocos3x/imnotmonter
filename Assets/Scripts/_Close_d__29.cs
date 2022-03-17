using UnityEngine;
private sealed class PopDailyRewardManager.<Close>d__29 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public PopDailyRewardManager <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public PopDailyRewardManager.<Close>d__29(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_4;
        var val_5;
        if((this.<>1__state) != 1)
        {
                val_4 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_4;
        }
        
            this.<>1__state = 0;
            GameTool.EventDispatcherExtension.PostEvent(sender:  this.<>4__this, eventID:  8);
            this.<>4__this.claimButton.interactable = false;
            this.<>4__this.claimX2Button.interactable = false;
            UnityEngine.WaitForSecondsRealtime val_1 = 536896855;
            val_1 = new UnityEngine.WaitForSecondsRealtime(time:  null);
            this.<>2__current = val_1;
            val_4 = 1;
            this.<>1__state = val_4;
            return (bool)val_4;
        }
        
        this.<>1__state = 0;
        this.CloseAnim();
        536882991 = new System.Action(object:  this.<>4__this, method:  new IntPtr(1610682021));
        System.Delegate val_3 = System.Delegate.Combine(a:  R6, b:  536882991);
        val_5 = R6;
        if(val_5 != 0)
        {
                if(val_5 == 536882991)
        {
            goto label_12;
        }
        
        }
        
        val_5 = 0;
        label_12:
        mem[1152921509734039484] = val_5;
        val_4 = 0;
        GameTool.EventDispatcherExtension.PostEvent(sender:  this.<>4__this, eventID:  24);
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
