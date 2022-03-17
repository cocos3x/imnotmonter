using UnityEngine;
private sealed class TextEffect.<IdleEff>d__20 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public TextEffect <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public TextEffect.<IdleEff>d__20(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_3;
        Spine.Unity.SkeletonAnimation val_4;
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
        if((this.<>4__this) != 0)
        {
                val_4 = this.<>4__this.animation;
        }
        else
        {
                val_4 = 0;
        }
        
        val_3 = 0;
        536882991 = new System.Action(object:  this.<>4__this, method:  new IntPtr(1610680847));
        MixSkinManager.SetAnimation(ske:  0, name:  this.<>4__this.disapear, loop:  false, timeScale:  null, _callBack:  1065353216);
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
