using UnityEngine;
private sealed class SetAnimationPlayer.<WaitSkeleton>d__16 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public SetAnimationPlayer <>4__this;
    public System.Action _callBack;
    public string name;
    public bool loop;
    private SetAnimationPlayer.<>c__DisplayClass16_0 <>8__1;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public SetAnimationPlayer.<WaitSkeleton>d__16(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_6;
        Spine.AnimationState val_7;
        if((this.<>1__state) != 1)
        {
                val_6 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_6;
        }
        
            this.<>1__state = 0;
            object val_1 = 536901017;
            val_1 = new System.Object();
            this.<>8__1 = val_1;
            this.<>8__1.<>4__this = this.<>4__this;
            this.<>8__1._callBack = this._callBack;
            536875159 = new System.Func<System.Boolean>(object:  this.<>8__1, method:  new IntPtr(1610680469));
            UnityEngine.WaitUntil val_3 = 536896879;
            val_3 = new UnityEngine.WaitUntil(predicate:  536875159);
            this.<>2__current = val_3;
            val_6 = 1;
            this.<>1__state = val_6;
            return (bool)val_6;
        }
        
        this.<>1__state = 0;
        val_7 = this.<>4__this.skeletonAnimation.state;
        if(this.loop == true)
        {
                this.loop = 1;
        }
        
        Spine.TrackEntry val_4 = val_7.SetAnimation(trackIndex:  0, animationName:  this.name, loop:  true);
        this.<>4__this.skeletonAnimation.timeScale = 1f;
        if((this.<>8__1._callBack) != 0)
        {
                val_7 = this.<>8__1;
            val_6 = 0;
            536897929 = new AnimationState.TrackEntryDelegate(object:  val_7, method:  new IntPtr(1610680471));
            val_7.add_Complete(value:  536897929);
            return (bool)val_6;
        }
        
        val_6 = 0;
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
