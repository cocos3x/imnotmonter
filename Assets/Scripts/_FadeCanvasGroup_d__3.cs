using UnityEngine;
private sealed class MMFade.<FadeCanvasGroup>d__3 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public UnityEngine.CanvasGroup target;
    public float targetAlpha;
    public bool unscaled;
    public float duration;
    private float <currentAlpha>5__2;
    private float <t>5__3;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public MMFade.<FadeCanvasGroup>d__3(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_7;
        float val_8;
        UnityEngine.CanvasGroup val_9;
        var val_10;
        if((this.<>1__state) != 1)
        {
                val_7 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_7;
        }
        
            this.<>1__state = 0;
            val_7 = 0;
            if(this.target == 0)
        {
                return (bool)val_7;
        }
        
            val_9 = this.target;
            this.<currentAlpha>5__2 = this.target;
            this.<t>5__3 = 0f;
        }
        else
        {
                val_8 = 1f;
            val_9 = this.target;
            this.<>1__state = 0;
            if((this.<>1__state) >= 0)
        {
                val_7 = 0;
            val_9.alpha = val_8;
            return (bool)val_7;
        }
        
        }
        
        val_7 = 0;
        if(val_9 == 0)
        {
                return (bool)val_7;
        }
        
        this.target.alpha = UnityEngine.Mathf.SmoothStep(from:  this.target.alpha, to:  null, t:  null);
        if(this.unscaled != false)
        {
                val_10 = 0;
            float val_5 = UnityEngine.Time.unscaledDeltaTime;
        }
        else
        {
                val_10 = 0;
            float val_6 = UnityEngine.Time.deltaTime;
        }
        
        uint val_7 = 0;
        this.<>2__current = 0;
        val_7 = val_7 / this.duration;
        val_7 = (this.<t>5__3) + val_7;
        this.<t>5__3 = val_7;
        val_7 = 1;
        this.<>1__state = val_7;
        return (bool)val_7;
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
