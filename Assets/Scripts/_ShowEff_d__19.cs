using UnityEngine;
private sealed class TextEffect.<ShowEff>d__19 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public TextEffect <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public TextEffect.<ShowEff>d__19(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        bool val_10;
        string val_11;
        val_10 = 0;
        if(((this.<>1__state) - 1) < 2)
        {
                this.<>1__state = 0;
            if((this.<>4__this.isWin) == true)
        {
                return val_10;
        }
        
            UnityEngine.GameObject val_2 = this.<>4__this.animation.gameObject;
            val_10 = 0;
            this.<>4__this.animation.SetActive(value:  true);
            WorldTimeAPI val_3 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            -1073701113.Shot(clip:  -1610607745, volume:  null);
            val_11 = this.<>4__this.spawn;
            536882991 = new System.Action(object:  this.<>4__this, method:  new IntPtr(1610680845));
            MixSkinManager.SetAnimation(ske:  this.<>4__this.animation, name:  val_11, loop:  false, timeScale:  null, _callBack:  1065353216);
            return val_10;
        }
        
        if((this.<>1__state) != 0)
        {
                return val_10;
        }
        
        this.<>1__state = 0;
        UnityEngine.GameObject val_5 = this.<>4__this.animation.gameObject;
        this.<>4__this.animation.SetActive(value:  false);
        if((this.<>4__this.firstTime) != false)
        {
                UnityEngine.WaitForSecondsRealtime val_7 = 536896855;
            val_7 = new UnityEngine.WaitForSecondsRealtime(time:  UnityEngine.Random.Range(minInclusive:  null, maxInclusive:  null));
            this.<>2__current = val_7;
            val_10 = 1;
            this.<>1__state = 2;
            return val_10;
        }
        
        val_10 = true;
        this.<>4__this.firstTime = val_10;
        UnityEngine.WaitForSecondsRealtime val_9 = 536896855;
        val_11 = val_9;
        val_9 = new UnityEngine.WaitForSecondsRealtime(time:  (float)UnityEngine.Random.Range(minInclusive:  2, maxExclusive:  4));
        this.<>2__current = val_11;
        this.<>1__state = val_10;
        return val_10;
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
