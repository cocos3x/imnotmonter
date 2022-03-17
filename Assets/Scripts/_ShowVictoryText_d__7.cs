using UnityEngine;
private sealed class LosePopup.<ShowVictoryText>d__7 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public LosePopup <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LosePopup.<ShowVictoryText>d__7(int <>1__state)
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
            536875159 = new System.Func<System.Boolean>(object:  this.<>4__this, method:  new IntPtr(1610680971));
            UnityEngine.WaitUntil val_2 = 536896879;
            val_2 = new UnityEngine.WaitUntil(predicate:  536875159);
            this.<>2__current = val_2;
            val_4 = 1;
            this.<>1__state = val_4;
            return (bool)val_4;
        }
        
        this.<>1__state = 0;
        val_4 = 0;
        MixSkinManager.SetAnimation(ske:  this.<>4__this.victoryTextSkeleton, name:  -1610600885, loop:  true, timeScale:  null, _callBack:  1065353216);
        536882991 = new System.Action(object:  this.<>4__this, method:  new IntPtr(1610680973));
        MixSkinManager.SetAnimation(ske:  this.<>4__this.victoryTextSkeleton, name:  -1610598097, loop:  false, timeScale:  null, _callBack:  1065353216);
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
