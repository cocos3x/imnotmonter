using UnityEngine;
private sealed class ProCamera2D.<ApplyInfluencesTimedRoutine>d__131 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public float[] durations;
    public Com.LuisPedroFonseca.ProCamera2D.ProCamera2D <>4__this;
    public System.Collections.Generic.IList<UnityEngine.Vector2> influences;
    private int <count>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ProCamera2D.<ApplyInfluencesTimedRoutine>d__131(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_3;
        float val_4;
        int val_8;
        int val_9;
        System.Single[] val_10;
        var val_11;
        var val_12;
        val_8 = 0;
        if((this.<>1__state) != 1)
        {
                if((this.<>1__state) != 0)
        {
                return (bool)val_8;
        }
        
            val_9 = 0;
            this.<count>5__2 = val_9;
            this.<>1__state = val_9;
        }
        else
        {
                val_9 = this.<count>5__2;
            int val_8 = 0;
            this.<>1__state = val_8;
        }
        
        val_10 = this.durations;
        val_8 = val_8 - 1;
        if(val_9 >= val_8)
        {
                return (bool)val_8;
        }
        
        int val_1 = (this.<count>5__2) + 1;
        this.<count>5__2 = val_1;
        float val_9 = this.durations[val_1];
        var val_10 = 0;
        val_10 = val_10 + 1;
        val_11 = this.influences;
        val_10 = val_3;
        if((this.<>4__this) != 0)
        {
                System.Collections.IEnumerator val_5 = this.<>4__this.ApplyInfluenceTimedRoutine(influence:  new UnityEngine.Vector2() {x = val_10, y = val_4}, duration:  null);
            val_12 = this.<>4__this;
        }
        else
        {
                System.Collections.IEnumerator val_6 = 0.ApplyInfluenceTimedRoutine(influence:  new UnityEngine.Vector2() {x = val_10, y = val_4}, duration:  null);
            val_12 = 0;
        }
        
        UnityEngine.Coroutine val_7 = this.<>4__this.StartCoroutine(routine:  0);
        this.<>2__current = this.<>4__this;
        val_8 = 1;
        this.<>1__state = val_8;
        return (bool)val_8;
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
