using UnityEngine;
private sealed class MMFade.<FadeImage>d__0 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public UnityEngine.UI.Image target;
    public UnityEngine.Color color;
    public float duration;
    private float <alpha>5__2;
    private float <t>5__3;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public MMFade.<FadeImage>d__0(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_3;
        int val_8;
        float val_10;
        UnityEngine.UI.Image val_11;
        UnityEngine.Color val_12;
        float val_14;
        if((this.<>1__state) != 1)
        {
                val_8 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_8;
        }
        
            this.<>1__state = 0;
            val_8 = 0;
            if(this.target == 0)
        {
                return (bool)val_8;
        }
        
            UnityEngine.Color val_2 = color;
            val_11 = this.target;
            this.<alpha>5__2 = val_3;
            this.<t>5__3 = 0f;
        }
        else
        {
                this.<>1__state = 0;
            float val_4 = UnityEngine.Time.deltaTime;
            float val_8 = this.duration;
            val_11 = this.target;
            val_8 = 0 / val_8;
            val_8 = (this.<t>5__3) + val_8;
            val_10 = 1f;
            this.<t>5__3 = val_8;
            if((this.<>1__state) >= 0)
        {
                val_12 = this.color;
            val_11.color = new UnityEngine.Color() {r = val_12, g = R7, b = R8, a = this};
            val_8 = 0;
            return (bool)val_8;
        }
        
        }
        
        val_8 = 0;
        if(val_11 == 0)
        {
                return (bool)val_8;
        }
        
        UnityEngine.Color val_7 = new UnityEngine.Color(r:  UnityEngine.Mathf.SmoothStep(from:  val_2.r, to:  val_2.g, t:  val_2.b), g:  val_2.g, b:  val_2.b, a:  val_2.a);
        val_14 = val_7.r;
        val_12 = val_7.b;
        this.target.color = new UnityEngine.Color() {r = val_14, g = val_7.g, b = val_12, a = val_7.a};
        this.<>2__current = 0;
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
