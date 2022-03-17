using UnityEngine;
private sealed class ProCamera2DShake.<ApplyShakesTimedRoutine>d__43 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Com.LuisPedroFonseca.ProCamera2D.ProCamera2DShake <>4__this;
    public float[] durations;
    public System.Collections.Generic.IList<UnityEngine.Vector2> shakes;
    public System.Collections.Generic.IList<UnityEngine.Quaternion> rotations;
    public bool ignoreTimeScale;
    private int <count>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ProCamera2DShake.<ApplyShakesTimedRoutine>d__43(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_4;
        float val_5;
        int val_9;
        int val_10;
        System.Single[] val_11;
        var val_12;
        var val_13;
        object val_14;
        val_9 = 0;
        if((this.<>1__state) != 1)
        {
                if((this.<>1__state) != 0)
        {
                return (bool)val_9;
        }
        
            val_10 = 0;
            this.<>1__state = val_10;
            536877835 = new System.Collections.Generic.List<Page>();
            this.<>4__this._shakeTimedCoroutines = 536877835;
            this.<count>5__2 = val_10;
        }
        else
        {
                val_10 = this.<count>5__2;
            int val_9 = 0;
            this.<>1__state = val_9;
        }
        
        val_11 = this.durations;
        val_9 = val_9 - 1;
        if(val_10 >= val_9)
        {
                return (bool)val_9;
        }
        
        int val_2 = (this.<count>5__2) + 1;
        this.<count>5__2 = val_2;
        var val_11 = 0;
        val_11 = val_11 + 1;
        val_12 = this.shakes;
        var val_12 = 0;
        val_12 = val_12 + 1;
        val_13 = this.rotations;
        if(this.ignoreTimeScale == true)
        {
                this.ignoreTimeScale = 1;
        }
        
        System.Collections.IEnumerator val_6 = this.<>4__this.ApplyShakeTimedRoutine(shake:  new UnityEngine.Vector2() {x = val_4, y = val_5}, rotation:  new UnityEngine.Quaternion() {x = R6}, duration:  null, ignoreTimeScale:  this.durations[val_2]);
        if((this.<>4__this) != 0)
        {
                UnityEngine.Coroutine val_7 = this.<>4__this.StartCoroutine(routine:  this.<>4__this);
            val_14 = this.<>4__this;
        }
        else
        {
                UnityEngine.Coroutine val_8 = 0.StartCoroutine(routine:  this.<>4__this);
            val_14 = 0;
        }
        
        this.<>4__this._shakeTimedCoroutines.Add(item:  0);
        this.<>2__current = val_14;
        val_9 = 1;
        this.<>1__state = val_9;
        return (bool)val_9;
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
